using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using DiGi.Solar.Classes;
using System.Collections;

namespace DiGi.Solar.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the collection of polygonal faces from the geometrical shading solver result, converting them to <see cref="GooPolygonalFace3D"/> instances.
        /// </summary>
        /// <param name="geometricalShadingSolverResult">The geometrical shading solver result containing the data to extract.</param>
        /// <returns>An enumerable collection of <see cref="GooPolygonalFace3D"/> objects if the input is not null; otherwise, null.</returns>
        [Inspect("PolygonalFace3Ds", "PolygonalFace3Ds", "PolygonalFace3Ds")]
        public static IEnumerable? PolygonalFace3Ds(this GeometricalShadingSolverResult? geometricalShadingSolverResult)
        {
            if (geometricalShadingSolverResult == null)
            {
                return null;
            }

            return geometricalShadingSolverResult?.GetPolygonalFace3Ds()?.ConvertAll(x => new GooPolygonalFace3D(x));
        }
    }
}