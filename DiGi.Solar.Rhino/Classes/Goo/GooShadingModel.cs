using DiGi.Core;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Solar.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper-compatible wrapper for a shading model, enabling serialization and baking within the Rhino/Grasshopper environment.
    /// </summary>
    public class GooShadingModel : GooBakeAwareSerializableObject<Solar.Classes.ShadingModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooShadingModel"/> class.
        /// </summary>
        public GooShadingModel()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooShadingModel"/> class with the specified shading model.
        /// </summary>
        /// <param name="shadingModel">The shading model to be wrapped.</param>
        public GooShadingModel(Solar.Classes.ShadingModel? shadingModel)
        {
            Value = shadingModel;
        }

        /// <summary>
        /// Gets the collection of geometries associated with the current shading model.
        /// </summary>
        /// <returns>An array of <see cref="IGeometry"/> objects representing the shading elements, or null if no value is present.</returns>
        public override IGeometry[]? Geometries
        {
            get
            {
                return Value?.GetShadingElements<IShadingElement>()?.ConvertAll(x => x.PolygonalFace3D).FilterNulls()?.ToArray();
            }
        }

        /// <summary>
        /// Creates a duplicate of the current shading model wrapper.
        /// </summary>
        /// <returns>A new <see cref="GooShadingModel"/> instance containing a copy of the original value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooShadingModel(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type used to handle and pass <see cref="GooShadingModel"/> objects between components.
    /// </summary>
    public class GooShadingModelParam : GooBakeAwareSerializableParam<GooShadingModel, Solar.Classes.ShadingModel>
    {
        /// <summary>
        /// Gets the unique identifier for the shading model component.
        /// </summary>
        /// <returns>The <see cref="Guid"/> associated with this parameter type.</returns>
        public override Guid ComponentGuid => new("994c9cee-be9b-4c4f-acb7-59e2cab747fd");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}