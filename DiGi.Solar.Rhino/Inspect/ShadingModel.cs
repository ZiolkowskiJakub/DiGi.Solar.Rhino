using DiGi.Rhino.Core.Classes;
using DiGi.Solar.Interfaces;
using DiGi.Solar.Rhino.Classes;
using System.Collections;

namespace DiGi.Solar.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the shading elements from a shading model and converts them into Goo-compatible shading elements.
        /// </summary>
        /// <param name="shadingModel">The shading model instance to extract elements from.</param>
        /// <returns>An enumerable collection of converted shading elements, or null if the input shading model is null or contains no elements.</returns>
        [Inspect("ShadingElements", "ShadingElements", "ShadingElements")]
        public static IEnumerable? ShadingElements(this Solar.Classes.ShadingModel? shadingModel)
        {
            if (shadingModel == null)
            {
                return null;
            }

            return shadingModel.GetShadingElements<IShadingElement>()?.ConvertAll(x => new GooShadingElement(x));
        }
    }
}