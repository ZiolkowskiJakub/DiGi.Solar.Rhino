using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.Solar.ComputeSharp.Rhino.Classes
{
    /// <summary>
    /// Provides assembly information for the DiGi.Solar.ComputeSharp.Rhino Grasshopper plugin.
    /// </summary>
    public class RhinoInfo : GH_AssemblyInfo
    {
        /// <summary>
        /// Gets the name of the GHA library.
        /// </summary>
        public override string Name => "DiGi.Solar.ComputeSharp.Rhino";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        /// <summary>
        /// Gets the bitmap icon representing this GHA library.
        /// </summary>
        public override Bitmap? Icon => null;

        //Return a short string describing the purpose of this GHA library.
        /// <summary>
        /// Gets a short description describing the purpose of this GHA library.
        /// </summary>
        public override string Description => "";

        /// <summary>
        /// Gets the unique identifier for this assembly.
        /// </summary>
        public override Guid Id => new("ff8df8de-3d7e-4ccf-9b31-f96cc2aad2ce");

        //Return a string identifying you or your company.
        /// <summary>
        /// Gets the name of the author or company that created the library.
        /// </summary>
        public override string AuthorName => "Jakub Ziolkowski";

        //Return a string representing your preferred contact details.
        /// <summary>
        /// Gets the preferred contact details for the author.
        /// </summary>
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}