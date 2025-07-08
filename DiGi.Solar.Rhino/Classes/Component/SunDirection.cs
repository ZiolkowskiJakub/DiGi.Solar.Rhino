using DiGi.Core.Interfaces;
using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Parameters;
using System;
using System.Collections.Generic;

namespace DiGi.Solar.Rhino.Classes
{
    public class SunDirection : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("1d5fddd1-6565-41a7-93ca-f405556cb1fe");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public SunDirection()
          : base("Solar.SunDirection", "Solar.SunDirection",
              "Calculate Sun Direction",
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
                result.Add(new Param(new GooCoordinatesParam() { Name = "Coordinates", NickName = "Coordinates", Description = "Coordinates", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

                result.Add(new Param(new Param_Time() { Name = "Time", NickName = "Time", Description = "Time", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

                Param_Boolean param_Boolean;

                param_Boolean = new Param_Boolean() { Name = "IncludeNight", NickName = "IncludeNight", Description = "IncludeNight", Access = GH_ParamAccess.item, Optional = true };
                param_Boolean.SetPersistentData(false);
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
                result.Add(new Param(new GooVector3DParam() { Name = "Direction", NickName = "Direction", Description = "Sun Direction", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("Time");
            DateTime dateTime = DateTime.Now;
            if (index == -1 || !dataAccess.GetData(index, ref dateTime) || dateTime == null)
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

            bool includeNight = false;
            index = Params.IndexOfInputParam("IncludeNight");
            if (index != -1)
            {
                dataAccess.GetData(index, ref includeNight);
            }

            Geometry.Spatial.Classes.Vector3D direction = Query.SunDirection(coordinates, uTC, dateTime, includeNight);

            index = Params.IndexOfOutputParam("Direction");
            if (index != -1)
            {
                dataAccess.SetData(index, direction == null ? null : new GooVector3D(direction));
            }
        }
    }
}
