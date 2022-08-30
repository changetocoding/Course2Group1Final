using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string mypath = @"C:\Users\Student\Documents\BATCH 1\";
            //string[] dirs = Directory.GetDirectories(mypath);
            //foreach(string d in dirs)
            //{
            //    Console.WriteLine(Path.GetFileName(d));
            //    Console.WriteLine(Path.GetFileNameWithoutExtension(d));
            //}

            ////string newpath = @"C:\Users\Student\Documents\BATCH 1\subfolder a\sub-subfolder b";
            ////Directory.CreateDirectory(newpath);

            string[] files = Directory.GetFiles(mypath);
            string destinationfolder = @"C:\Users\Student\Documents\BATCH 2\";

            foreach(string file in files)
            {
                File.Move(file, $"{destinationfolder}");
            }









            Console.ReadLine();
        }
    }
}
