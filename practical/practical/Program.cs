using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;

namespace filespractical
{
    internal class Program
    {
        static void Main(string[] mick)
        {
            string rootpath = @"C:\Users\Student\Desktop\group3 long coarse";

            string []dirs = Directory.GetDirectories(rootpath);

            foreach(string d in dirs)
            {
                Console.WriteLine(d);
            }
        }
    }
}