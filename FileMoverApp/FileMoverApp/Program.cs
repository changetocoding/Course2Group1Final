using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileMoverApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. To create a new sub folder in the Download folders

                    var mypath = @"C:\Users\Student\Downloads\Images";
                    var directoryexist= Directory.Exists(mypath);
                    if (directoryexist)
                    {
                        Console.WriteLine("The directory already exist");
                    }
                    else
                    {
                        Directory.CreateDirectory(mypath);
                    }
                    
                   

            // 2. Checking whether image files exists in the Download folders

                    var download = @"C:\Users\Student\Downloads\";
                    string[] don = Directory.GetFiles(download,"*.JPG");
                    if (don.Length==0)
                    {
                        Console.WriteLine("Your download folder does not contain any image file");
                    }
                    else
                    {
                        Console.WriteLine("Image files are contained in your download folders");
                    }
            
            // 3. Moving files from Downloads to Images and handling the error exception

                    string destination = @"C:\Users\Student\Downloads\Images\";

                        foreach (string file in don)
                        {
                            Console.WriteLine(Path.GetFileName(file));
                            try
                            {
                                File.Move(file, $"{destination}{Path.GetFileName(file)}");
                                Console.WriteLine("The file have been successfully moved");

                            }
                            catch (Exception)
                            {

                                Console.WriteLine("An image already exists in the image folder");
                                Console.WriteLine("The file was not successfully moved");
                            }
                        }

           












            Console.ReadLine();

        }

    }
}
