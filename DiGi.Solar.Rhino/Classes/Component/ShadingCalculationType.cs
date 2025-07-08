using DiGi.Rhino.Core.Classes;
using System;

namespace DiGi.Solar.Rhino.Classes
{
    public class ShadingCalculationType : EnumComponent<Enums.ShadingCalculationType>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("f5f88580-5603-4c96-9874-3c5a641df941");

        /// <summary>
        /// Panel Type
        /// </summary>
        public ShadingCalculationType()
          : base("Solar")
        {
        }
    }
}
