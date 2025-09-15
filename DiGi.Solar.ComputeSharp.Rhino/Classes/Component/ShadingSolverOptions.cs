using DiGi.Core.Interfaces;
using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Solar.ComputeSharp.Rhino.Classes
{
    public class ShadingSolverOptions : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new ("ae9530b9-6069-40f7-aa41-8971fcb4c4b9");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ShadingSolverOptions()
          : base("Solar.ShadingSolverOptions", "Solar.ShadingSolverOptions",
              "Create ShadingSolverOptions",
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
                    new Param(new GooTimeSeriesParam() { Name = "TimeSeries", NickName = "TimeSeries", Description = "TimeSeries", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new GooEnumParam() { Name = "ShadingSolverType", NickName = "ShadingSolverType", Description = "ShadingSolverType", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];

                Param_Number param_Number;

                param_Number = new Param_Number() { Name = "AngleTolerance", NickName = "AngleTolerance", Description = "Angle tolerance", Access = GH_ParamAccess.item, Optional = true };
                param_Number.SetPersistentData(Core.Constans.Tolerance.Angle / 2);
                result.Add(new Param(param_Number, ParameterVisibility.Voluntary));

                param_Number = new Param_Number() { Name = "Tolerance", NickName = "Tolerance", Description = "Tolerance", Access = GH_ParamAccess.item, Optional = true };
                param_Number.SetPersistentData(Core.Constans.Tolerance.Distance);
                result.Add(new Param(param_Number, ParameterVisibility.Voluntary));

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
                    new Param(new GooShadingSolverOptionsParam() { Name = "ShadingSolverOptions", NickName = "ShadingSolverOptions", Description = "DiGi Solar ShadingSolverOptions", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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

            index = Params.IndexOfInputParam("TimeSeries");
            ITimeSeries? timeSeries = null;
            if (index == -1 || !dataAccess.GetData(index, ref timeSeries) || timeSeries is null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("ShadingSolverType");
            Enums.ShadingSolverType shadingSolverType = Enums.ShadingSolverType.Undefined;
            if (index == -1 || !dataAccess.GetData(index, ref shadingSolverType) || shadingSolverType == Enums.ShadingSolverType.Undefined)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double tolerance = Core.Constans.Tolerance.Distance;
            index = Params.IndexOfInputParam("Tolerance");
            if (index != -1)
            {
                dataAccess.GetData(index, ref tolerance);
            }

            double angleTolerance = Core.Constans.Tolerance.Angle / 2;
            index = Params.IndexOfInputParam("AngleTolerance");
            if (index != -1)
            {
                dataAccess.GetData(index, ref angleTolerance);
            }

            ComputeSharp.Classes.ShadingSolverOptions shadingSolverOptions = new()
            {
                TimeSeries = timeSeries,
                ShadingSolverType = shadingSolverType,
                Tolerance = tolerance,
                AngleTolerance = angleTolerance,
            };

            index = Params.IndexOfOutputParam("ShadingSolverOptions");
            if (index != -1)
            {
                dataAccess.SetData(index, shadingSolverOptions == null ? null : new GooShadingSolverOptions(shadingSolverOptions));
            }
        }
    }
}
