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
        public static Byte[] streamToByte(Stream sourceStream)
        {
            using (var memoryStream = new MemoryStream())
            {
                sourceStream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }

        public static void addData(String folder, CompoundFile cf )
        {
            //Get list of files
            var RootFolder = Directory.GetFileSystemEntries(folder);

            

            foreach (var RootElement in RootFolder)
            {
                //var path = Path.Combine(folder, f);
                FileAttributes attr = File.GetAttributes(RootElement);

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    var name = Path.GetFileName(RootElement);
                    var cfFolder = cf.RootStorage.AddStorage(name);
                    var storageFolder = Directory.GetFiles(RootElement);

                    foreach (var child in storageFolder)
                    {
                        FileStream data = new FileStream(child, FileMode.Open, FileAccess.Read);
                        var StreamName = Path.GetFileName(child);
                        var d = cfFolder.AddStream(StreamName);
                        d.SetData(streamToByte(data));

                    }
                }
                else
                {
                    FileStream data = new FileStream(RootElement, FileMode.Open, FileAccess.Read);
                    var name = Path.GetFileName(RootElement);
                    var d = cf.RootStorage.AddStream(name);
                    d.SetData(streamToByte(data));
                }



            }
        }

        public static void wrapper( string folder, string destination)
        {

            //Create new compoundFile
            CompoundFile compFile = new CompoundFile();
            addData(folder, compFile);

            compFile.Save(destination);


        }
    }
}
