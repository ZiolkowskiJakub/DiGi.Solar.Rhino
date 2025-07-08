using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Solar.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Solar.Rhino.Classes
{
    public class ShadingCalculationResults : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("2d97950d-7677-4490-865a-949968b3814c");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ShadingCalculationResults()
          : base("Solar.ShadingCalculationResults", "Solar.ShadingCalculationResults",
              "Gets ShadingCalculationResults",
              "DiGi", "DiGi.Solar")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result = new List<Param>();

                result.Add(new Param(new GooShadingModelParam() { Name = "ShadingModel", NickName = "ShadingModel", Description = "DiGi Solar ShadingModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Param_Time() { Name = "Time", NickName = "Time", Description = "Time", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Binding));
                result.Add(new Param(new GooShadingElementParam() { Name = "ShadingElement", NickName = "ShadingElement", Description = "ShadingElement", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));
                result.Add(new Param(new GooEnumParam() { Name = "ShadingCalculationType", NickName = "ShadingCalculationType", Description = "ShadingCalculationType", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));

                return result.ToArray();
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooShadingCalculationResultParam() { Name = "ShadingCalculationResults", NickName = "ShadingCalculationResults", Description = "ShadingCalculationResults", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                return result.ToArray();
            }
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("ShadingModel");
            Solar.Classes.ShadingModel shadingModel = null;
            if (index == -1 || !dataAccess.GetData(index, ref shadingModel))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Time");
            DateTime? dateTime = null;
            if (index != -1)
            {
                DateTime dateTime_Temp = DateTime.MaxValue; 
                if(dataAccess.GetData(index, ref dateTime_Temp) && dateTime_Temp != DateTime.MaxValue)
                {
                    dateTime = dateTime_Temp;
                }
            }

            index = Params.IndexOfInputParam("ShadingElement");
            IShadingElement shadingElement = null;
            if (index != -1)
            {
                if(!dataAccess.GetData(index, ref shadingElement))
                {
                    shadingElement = null;
                }
            }

            index = Params.IndexOfInputParam("ShadingCalculationType");
            Enums.ShadingCalculationType? shadingCalculationType = null;
            if (index != -1)
            {
                Enums.ShadingCalculationType shadingCalculationType_Temp = Enums.ShadingCalculationType.Undefined;
                if (dataAccess.GetData(index, ref shadingCalculationType_Temp))
                {
                    shadingCalculationType = shadingCalculationType_Temp;
                }
            }

            List<IShadingCalculationResult> shadingCalculationResults = null;

            if(shadingElement != null)
            {
                if(shadingCalculationType == null || !shadingCalculationType.HasValue)
                {
                    shadingCalculationResults = shadingModel.GetShadingCalculationResults<IShadingCalculationResult>(shadingElement);
                }
                else if (shadingCalculationType.Value == Enums.ShadingCalculationType.Geometrical)
                {
                    shadingCalculationResults = shadingModel.GetShadingCalculationResults<GeometricalShadingCalculationResult>(shadingElement)?.ConvertAll(x => (IShadingCalculationResult)x);
                }
                else if (shadingCalculationType.Value == Enums.ShadingCalculationType.Numerical)
                {
                    shadingCalculationResults = shadingModel.GetShadingCalculationResults<NumericalShadingCalculationResult>(shadingElement)?.ConvertAll(x => (IShadingCalculationResult)x);
                }
            }
            else
            {
                if (shadingCalculationType == null || !shadingCalculationType.HasValue)
                {
                    shadingCalculationResults = shadingModel.GetShadingCalculationResults<IShadingCalculationResult>();
                }
                else if (shadingCalculationType.Value == Enums.ShadingCalculationType.Geometrical)
                {
                    shadingCalculationResults = shadingModel.GetShadingCalculationResults<GeometricalShadingCalculationResult>()?.ConvertAll(x => (IShadingCalculationResult)x);
                }
                else if (shadingCalculationType.Value == Enums.ShadingCalculationType.Numerical)
                {
                    shadingCalculationResults = shadingModel.GetShadingCalculationResults<NumericalShadingCalculationResult>()?.ConvertAll(x => (IShadingCalculationResult)x);
                }
            }

            if(dateTime != null && dateTime.HasValue )
            {
                shadingCalculationResults = shadingCalculationResults?.FindAll(x => x.DateTime == dateTime.Value);
            }

            index = Params.IndexOfOutputParam("ShadingCalculationResults");
            if (index != -1)
            {
                dataAccess.SetDataList(index, shadingCalculationResults.ConvertAll(x => new GooShadingCalculationResult(x)));
            }
        }
    }
}
