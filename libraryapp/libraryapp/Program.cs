// See https://aka.ms/new-console-template for more information

using System;

   namespace libraryapp
{
    internal class program
    {
        static void Main(string[] michael)
        {
            Console.WriteLine("                                       WELCOME TO OUR LIBRARY");
            int decision;
            Console.WriteLine("                       ENTER [1] TO BORROW A BOOK AND [2] TO RETURN A BORROWED BOOK");

            try
            {
                decision = Convert.ToInt32(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                        Borrowbook();
                        break;
                    case 2:
                        Returnbook();
                        break;
                    default:
                        Console.WriteLine("                                       Kindly choose from the given option");
                        break;
                }

            }
            catch (Exception) 
            {
                Console.WriteLine("                                       Wrong input, please enter a valid number");
            }
            finally
            {
                Console.WriteLine("                                       We are grateful that you patronized our library ");
            }
        }

        private static void Returnbook()
        {
            Console.WriteLine("                                   We offer a wide variety of books and they include");

            Dictionary<int, string> books = new Dictionary<int, string>();
            books.Add(1, "UNDERSTANDING THE WAYS OF THE COSMOS");
            books.Add(2,"THE THEORY OF RELATIVITY");
            books.Add(3,"WHO KNOWS TOMORROW");
            books.Add(4, "THE POWER OF THE WILL");
            books.Add(5, "LET YOUR MIND BE A DIMENSION OF CREATIVITY");
            books.Add(6, "WHY GREAT MEN BECAME GREAT");
            books.Add(7, "OBEDIENCE TO THE PRECEPTS OF TIME");
            books.Add(8, "SAY NO TO LAZINESS AND PROCASTINATION");
            books.Add(9, "WHEN GOD SPEAKS");
            books.Add(10, "THE ORIGIN OF WAR");

            while (true)
            {
                foreach(var book in books)
                {
                    Console.WriteLine(book);
                }
            }


        }

        private static void Borrowbook()
        {
            
        }
    }
}


