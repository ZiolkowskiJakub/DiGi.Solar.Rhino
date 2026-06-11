using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.Solar.Rhino.Classes
{
    /// <summary>
    /// Provides assembly information for the DiGi Solar Rhino plugin, inheriting from <see cref="GH_AssemblyInfo"/>.
    /// </summary>
    public class RhinoInfo : GH_AssemblyInfo
    {
        /// <summary>
        /// Gets the name of the GHA library.
        /// </summary>
        public override string Name => "DiGi.Solar.Rhino";

        /// <summary>
        /// Gets a 24x24 pixel bitmap to represent this GHA library.
        /// </summary>
        public override Bitmap? Icon => null;

        /// <summary>
        /// Gets a short string describing the purpose of this GHA library.
        /// </summary>
        public override string Description => "";

        /// <summary>
        /// Gets the unique identifier for this assembly.
        /// </summary>
        public override Guid Id => new("f72f18e6-38d7-45c3-9104-59b68498552f");

        /// <summary>
        /// Gets the name of the author or company.
        /// </summary>
        public override string AuthorName => "Jakub Ziolkowski";

        /// <summary>
        /// Gets the preferred contact details for the author.
        /// </summary>
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}