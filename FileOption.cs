using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XRay
{
    internal class FileOption
    {
        public static string currentDirectory = Directory.GetCurrentDirectory();
        public static string subdirectoryPath = Path.Combine(currentDirectory, "data\\");
        public static string find(string path, string name,string typeFile)
        {
            string[] files = Directory.GetFiles(subdirectoryPath+path, name + "." + typeFile);
            if (files.Length >0)
                return files.First();

            return "";

        }
        public static string[] getAllFiles(string path, string typeFile)
        {
            string[] files = Directory.GetFiles(subdirectoryPath+path , "*." + typeFile);
            return files;

        }
        public static void delete(string path, string name, string typeFile)
        {
            if (File.Exists(subdirectoryPath+ path+ name + "." + typeFile))
            {
                Thread.Sleep(1000);
                File.Delete(subdirectoryPath + path + name + "." + typeFile);
            }
        }
        public static string[] SearchBySize(string path, int sizeKB)
        {
            string[] files = Directory.GetFiles(subdirectoryPath + path, "*.jpeg");
            Console.WriteLine(files.Length);

            return files.Where(file =>
            {
                var fileinfo = new FileInfo(file).Length / 1024;
                return fileinfo >= sizeKB && fileinfo <= (sizeKB + 1);

            }).ToArray();

        }
        public static string[] SearchByDate(string path, DateTime date)
        {
            string[] files = Directory.GetFiles(subdirectoryPath + path, "*.jpeg");

            return files.Where(file =>
            {
                DateTime lastWriteTime = File.GetLastWriteTime(file);
                Console.WriteLine(lastWriteTime);
                Console.WriteLine("///////////////////////");
                Console.WriteLine(date.Date);
                return lastWriteTime.Date == date.Date;
            }).ToArray();

        }
        public static void CreateDocument(string outputFile, string name, string age, string diagnosis, string doctorName, string recommendation)
        {

            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4))
                {
                    using (PdfWriter w = PdfWriter.GetInstance(doc, fs))
                    {
                        doc.Open();

                        PdfPTable t = new PdfPTable(1);
                        t.DefaultCell.Border = 0;
                        t.AddCell("\n \n ");

                        t.AddCell("Patient Name : " + name);
                        t.AddCell("Patient Age : " + age);
                        t.AddCell("\n \n ");
                        t.AddCell("Diagnosis of the disease : \n");
                        t.AddCell(diagnosis);

                        t.AddCell("\n\nDoctor's recommendation : \n");
                        t.AddCell(recommendation);

                        t.AddCell("\n\n\nDoctor Name : " + doctorName);
                        doc.Add(t);

                        doc.Close();
                    }
                }
            }
        }
    }
}
