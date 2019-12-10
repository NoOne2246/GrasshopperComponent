using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace ChrisCustomLibrary
{
    public class ChrisCustomLibrary : GH_AssemblyInfo
  {
    public override string Name
    {
        get
        {
            return "ChrisCustomLibrary";
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
            //Return a short string describing the purpose of this GHA library.
            return "";
        }
    }
    public override Guid Id
    {
        get
        {
            return new Guid("4d8ef61d-a723-4af1-9923-95559d633e4a");
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
            //Return a string representing your preferred contact details.
            return "christopher.ho@neng.com.au";
        }
    }
}
}
