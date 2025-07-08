using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using DiGi.Solar.Classes;
using System.Collections;

namespace DiGi.Solar.Rhino
{
    public static partial class Inspect
    {
        [Inspect("PolygonalFace3Ds", "PolygonalFace3Ds", "PolygonalFace3Ds")]
        public static IEnumerable PolygonalFace3Ds(this GeometricalShadingCalculationResult geometricalShadingCalculationResult)
        {
            if (geometricalShadingCalculationResult == null)
            {
                return null;
            }

            return geometricalShadingCalculationResult?.GetPolygonalFace3Ds()?.ConvertAll(x => new GooPolygonalFace3D(x));
        }
    }
}