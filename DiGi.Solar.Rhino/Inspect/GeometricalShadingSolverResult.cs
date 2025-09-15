using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using DiGi.Solar.Classes;
using System.Collections;

namespace DiGi.Solar.Rhino
{
    public static partial class Inspect
    {
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