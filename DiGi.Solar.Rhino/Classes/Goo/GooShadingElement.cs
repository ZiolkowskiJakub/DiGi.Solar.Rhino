using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using DiGi.Solar.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Solar.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper-compatible wrapper for shading solver results, enabling serialization and baking of the resulting geometry.
    /// </summary>
    public class GooShadingSolverResult : GooBakeAwareSerializableObject<IShadingSolverResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooShadingSolverResult"/> class.
        /// </summary>
        public GooShadingSolverResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooShadingSolverResult"/> class with the specified shading solver result.
        /// </summary>
        /// <param name="shadingSolverResult">The shading solver result to be wrapped.</param>
        public GooShadingSolverResult(IShadingSolverResult? shadingSolverResult)
        {
            Value = shadingSolverResult;
        }

        /// <summary>
        /// Gets the collection of geometries associated with the shading solver result.
        /// </summary>
        /// <returns>An array of <see cref="IGeometry"/> objects if the value is a geometrical shading solver result; otherwise, null.</returns>
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

        /// <summary>
        /// Creates a duplicate of the current shading solver result wrapper.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance representing the duplicated object.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooShadingSolverResult(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type used to handle <see cref="GooShadingSolverResult"/> objects within a component.
    /// </summary>
    public class GooShadingSolverResultParam : GooBakeAwareSerializableParam<GooShadingSolverResult, IShadingSolverResult>
    {
        /// <summary>
        /// Gets the unique identifier for the shading solver result parameter component.
        /// </summary>
        public override Guid ComponentGuid => new("7e77b407-41d2-48fa-aead-a314514721d7");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}