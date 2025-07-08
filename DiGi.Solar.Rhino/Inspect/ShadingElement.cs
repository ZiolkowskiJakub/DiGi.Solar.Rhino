using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel.Types;

namespace DiGi.Solar.Rhino
{
    public static partial class Inspect
    {
        [Inspect("Reference", "Reference", "Reference")]
        public static GH_String Reference(this IShadingElement shadingElement)
        {
            if (shadingElement == null)
            {
                return null;
            }

            return new GH_String(shadingElement.Reference);
        }

        [Inspect("ShadingOnly", "ShadingOnly", "ShadingOnly")]
        public static GH_Boolean ShadingOnly(this IShadingElement shadingElement)
        {
            if (shadingElement == null)
            {
                return null;
            }

            return new GH_Boolean(shadingElement.ShadingOnly);
        }

        [Inspect("PolygonalFace3D", "PolygonalFace3D", "PolygonalFace3D")]
        public static GooPolygonalFace3D PolygonalFace3D(this IShadingElement shadingElement)
        {
            if (shadingElement == null)
            {
                return null;
            }

            return new GooPolygonalFace3D(shadingElement.PolygonalFace3D);
        }
    }
}