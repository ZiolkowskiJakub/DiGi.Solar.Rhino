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
    /// <summary>
    /// A Grasshopper component that retrieves shading solver results based on a specified shading model and optional parameters such as time, element, and solver type.
    /// </summary>
    public class ShadingSolverResults : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("2d97950d-7677-4490-865a-949968b3814c");

        /// <summary>
        /// Gets the exposure level of the component, which determines how it is displayed in the Grasshopper canvas.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadingSolverResults"/> class.
        /// </summary>
        public ShadingSolverResults()
          : base("Solar.ShadingSolverResults", "Solar.ShadingSolverResults",
              "Gets ShadingSolverResults",
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
                List<Param> result =
                [
                    new Param(new GooShadingModelParam() { Name = "ShadingModel", NickName = "ShadingModel", Description = "DiGi Solar ShadingModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Param_Time() { Name = "Time", NickName = "Time", Description = "Time", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Binding),
                    new Param(new GooShadingElementParam() { Name = "ShadingElement", NickName = "ShadingElement", Description = "ShadingElement", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary),
                    new Param(new GooEnumParam() { Name = "ShadingSolverType", NickName = "ShadingSolverType", Description = "ShadingSolverType", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary),
                ];

                return [.. result];
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooShadingSolverResultParam() { Name = "ShadingSolverResults", NickName = "ShadingSolverResults", Description = "ShadingSolverResults", Access = GH_ParamAccess.list }, ParameterVisibility.Binding),
                ];
                return [.. result];
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
            Solar.Classes.ShadingModel? shadingModel = null;
            if (index == -1 || !dataAccess.GetData(index, ref shadingModel) || shadingModel is null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Time");
            DateTime? dateTime = null;
            if (index != -1)
            {
                DateTime dateTime_Temp = DateTime.MaxValue;
                if (dataAccess.GetData(index, ref dateTime_Temp) && dateTime_Temp != DateTime.MaxValue)
                {
                    dateTime = dateTime_Temp;
                }
            }

            index = Params.IndexOfInputParam("ShadingElement");
            IShadingElement? shadingElement = null;
            if (index != -1)
            {
                if (!dataAccess.GetData(index, ref shadingElement))
                {
                    shadingElement = null;
                }
            }

            index = Params.IndexOfInputParam("ShadingSolverType");
            Enums.ShadingSolverType? shadingSolverType = null;
            if (index != -1)
            {
                Enums.ShadingSolverType shadingSolverType_Temp = Enums.ShadingSolverType.Undefined;
                if (dataAccess.GetData(index, ref shadingSolverType_Temp))
                {
                    shadingSolverType = shadingSolverType_Temp;
                }
            }

            List<IShadingSolverResult>? shadingSolverResults = null;

            if (shadingElement != null)
            {
                if (shadingSolverType == null || !shadingSolverType.HasValue)
                {
                    shadingSolverResults = shadingModel.GetShadingSolverResults<IShadingSolverResult>(shadingElement);
                }
                else if (shadingSolverType.Value == Enums.ShadingSolverType.Geometrical)
                {
                    shadingSolverResults = shadingModel.GetShadingSolverResults<GeometricalShadingSolverResult>(shadingElement)?.ConvertAll(x => (IShadingSolverResult)x);
                }
                else if (shadingSolverType.Value == Enums.ShadingSolverType.Numerical)
                {
                    shadingSolverResults = shadingModel.GetShadingSolverResults<NumericalShadingSolverResult>(shadingElement)?.ConvertAll(x => (IShadingSolverResult)x);
                }
            }
            else
            {
                if (shadingSolverType == null || !shadingSolverType.HasValue)
                {
                    shadingSolverResults = shadingModel.GetShadingSolverResults<IShadingSolverResult>();
                }
                else if (shadingSolverType.Value == Enums.ShadingSolverType.Geometrical)
                {
                    shadingSolverResults = shadingModel.GetShadingSolverResults<GeometricalShadingSolverResult>()?.ConvertAll(x => (IShadingSolverResult)x);
                }
                else if (shadingSolverType.Value == Enums.ShadingSolverType.Numerical)
                {
                    shadingSolverResults = shadingModel.GetShadingSolverResults<NumericalShadingSolverResult>()?.ConvertAll(x => (IShadingSolverResult)x);
                }
            }

            if (dateTime != null && dateTime.HasValue)
            {
                shadingSolverResults = shadingSolverResults?.FindAll(x => x.DateTime == dateTime.Value);
            }

            index = Params.IndexOfOutputParam("ShadingSolverResults");
            if (index != -1)
            {
                dataAccess.SetDataList(index, shadingSolverResults?.ConvertAll(x => new GooShadingSolverResult(x)));
            }
        }
    }
}