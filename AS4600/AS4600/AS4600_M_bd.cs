using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;

namespace AS4600
{
    public class AS4600_M_bd : GH_Component
    {

        public AS4600_M_bd() : base("AS4600 Mbd", "Mbd", "Description","AS4600", "Bending")
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
        protected override void RegisterInputParams(GH_InputParamManager pManager)
        {
            pManager.AddTextParameter("Verbose", "Vin", "Verbose string from a previous component that will be appended to.",
                GH_ParamAccess.list);
            pManager.AddNumberParameter("Z_f", "Zf", "[mm ^ 3] Full unreduced section modulus calculated with the extreme compression or tesnion fibre at fy.", GH_ParamAccess.item);
            pManager.AddNumberParameter("f_od", "fod", "[MPa] Elastic distortional buckling stress.", GH_ParamAccess.item);
            pManager.AddNumberParameter("M_y", "My", "[kNm] Moment causing initial yield at the extreme compression fibre of a full section.", GH_ParamAccess.item);
            pManager.AddNumberParameter("M_p", "Mp", "[kNm] Plastic moment.", GH_ParamAccess.item);
        }

        protected override void RegisterOutputParams(GH_OutputParamManager pManager)
        {
            pManager.AddTextParameter("Verbose", "Vout", "Verbose string output that has been appended to.", GH_ParamAccess.list);
            pManager.AddNumberParameter("M_bd", "Mbd", "[kNm] Nominal member capacity for distortional buckling.", GH_ParamAccess.item);
        }

        protected override void SolveInstance(IGH_DataAccess DA)
        {
            DA.GetDataList(0, Outstring);
            /**
             * solver goes here
             **/
            DA.SetDataList(0, Outstring);
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
            get { return new Guid("d462b054-dc4d-4d36-9fa8-7ab939d4a843"); }
        }
    }
}