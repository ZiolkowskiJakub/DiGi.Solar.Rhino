using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Solar.ComputeSharp.Rhino.Classes
{
    public class GooShadingSolverOptions : GooSerializableObject<ComputeSharp.Classes.ShadingSolverOptions>
    {
        public GooShadingSolverOptions()
            : base()
        {
        }

        public GooShadingSolverOptions(ComputeSharp.Classes.ShadingSolverOptions? shadingSolverOptions)
            : base()
        {
            Value = shadingSolverOptions;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooShadingSolverOptions(Value);
        }
    }

    public class GooShadingSolverOptionsParam : GooPresistentParam<GooShadingSolverOptions, ComputeSharp.Classes.ShadingSolverOptions>
    {
        public override Guid ComponentGuid => new("a678253f-1c7d-40e8-b858-e213d865362f");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooShadingSolverOptionsParam()
            : base()
        {
        }
    }
}