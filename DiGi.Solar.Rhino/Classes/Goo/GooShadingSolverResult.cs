using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Solar.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for an <see cref="IShadingElement"/>.
    /// </summary>
    public class GooShadingElement : GooBakeAwareSerializableObject<IShadingElement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooShadingElement"/> class.
        /// </summary>
        public GooShadingElement()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooShadingElement"/> class with the specified shading element.
        /// </summary>
        /// <param name="shadingElement">The shading element to wrap.</param>
        public GooShadingElement(IShadingElement? shadingElement)
        {
            Value = shadingElement;
        }

        /// <summary>
        /// Gets the geometries associated with the shading element.
        /// </summary>
        public override IGeometry[]? Geometries
        {
            get
            {
                return Value?.PolygonalFace3D is not IPolygonalFace3D polygonalFace3D ? [] : [polygonalFace3D];
            }
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new <see cref="GooShadingElement"/> instance containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooShadingElement(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter for handling <see cref="GooShadingElement"/> objects.
    /// </summary>
    public class GooShadingElementParam : GooBakeAwareSerializableParam<GooShadingElement, IShadingElement>
    {
        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("60d50846-5c48-42d9-bc75-59fe2c4ae4d7");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}