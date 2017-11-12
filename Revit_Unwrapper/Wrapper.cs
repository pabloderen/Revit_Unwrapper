using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenMcdf;
using extensions = OpenMcdf.Extensions ;
using System.IO;

namespace Revit_Unwrapper
{
    public class Wrapper
    {
        public static void wrapper(string revitFile)
        {
            CompoundFile cf = new CompoundFile(revitFile);
            //TODO: Read the revit temokate ad update with folder content

           
        }
    }
}
