using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using DiGi.Solar.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Solar.Rhino.Classes
{
    public class GooShadingCalculationResult : GooBakeAwareSerializableObject<IShadingCalculationResult>
    {
        public GooShadingCalculationResult()
            : base()
        {
        }

        public GooShadingCalculationResult(IShadingCalculationResult shadingCalculationResult)
        {
            Value = shadingCalculationResult;
        }

        public override IGeometry[] Geometries
        {
            get
            {
                GeometricalShadingCalculationResult geometricalShadingCalculationResult = Value as GeometricalShadingCalculationResult;
                if(geometricalShadingCalculationResult == null)
                {
                    return null;
                }

                return geometricalShadingCalculationResult.GetPolygonalFace3Ds()?.ToArray();
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooShadingCalculationResult(Value);
        }

    }

    public class GooShadingCalculationResultParam : GooBakeAwareSerializableParam<GooShadingCalculationResult, IShadingCalculationResult>
    {
        public override Guid ComponentGuid => new Guid("7e77b407-41d2-48fa-aead-a314514721d7");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
