using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Solar.ComputeSharp.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper-compatible wrapper for shading solver options, enabling serialization and data flow within the Grasshopper environment.
    /// </summary>
    public class GooShadingSolverOptions : GooSerializableObject<ComputeSharp.Classes.ShadingSolverOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooShadingSolverOptions" /> class.
        /// </summary>
        public GooShadingSolverOptions()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooShadingSolverOptions" /> class with the specified shading solver options.
        /// </summary>
        /// <param name="shadingSolverOptions">The shading solver options to wrap.</param>
        public GooShadingSolverOptions(ComputeSharp.Classes.ShadingSolverOptions? shadingSolverOptions)
            : base()
        {
            Value = shadingSolverOptions;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooShadingSolverOptions" /> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo" /> instance that is a copy of the current object.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooShadingSolverOptions(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter component used to handle <see cref="GooShadingSolverOptions" /> data.
    /// </summary>
    public class GooShadingSolverOptionsParam : GooPresistentParam<GooShadingSolverOptions, ComputeSharp.Classes.ShadingSolverOptions>
    {
        /// <summary>
        /// Gets the unique identifier for the <see cref="GooShadingSolverOptionsParam" /> component.
        /// </summary>
        public override Guid ComponentGuid => new("a678253f-1c7d-40e8-b858-e213d865362f");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooShadingSolverOptionsParam" /> class.
        /// </summary>
        public GooShadingSolverOptionsParam()
            : base()
        {
        }
    }
}