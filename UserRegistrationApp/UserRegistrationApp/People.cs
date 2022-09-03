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
    public class People
    {
        UserRegistrationContext context = new UserRegistrationContext();

        //Checking for a valid email.(@gmail.com)
        public bool ValidatingEmailAddress(string email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(email))
                return (true);
            else
                return (false);
        }
        // Adding user to the database.
        public bool AddAUser(string name, string email)
        {
              using (var context = new UserRegistrationContext())
              {
                    if (ValidatingEmailAddress(email) is true)
                    {
                        var check = context.Users.Where(x => x.Email == email).FirstOrDefault();
                        if (context.Users.Contains(check))
                        {
                            throw new Exception();
                        }
                        else
                        {
                            var user = new User() { Name = name, Email = email };
                            context.Users.Add(user);
                            context.SaveChanges();
                            return true;
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
              }
        }

        // Viewing Specfic details of a user.
        public IEnumerable<User> ViewSpecificUserDetail( string email)
        {
            yield return context.Users.Where(x => x.Email ==email).FirstOrDefault();
           
        }

        public IEnumerable<User> ViewAllUsersDetails()
        {
             return context.Users.Select(x => x).ToList();
        }

        // Updating the detail of the user (email, name)from the database.
        public bool UpdateUserDetails(string email, string newName, string newEmail)
        {
            var users = context.Users
                .Where(x => x.Email == email)
                .FirstOrDefault();
            if (users is User)
            {
                users.Name = newName;
                users.Email = newEmail;
            }
            context.SaveChanges();
            return true;
        }

        //Deleting the users details from the database
        public bool DeleteUserDetails(string email)
        {
           var delete = context.Users.Where(x => x.Email == email).First();
           
           context.Remove(delete);
           context.SaveChanges();
           return true;         
        }
        // Checking if the email of the user exists.
        public bool IfUserEmailExist(string email)
        {
            var ifEmailExist = context.Users.Where(x => x.Email == email).FirstOrDefault();
            context.SaveChanges();
            return true;
        }

        // Checking if the email of the user DO NOT exist.
        public bool IfUserEmailDoesNotExist(string email)
        {
            var delete = context.Users.Where(x => x.Email == email).FirstOrDefault();

            if(delete is null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checking if users are added.
        public bool CheckIfUsersAreAdded(string email)
        {
            var ifUsersAreAdded = context.Users.Where(x => x.Email == email).FirstOrDefault();

            if (context.Users.Contains(ifUsersAreAdded))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checking if users are delected.
        public bool CheckIfUsersAreDeleted(string email)
        {
            var ifUsersAreDeleted = context.Users.Where(x => x.Email == email).FirstOrDefault();

            if (context.Users.Contains(ifUsersAreDeleted))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checking if users are updated.
        public bool CheckIfUsersAreUpdated(string email)
        {
            var ifUsersAreUpdated = context.Users.Where(x => x.Email == email).FirstOrDefault();

            if (context.Users.Contains(ifUsersAreUpdated))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }   
}
