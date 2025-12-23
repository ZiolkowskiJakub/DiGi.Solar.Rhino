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
    public class SolveShading : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("89b2166c-ffd3-4f38-b8d2-a28f578dae7f");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public SolveShading()
          : base("Solar.SolveShading", "Solar.SolveShading",
              "Solve Shading for ShadingModel",
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
                    new Param(new GooShadingModelParam() { Name = "ShadingModel", NickName = "ShadingModel", Description = "ShadingModel", Access = GH_ParamAccess.item}, ParameterVisibility.Binding),
                    new Param(new GooShadingSolverOptionsParam() { Name = "ShadingSolverOptions", NickName = "ShadingSolverOptions", Description = "ShadingSolverOptions", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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
                    new Param(new GooShadingModelParam() { Name = "ShadingModel", NickName = "ShadingModel", Description = "DiGi Solar ShadingModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new GooShadingSolverResultParam() { Name = "ShadingSolverResults", NickName = "ShadingSolverResults", Description = "DiGi Solar ShadingSolverResult", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Voluntary),
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
            if (index == -1 || !dataAccess.GetData(index, ref shadingModel) || shadingModel == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            shadingModel = Core.Query.Clone(shadingModel);
            if (shadingModel is null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("ShadingSolverOptions");
            ComputeSharp.Classes.ShadingSolverOptions? shadingSolverOptions = null;
            if (index == -1 || !dataAccess.GetData(index, ref shadingSolverOptions) || shadingSolverOptions == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            ShadingSolver shadingSolver = new(shadingModel, shadingSolverOptions);
            shadingSolver.Solve();

            index = Params.IndexOfOutputParam("ShadingModel");
            if (index != -1)
            {
                dataAccess.SetData(index, shadingModel == null ? null : new GooShadingModel(shadingModel));
            }

            index = Params.IndexOfOutputParam("ShadingSolverResults");
            if (index != -1)
            {
                List<IShadingSolverResult>? shadingColverResults = shadingModel!.GetShadingSolverResults<IShadingSolverResult>();
                dataAccess.SetDataList(index, shadingColverResults?.ConvertAll(x => new GooShadingSolverResult(x)));
            }
        }
    }
}