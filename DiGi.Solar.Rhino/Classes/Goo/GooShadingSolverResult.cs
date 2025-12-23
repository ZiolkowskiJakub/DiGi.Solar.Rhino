using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Solar.Rhino.Classes
{
    public class GooShadingElement : GooBakeAwareSerializableObject<IShadingElement>
    {
        public GooShadingElement()
            : base()
        {
        }

        public GooShadingElement(IShadingElement? shadingElement)
        {
            Value = shadingElement;
        }

        public override IGeometry[]? Geometries
        {
            get
            {
                return Value?.PolygonalFace3D is not IPolygonalFace3D polygonalFace3D ? [] : [polygonalFace3D];
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooShadingElement(Value);
        }
    }

    public class GooShadingElementParam : GooBakeAwareSerializableParam<GooShadingElement, IShadingElement>
    {
        public override Guid ComponentGuid => new("60d50846-5c48-42d9-bc75-59fe2c4ae4d7");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}