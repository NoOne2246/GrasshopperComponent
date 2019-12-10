using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace AS4600
{
    public class AS4600Info : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "AS4600";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                return "This is a set of components that are used for checking compliance with AS4600:2018";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("911261ca-568c-4aec-af6f-1028bee4c9fc");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "Christopher Ho";
            }
        }
        public override string AuthorContact
        {
            get
            {
                return "christopher.ho@hotmail.com";
            }
        }
    }
}
