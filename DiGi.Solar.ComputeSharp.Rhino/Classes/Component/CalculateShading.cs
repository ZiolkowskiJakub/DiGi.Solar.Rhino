using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Solar.ComputeSharp.Classes;
using DiGi.Solar.Interfaces;
using DiGi.Solar.Rhino.Classes;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Solar.ComputeSharp.Rhino.Classes
{
    public class CalculateShading : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("89b2166c-ffd3-4f38-b8d2-a28f578dae7f");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public CalculateShading()
          : base("Solar.CalculateShading", "Solar.CalculateShading",
              "Calculate Shading for ShadingModel",
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
                result.Add(new Param(new GooShadingModelParam() { Name = "ShadingModel", NickName = "ShadingModel", Description = "ShadingModel", Access = GH_ParamAccess.item}, ParameterVisibility.Binding));
                result.Add(new Param(new GooShadingCalculatorOptionsParam() { Name = "ShadingCalculatorOptions", NickName = "ShadingCalculatorOptions", Description = "ShadingCalculatorOptions", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

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
                result.Add(new Param(new GooShadingModelParam() { Name = "ShadingModel", NickName = "ShadingModel", Description = "DiGi Solar ShadingModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooShadingCalculationResultParam() { Name = "ShadingCalculationResults", NickName = "ShadingCalculationResults", Description = "DiGi Solar ShadingCalculationResult", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Voluntary));

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
            if (index == -1 || !dataAccess.GetData(index, ref shadingModel) || shadingModel == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("ShadingCalculatorOptions");
            ComputeSharp.Classes.ShadingCalculatorOptions shadingCalculatorOptions = null;
            if (index == -1 || !dataAccess.GetData(index, ref shadingCalculatorOptions) || shadingCalculatorOptions == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            shadingModel = Core.Query.Clone(shadingModel);

            ShadingCalculator shadingCalculator = new ShadingCalculator(shadingModel, shadingCalculatorOptions);
            shadingCalculator.Calculate();

            index = Params.IndexOfOutputParam("ShadingModel");
            if (index != -1)
            {
                dataAccess.SetData(index, shadingModel == null ? null : new GooShadingModel(shadingModel));
            }

            index = Params.IndexOfOutputParam("ShadingCalculationResults");
            if (index != -1)
            {
                List<IShadingCalculationResult> shadingCalculationResults = shadingModel.GetShadingCalculationResults<IShadingCalculationResult>();
                dataAccess.SetDataList(index, shadingCalculationResults?.ConvertAll(x => new GooShadingCalculationResult(x)));
            }
        }
    }
}
