using DiGi.Rhino.Core.Classes;
using System;

namespace DiGi.Solar.Rhino.Classes
{
    /// <summary>
    /// Represents a component used to select the shading solver type for solar analysis calculations.
    /// </summary>
    public class ShadingSolverType : EnumComponent<Enums.ShadingSolverType>
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("f5f88580-5603-4c96-9874-3c5a641df941");

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DiGi.Solar.Rhino.Classes.ShadingSolverType" /> class.
        /// </summary>
        public ShadingSolverType()
          : base("Solar")
        {
        }
    }
}