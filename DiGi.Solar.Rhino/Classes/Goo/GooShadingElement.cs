using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using DiGi.Solar.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Solar.Rhino.Classes
{
    public class GooShadingSolverResult : GooBakeAwareSerializableObject<IShadingSolverResult>
    {
        public GooShadingSolverResult()
            : base()
        {
        }

        public GooShadingSolverResult(IShadingSolverResult? shadingSolverResult)
        {
            Value = shadingSolverResult;
        }

        public override IGeometry[]? Geometries
        {
            get
            {
                if (Value is not GeometricalShadingSolverResult geometricalShadingSolverResult)
                {
                    return null;
                }

                return geometricalShadingSolverResult.GetPolygonalFace3Ds()?.ToArray();
            }
        }

        public override IGH_Goo Duplicate()
        {
            return new GooShadingSolverResult(Value);
        }
    }

    public class GooShadingSolverResultParam : GooBakeAwareSerializableParam<GooShadingSolverResult, IShadingSolverResult>
    {
        public override Guid ComponentGuid => new("7e77b407-41d2-48fa-aead-a314514721d7");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}