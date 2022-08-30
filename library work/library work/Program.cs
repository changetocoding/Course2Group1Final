// See https://aka.ms/new-console-template for more information

using System;
namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                                 WELCOME TO MY LIBRARY");
            Console.WriteLine("ENTER [1] TO BORROW A BOOK AND [2] TO RETURN A BOOK");
            string num1;
            num1 = Console.ReadLine();
            


            Dictionary<int, string> library = new Dictionary<int, string>();
            library.Add(1, "CHANGING LIVES FOR GOOD");
            library.Add(2, "THINKING BIG FOR THE FUTURE");
            library.Add(3, "THE POWER OF THE WILL");
            library.Add(4, "UNDERSTANDING THE PRECEPTS OF SUCCESS");
            library.Add(5, "HOW CAN I SUCCEED");
            library.Add(6, "IN-DEPTH ANALYSIS OF THE THEORY OF RELATIVITY");
            library.Add(7, "THERE IS A GOD");
            library.Add(8, "DO YOU KNOW WHO YOU ARE");
            library.Add(9, "BORN TO MAKE AN IMPACT");
            library.Add(10, "THE WORLD MUST CHANGE");
            foreach(var i in library)
            {
                Console.WriteLine(i);
            }

        }
    }
}
