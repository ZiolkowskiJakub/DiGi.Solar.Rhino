using DiGi.Rhino.Core.Classes;
using DiGi.Solar.Interfaces;
using DiGi.Solar.Rhino.Classes;
using System.Collections;

namespace DiGi.Solar.Rhino
{
    public static partial class Inspect
    {
        [Inspect("ShadingElements", "ShadingElements", "ShadingElements")]
        public static IEnumerable ShadingElements(this Solar.Classes.ShadingModel shadingModel)
        {
            if (shadingModel == null)
            {
                return null;
            }

            return shadingModel.GetShadingElements<IShadingElement>().ConvertAll(x => new GooShadingElement(x));
        }
    }
}