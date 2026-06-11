using DiGi.Rhino.Core.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel.Types;

namespace DiGi.Solar.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the date and time from a shading solver result as a Grasshopper <see cref="GH_Time"/> object.
        /// </summary>
        /// <param name="shadingSolverResult">The shading solver result to extract the date and time from.</param>
        /// <returns>A <see cref="GH_Time"/> instance representing the date and time, or <see langword="null" /> if the input is null.</returns>
        [Inspect("DateTime", "DateTime", "DateTime")]
        public static GH_Time? DateTime(this IShadingSolverResult? shadingSolverResult)
        {
            if (shadingSolverResult == null)
            {
                return null;
            }

            return new GH_Time(shadingSolverResult.DateTime);
        }

        /// <summary>
        /// Extracts the area from a shading solver result as a Grasshopper <see cref="GH_Number"/> object.
        /// </summary>
        /// <param name="shadingSolverResult">The shading solver result to extract the area from.</param>
        /// <returns>A <see cref="GH_Number"/> instance representing the area, or <see langword="null" /> if the input is null.</returns>
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