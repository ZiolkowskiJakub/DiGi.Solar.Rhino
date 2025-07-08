using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Solar.Rhino.Classes
{
    public class ShadingModel : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("4a4d50a7-855b-43d8-970f-0722df8f69d2");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ShadingModel()
          : base("Solar.ShadingModel", "Solar.ShadingModel",
              "Creates ShadingModel",
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
                result.Add(new Param(new GooEnumParam() { Name = "UTC", NickName = "UTC", Description = "DiGi UTC", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooCoordinatesParam() { Name = "Coordinates", NickName = "Coordinates", Description = "Coordinates", Access = GH_ParamAccess.item}, ParameterVisibility.Binding));
                result.Add(new Param(new GooShadingElementParam() { Name = "ShadingElements", NickName = "ShadingElements", Description = "ShadingElements", Access = GH_ParamAccess.list}, ParameterVisibility.Binding));

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
                result.Add(new Param(new GooShadingModelParam() { Name = "ShadingModel", NickName = "ShadingModel", Description = "DiGi Solar ShadingModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("UTC");
            Core.Enums.UTC uTC = Core.Enums.UTC.Undefined;
            if (index == -1 || !dataAccess.GetData(index, ref uTC))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Coordinates");
            Core.Classes.Coordinates coordinates = null;
            if (index == -1 || !dataAccess.GetData(index, ref coordinates) || coordinates == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("ShadingElements");
            List<IShadingElement> shadingElements = new List<IShadingElement>();
            if (index == -1 || !dataAccess.GetDataList(index, shadingElements) || shadingElements == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Solar.Classes.ShadingModel shadingModel = new Solar.Classes.ShadingModel(uTC, coordinates);
            foreach(IShadingElement shadingElement in shadingElements)
            {
                shadingModel.Update(shadingElement);
            }

            index = Params.IndexOfOutputParam("ShadingModel");
            if (index != -1)
            {
                dataAccess.SetData(index, shadingModel == null ? null : new GooShadingModel(shadingModel));
            }
        }
    }
}
