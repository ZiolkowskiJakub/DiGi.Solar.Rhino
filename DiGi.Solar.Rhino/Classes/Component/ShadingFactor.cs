using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Solar.Interfaces;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using Grasshopper.Kernel.Types;
using System;
using System.Collections.Generic;

namespace DiGi.Solar.Rhino.Classes
{
    public class ShadingFactor : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("5e94ec0b-6a8b-4d75-9f10-41313b4eb2fc");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ShadingFactor()
          : base("Solar.ShadingFactor", "Solar.ShadingFactor",
              "Calculates shading factor",
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

                result.Add(new Param(new GooShadingModelParam() { Name = "ShadingModel", NickName = "ShadingModel", Description = "DiGi Solar ShadingModel", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Param_Time() { Name = "Time", NickName = "Time", Description = "Time", Access = GH_ParamAccess.item}, ParameterVisibility.Binding));
                result.Add(new Param(new GooShadingElementParam() { Name = "ShadingElement", NickName = "ShadingElement", Description = "ShadingElement", Access = GH_ParamAccess.item}, ParameterVisibility.Binding));

                Param_Boolean param_Boolean;

                param_Boolean = new Param_Boolean() { Name = "Interpolation", NickName = "Interpolation", Description = "Interpolation", Access = GH_ParamAccess.item, Optional = true };
                param_Boolean.SetPersistentData(true);
                result.Add(new Param(param_Boolean, ParameterVisibility.Voluntary));

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
                result.Add(new Param(new Param_Number() { Name = "Factor", NickName = "Factor", Description = "Factor", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("ShadingModel");
            Solar.Classes.ShadingModel shadingModel = null;
            if (index == -1 || !dataAccess.GetData(index, ref shadingModel))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Time");
            DateTime dateTime = DateTime.Now;
            if (index == -1 || !dataAccess.GetData(index, ref dateTime))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("ShadingElement");
            IShadingElement shadingElement = null;
            if (index == -1 || !dataAccess.GetData(index, ref shadingElement) || shadingElement == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            bool interpolation = true;
            index = Params.IndexOfInputParam("Interpolation");
            if (index != -1)
            {
                dataAccess.GetData(index, ref interpolation);
            }

            shadingModel.TryGetShadingFactor(shadingElement, dateTime, out double factor, interpolation);

            index = Params.IndexOfOutputParam("Factor");
            if (index != -1)
            {
                dataAccess.SetData(index, new GH_Number(factor));
            }
        }
    }
}
