using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRay
{
    internal class Compress
    {
        public static void create(string name)
        {
            if (FileOption.find("", name, "zip").Length > 0)
                FileOption.delete("", name, "zip");

            if ( FileOption.find("images\\", name, "jpeg").Length > 0)
            {
                using (ZipArchive zip = ZipFile.Open("data/"+ name+".zip", ZipArchiveMode.Create))
                {
                    zip.CreateEntryFromFile(FileOption.subdirectoryPath + "images\\" + name + ".jpeg", name + ".jpeg");
                    if (FileOption.find("sounds\\", name, "wav").Length > 0)
                        zip.CreateEntryFromFile(FileOption.subdirectoryPath + "sounds\\" + name + ".wav", name + ".wav");
                    if (FileOption.find("reports\\", name, "pdf").Length > 0)
                        zip.CreateEntryFromFile(FileOption.subdirectoryPath + "reports\\" + name + ".pdf", name + ".pdf");
                }
            }
        }
    }
}
