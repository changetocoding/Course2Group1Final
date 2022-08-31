using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistration.Data.Scaffolded;
using UserRegistrationApp;
using System.Text.RegularExpressions;

namespace UserRegistrationApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            People people= new People();
            UserRegistrationContext context = new UserRegistrationContext();
          while(true)  
          {
                Console.WriteLine("[1]  REGISTER A USER,  [2]  VIEW USER DETAILS,   [3]  UPDATE USER INFORMATION,  [4]  DELETE A USER");
                var option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("ENTER THE NAME OF THE USER");
                    var name = Console.ReadLine();
                    Console.WriteLine("ENTER THE EMAIL ADDRESS OF THE USER");
                    var email = Console.ReadLine();
                        try
                        {
                            people.AddAUser(name, email);
                            Console.WriteLine("THE USER HAS BEEN ADDED SUCCESSFULLY");
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err.Message);
                        }  
                }
                else if (option == "2")
                {
                    Console.WriteLine("[1] VIEW SPECTIFIC USER DETAILS.. [2]  VIEW ALL DETAILS ");
                    var details = Console.ReadLine();
                    if( details == "1")
                    {
                        
                        Console.WriteLine("ENTER EMAIL OF REGISTERED USER");
                        var email = Console.ReadLine();
                        var all = people.ViewSpecificUserDetail(email);
                        foreach (var item in all)
                        {
                            Console.WriteLine($" Name:  {item.Name},  Email:  {item.Email}");
                        }
                    }
                    else if (details == "2")
                    {
                       var all = people.ViewAllUsersDetails();
                        foreach(var item in all)
                        {
                            Console.WriteLine($" Name:  {item.Name},  Email:  {item.Email}");
                        }
                        
                    }
                    
                }
                else if (option == "3")
                {

                    Console.WriteLine("ENTER THE EMAIL OF THE USER TO BE UPDATED");
                    var email = Console.ReadLine();
                    Console.WriteLine("ENTER THE NEW NAME");
                    var newName = Console.ReadLine();
                    Console.WriteLine("ENTER THE NEW EMAIL");
                    var newEmail = Console.ReadLine();
                    people.UpdateUserDetails(email, newName, newEmail);
                    Console.WriteLine("THE USER HAS BEEN SUCCESSFULLY UPDATED");
                    
                    
                }
                else if (option == "4")
                {

                    Console.WriteLine("ENTER EMAIL OF USER TO DELETE");
                    var name = Console.ReadLine();
                    try
                    {
                        people.DeleteUserDetails(name);
                        Console.WriteLine("USER SUCCESSFULLY DELETED");

                    }
                    catch(Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                }
          }
        }
    }
}

