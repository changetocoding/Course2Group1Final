using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace practical
{
    internal class Program
    {

        static void Living(string[] args)
        {
            do
            {
                int perview = 5;

                Console.WriteLine("Enter a Page number");

                if (int.TryParse(Console.ReadLine(), out int pagenumber))
                {
                    var ms = GetEmployees().Skip((pagenumber - 1) * perview).Take(perview);

                    foreach (var item in ms)
                    {
                        Console.WriteLine($"{item.Id}   {item.And_Their_Name}");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid page");
                }
            } while (true);
        }

        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee{Id=1, And_Their_Name="Isama Michael"},
                new Employee{Id=2, And_Their_Name="Adikwu Maria"},
                new Employee{Id=3, And_Their_Name="Basil Precious"},
                new Employee{Id=4, And_Their_Name="Onoja Augustine"},
                new Employee{Id=5, And_Their_Name="Christian Samuel"},
                new Employee{Id=6, And_Their_Name="Ochigbo Martha"},
                new Employee{Id=7, And_Their_Name="Ochoga Favour"},
                new Employee{Id=8, And_Their_Name="Adikwu Joseph"},
                new Employee{Id=9, And_Their_Name="Enemali Mary"},
                new Employee{Id=10, And_Their_Name="Adikwu Grace"},
                new Employee{Id=11, And_Their_Name="Agi Esther"},
                new Employee{Id=12, And_Their_Name="Oche Susan"},
                new Employee{Id=13, And_Their_Name="Ugwoke Stephanie"},
                new Employee{Id=14, And_Their_Name="Ikala Comfort"},
                new Employee{Id=15, And_Their_Name="Yakubu Lariatu"},
                new Employee{Id=16, And_Their_Name="Olong John"},
                new Employee{Id=17, And_Their_Name="Olofu Emmanuel"},
                new Employee{Id=18, And_Their_Name="Alechenu Precious"},
                new Employee{Id=19, And_Their_Name="Igwe Henry"},
                new Employee{Id=20, And_Their_Name="Yakubu Sekinat"},
                new Employee{Id=21, And_Their_Name="Enenche Adah"},
                new Employee{Id=22, And_Their_Name="Owoicho Helen"},
                new Employee{Id=23, And_Their_Name="Agbochenu Favour"},
                new Employee{Id=24, And_Their_Name="Matthew Blessing"},
                new Employee{Id=25, And_Their_Name="Sir U.C Wisdom"},
                new Employee{Id=26, And_Their_Name="Ogbole Gift"},
                new Employee{Id=27, And_Their_Name="Ochola Oiwona"},
                new Employee{Id=28, And_Their_Name="Ikpe Victor"},
                new Employee{Id=29, And_Their_Name="Elias Samson"},
                new Employee{Id=30, And_Their_Name="Uzulor Gift"}
            };
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string And_Their_Name { get; set; }
    }
}
