using System;
using System.Collections.Generic;
using GH_IO.Serialization;
using Grasshopper.Kernel;
using Rhino.Geometry;


namespace ChrisCustomLibrary
{
    public class ChrisLibrary : GH_Component
    {
        private List<List<Boolean>> m_Check = new List<List<Boolean>>();
        public List<List<Boolean>> Check
        {
            get { return m_Check; }
            set
            {
                m_Check = value;
            }
        }
        public ChrisLibrary()
          : base("Check_Selection", "CheckBox",
              "Allows the user to make a selection from an array of choices.",
              "Custom", "Selection")
        {
        }

        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddIntegerParameter("X", "X", "Number of inputs in the x direction", GH_ParamAccess.item,3);
            pManager.AddIntegerParameter("Y", "Y", "Number of inputs in the y direction", GH_ParamAccess.item,2);
        }

        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddBooleanParameter("Table", "T", "Table of boolean selection.", GH_ParamAccess.tree);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
        }

        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                // You can add image files to your project resources and access them like this:
                //return Resources.IconForThisComponent;
                return null;
            }
        }

        public override bool Read(GH_IReader reader)
        {
            Check = reader.get
            return base.Read(reader);
        }

        public override Guid ComponentGuid
        {
            get { return new Guid("6dc5d561-0e26-4d3f-8687-ab2d96ed9fc0"); }
        }
    }
}
