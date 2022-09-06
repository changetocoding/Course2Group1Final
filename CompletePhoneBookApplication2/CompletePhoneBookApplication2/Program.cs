using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompletePhoneBookApplication2
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            while(true)
            {
                TextWriter path = new StreamWriter(@"C:\Users\Student\Documents\PhoneBook.txt", true);
                Console.WriteLine("PLESE SELECT THE SAVE OPTION");
                string option = Console.ReadLine();
                Console.WriteLine("KINDLY ENTER THE NAME AND PHONE NUMBER YOU WANT TO SAVE:");

                var contact = Console.ReadLine();
                var split = contact.Split(' ');
                var name = split[0];
                var phonenumber = split[1];

                if (option.Equals("save", StringComparison.OrdinalIgnoreCase))
                {
                    path.WriteLine($"{name} {phonenumber}");
                    
                    
                }
                path.Close();
            }
        }
    }
}