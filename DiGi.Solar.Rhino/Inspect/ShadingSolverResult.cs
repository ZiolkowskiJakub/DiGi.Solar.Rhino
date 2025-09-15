using DiGi.Rhino.Core.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel.Types;

namespace DiGi.Solar.Rhino
{
    public static partial class Inspect
    {
        [Inspect("DateTime", "DateTime", "DateTime")]
        public static GH_Time? DateTime(this IShadingSolverResult? shadingSolverResult)
        {
            if (shadingSolverResult == null)
            {
                return null;
            }

            return new GH_Time(shadingSolverResult.DateTime);
        }

        [Inspect("Area", "Area", "Area")]
        public static GH_Number? Area(this IShadingSolverResult? shadingSolverResult)
        {
            if (shadingSolverResult == null)
            {
                return null;
            }

            return new GH_Number(shadingSolverResult.Area);
        }
    }
}