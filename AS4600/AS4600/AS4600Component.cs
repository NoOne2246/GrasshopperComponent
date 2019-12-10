using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

// In order to load the result of this wizard, you will also need to
// add the output bin/ folder of this project to the list of loaded
// folder in Grasshopper.
// You can use the _GrasshopperDeveloperSettings Rhino command for that.

namespace AS4600
{
    public class AS4600 : GH_Component
    {
        public AS4600(String Name, String Nickname, String Description, String Category, String Subcategory)
            : base(Name, Nickname,Description,Category,Subcategory)
        {

        }
        private List<String> m_Outstring = new List<string>();
        public List<String> Outstring
        {
            get { return m_Outstring; }
            set
            {
                m_Outstring = value;
            }
        }
        public override Guid ComponentGuid => throw new NotImplementedException();

        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Verbose", "Vin", "Verbose string from a previous component that will be appended to.",
                GH_ParamAccess.list);
            pManager = AddInput(pManager);
        }

        private GH_InputParamManager AddInput(GH_InputParamManager pManager)
        {
            return pManager;
        }
        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Verbose", "Vout", "Verbose string output that has been appended to.", GH_ParamAccess.list);
            pManager = AddOutput(pManager);
        }
        private GH_OutputParamManager AddOutput(GH_OutputParamManager pManager)
        {
            return pManager;
        }
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            DA.GetDataList(0, this.Outstring);
            DA = Solver(DA);
            DA.SetDataList(0, this.Outstring);
            
        }
        private IGH_DataAccess Solver(IGH_DataAccess DA)
        {
            throw new NotImplementedException();
            return DA;
        }
    }
    public class AS4600_M_bl : AS4600
    {

        public AS4600_M_bl() : base("AS4600 Mbl", "Mbl", "Description", "AS4600", "Bending")
        {
        }
        private GH_InputParamManager AddInput(GH_InputParamManager pManager)
        {
            pManager.AddNumberParameter("fy", "fy", "Steel yield strength", GH_ParamAccess.item, 450.0);
            return pManager;
        }
        private GH_OutputParamManager AddOutput(GH_OutputParamManager pManager)
        {
            pManager.AddNumberParameter("Mbl", "Mbl", "Local buckling moment", GH_ParamAccess.item);
            return pManager;
        }

        private IGH_DataAccess Solver(IGH_DataAccess DA)
        {
            Double fy = new Double();
            DA.GetData(1, ref fy);
            DA.SetData(1, fy);
            return DA;
        }

        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return null;
            }
        }

        public override Guid ComponentGuid
        {
            get { return new Guid("1c13d483-ad63-4a63-b640-02d4ef277ee9"); }
        }
    }

    public class AS4600_M_bd : AS4600
    {

        public AS4600_M_bd() : base("AS4600 Mbd", "Mbd", "Description", "AS4600", "Bending")
        {
        }
        private GH_InputParamManager AddInput(GH_InputParamManager pManager)
        {
            pManager.AddNumberParameter("fy", "fy", "Steel yield strength", GH_ParamAccess.item, 450.0);
            return pManager;
        }
        private GH_OutputParamManager AddOutput(GH_OutputParamManager pManager)
        {
            pManager.AddNumberParameter("Mbd", "Mbd", "distortional buckling moment", GH_ParamAccess.item);
            return pManager;
        }

        private IGH_DataAccess Solver(IGH_DataAccess DA)
        {
            Double fy = new Double();
            DA.GetData(1, ref fy);
            DA.SetData(1, fy);
            return DA;
        }

        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                return null;
            }
        }

        public override Guid ComponentGuid
        {
            get { return new Guid("ec2e889a-d956-42a3-a7f6-c32559840b81"); }
        }
    }
}
