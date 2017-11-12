using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Revit_Unwrapper
{
    class _7zip
    {
        public static string AssemblyDirectory ()
        {

                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            
        }
        public static void ExtractFile(string source, string destination)
        {
            // If the directory doesn't exist, create it.
            if (!Directory.Exists(destination))
                Directory.CreateDirectory(destination);

            string zPath = AssemblyDirectory() + @"\Reference\7-Zip\7zG.exe";
            // change the path and give yours 
            try
            {
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = zPath;
                pro.Arguments = "x \"" + source + "\" -o" + destination;
                Process x = Process.Start(pro);
                x.WaitForExit();
            }
            catch (System.Exception Ex)
            {
                //DO logic here 
            }
        }
    }
}
