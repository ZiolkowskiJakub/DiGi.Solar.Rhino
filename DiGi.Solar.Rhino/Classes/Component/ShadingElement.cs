using DiGi.Geometry.Spatial.Classes;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Solar.Rhino.Classes
{
    public class ShadingElement : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("b3cf736f-8cfe-41b2-93af-fb802f5e12a8");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ShadingElement()
          : base("Solar.ShadingElement", "Solar.ShadingElement",
              "Creates ShadingElement",
              "DiGi", "DiGi.Solar")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooPolygonalFace3DParam() { Name = "PolygonalFace3D", NickName = "PolygonalFace3D", Description = "DiGi Solar PolygonalFace3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Param_String() { Name = "Reference", NickName = "Reference", Description = "Reference", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));
                result.Add(new Param(new Param_Boolean() { Name = "ShadingOnly", NickName = "ShadingOnly", Description = "ShadingOnly", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary));

                return result.ToArray();
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooShadingElementParam() { Name = "ShadingElement", NickName = "ShadingElement", Description = "DiGi Solar ShadingElement", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                return result.ToArray();
            }
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("PolygonalFace3D");
            IPolygonalFace3D polygonalFace3D = null;
            if (index == -1 || !dataAccess.GetData(index, ref polygonalFace3D) || polygonalFace3D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            string reference = null;
            index = Params.IndexOfInputParam("Reference");
            if (index != -1)
            {
                dataAccess.GetData(index, ref reference);
            }

            bool shadingOnly = false;
            index = Params.IndexOfInputParam("ShadingOnly");
            if (index != -1)
            {
                dataAccess.GetData(index, ref shadingOnly);
            }

            Solar.Classes.ShadingElement shadingElement = new Solar.Classes.ShadingElement(reference, polygonalFace3D, shadingOnly);

            index = Params.IndexOfOutputParam("ShadingElement");
            if (index != -1)
            {
                dataAccess.SetData(index, shadingElement == null ? null : new GooShadingElement(shadingElement));
            }
        }
    }
}
