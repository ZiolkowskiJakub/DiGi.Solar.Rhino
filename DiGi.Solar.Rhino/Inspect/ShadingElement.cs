using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel.Types;

namespace DiGi.Solar.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the reference identifier of the specified shading element as a Grasshopper string.
        /// </summary>
        /// <param name="shadingElement">The shading element to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the reference, or <see langword="null" /> if the input is null.</returns>
        [Inspect("Reference", "Reference", "Reference")]
        public static GH_String? Reference(this IShadingElement? shadingElement)
        {
            if (shadingElement == null)
            {
                return null;
            }

            return new GH_String(shadingElement.Reference);
        }

        /// <summary>
        /// Retrieves whether the specified shading element is for shading only as a Grasshopper boolean.
        /// </summary>
        /// <param name="shadingElement">The shading element to inspect.</param>
        /// <returns>A <see cref="GH_Boolean"/> indicating if it's shading only, or <see langword="null" /> if the input is null.</returns>
        [Inspect("ShadingOnly", "ShadingOnly", "ShadingOnly")]
        public static GH_Boolean? ShadingOnly(this IShadingElement? shadingElement)
        {
            if (shadingElement == null)
            {
                return null;
            }

            return new GH_Boolean(shadingElement.ShadingOnly);
        }

        /// <summary>
        /// Retrieves the polygonal face geometry of the specified shading element as a Goo wrapper.
        /// </summary>
        /// <param name="shadingElement">The shading element to inspect.</param>
        /// <returns>A <see cref="GooPolygonalFace3D"/> containing the polygonal face, or <see langword="null" /> if the input is null.</returns>
        [Inspect("PolygonalFace3D", "PolygonalFace3D", "PolygonalFace3D")]
        public static GooPolygonalFace3D? PolygonalFace3D(this IShadingElement? shadingElement)
        {
            if (shadingElement == null)
            {
                return null;
            }

            return new GooPolygonalFace3D(shadingElement.PolygonalFace3D);
        }
    }
}