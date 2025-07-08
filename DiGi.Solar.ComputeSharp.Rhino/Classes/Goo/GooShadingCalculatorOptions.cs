using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Solar.ComputeSharp.Rhino.Classes
{
    public class GooShadingCalculatorOptions : GooSerializableObject<ComputeSharp.Classes.ShadingCalculatorOptions>
    {
        public GooShadingCalculatorOptions()
            : base()
        {
        }

        public GooShadingCalculatorOptions(ComputeSharp.Classes.ShadingCalculatorOptions shadingCalculatorOptions)
            : base()
        {
            Value = shadingCalculatorOptions;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooShadingCalculatorOptions(Value);
        }
    }

    public class GooShadingCalculatorOptionsParam : GooPresistentParam<GooShadingCalculatorOptions, ComputeSharp.Classes.ShadingCalculatorOptions>
    {
        public override Guid ComponentGuid => new Guid("a678253f-1c7d-40e8-b858-e213d865362f");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooShadingCalculatorOptionsParam()
            : base()
        {
        }
    }
}
