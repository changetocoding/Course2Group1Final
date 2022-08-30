using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace libraryproject
{
    internal class Program
    {
       static void Main(string[] mick)
        {
            Console.WriteLine("                                            WELCOME TO THE GREATEST LIBRARY IN THE WORLD");
            int select;
            Console.WriteLine("                               THE FOLLOWING OPTIONS WILL DETERMINE YOUR ACTIVITIES IN THIS LIBRARY");
            Console.WriteLine("                                 ENTER [1] TO BORROW A BOOK OR ENTER [2] TO RETURN A BORROWED BOOK");

            try
            {
                select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Borrowbook();

                        break;

                    case 2:
                        Returnbook();

                        break;

                    default:
                        Console.WriteLine("                                                KINDLY CHOOSE A VALID OPTION");

                        break;

                }
            }
            catch (Exception)
            {
                Console.WriteLine("                                                WRONG INPUT !!!! PLEASE ENTER A VALID OPTION");
            }
            finally
            {
                Console.WriteLine("                                           THANK YOU FOR PATRONISING OUR LIBRARY, HOPE TO SEE YOU SOON");
            }



            Console.ReadLine();
        }

        public static void Borrowbook()
        {
            List<string> books = new List<string>();
            books.Add("                                                                        LIVING LIKE JESUS");
            books.Add("                                                                       PROCLAIMING LIBERTY");
            books.Add("                                                                           WHO ARE YOU");
            books.Add("                                                                     HAVE YOU GONE TO CALVARY");
            books.Add("                                                         POSSESSING YOUR POSSESSIONS WITH CHRIST JESUS");
            books.Add("                                                                 DO YOU KNOW WHO MY FATHER IS");

            while (true)
            {
                foreach(var book in books)
                {
                    Console.WriteLine(book);
                }
                string op = Console.ReadLine();

                if (books.Contains(op) == true)
                {
                    books.Remove(op);
                    Console.WriteLine($"                                                             YOU HAVE SUCCESSFULLY BORROWED {op}\n\n");
                    
                    Console.WriteLine("                                                              THE REMAINING BOOKS ARE\n\n");
                }
                else if (books.Count == 0)
                {
                    Console.WriteLine("                                                    ALL THE BOOKS IN THE LIBRARY HAVE BEEN BORROWED");
                }
                else
                {
                    Console.WriteLine("                                          PLEASE ENTER THE CORRECT NAME OF THE BOOK YOU WANT TO BORROW");
                }
            }

             Console.ReadLine();
        }

        public static void Returnbook()
        {
            string day = Console.ReadLine();
            if (int.Parse(day) <= 30)
            {

                Console.WriteLine($"                                            CONGRATULATION, YOU HAVE NO FEE TO PAY ");
            }
            else if(int.Parse(day)>10 && int.Parse(day) <= 30)
            {
                int borrow = int.Parse(day) - 10;
                Console.WriteLine($"                                      YOUR OUTSTANDING FEE IS {borrow * 50}. PLEASE RETURN THE BOOK EARLIER TO AVOID PAYMENT OF FEE");
            }
            else if (int.Parse(day) > 30)
            {
                int borrow = int.Parse(day) - 10;
                Console.WriteLine($"                                     YOUR OUTSTANDING FEE IS {borrow * 100}. PLEASE RETURN THE BOOK EARLIER TO AVOID PAYMENT OF FEE");
            }

            Console.ReadLine();
        }

    }
}