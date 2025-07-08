using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Solar.Rhino.Classes
{
    public class GooShadingModel : GooBakeAwareSerializableObject<Solar.Classes.ShadingModel>
    {
        public GooShadingModel()
            : base()
        {
        }

        public GooShadingModel(Solar.Classes.ShadingModel shadingModel)
        {
            Value = shadingModel;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                return Value?.GetShadingElements<IShadingElement>().ConvertAll(x => x.PolygonalFace3D).ToArray();
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooShadingModel(Value);
        }

    }

    public class GooShadingModelParam : GooBakeAwareSerializableParam<GooShadingModel, Solar.Classes.ShadingModel>
    {
        public override Guid ComponentGuid => new Guid("994c9cee-be9b-4c4f-acb7-59e2cab747fd");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
