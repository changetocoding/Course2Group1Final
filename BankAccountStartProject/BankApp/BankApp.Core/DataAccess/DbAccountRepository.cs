using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankApp;
using System.Threading.Tasks;
using BankApp.Core.Domain;
using System.Text.RegularExpressions;
    
using BankApp.Data.Scaffolded;

namespace BankApp.Core.DataAccess
{
    public class DbAccountRepository : IAccountRepository
    {
        
        
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
        public int CreateAccount(string emailAddress)
        {   
            using (var dbcontext = new BankContext())
            {
                if (ValidatingEmailAddress(emailAddress) is true)
                {
                    var check = dbcontext.AccountDbs.Where(x => x.Email == emailAddress).FirstOrDefault();
                    if (!dbcontext.AccountDbs.Contains(check))
                    {
                        var account = new AccountDb() { Email = emailAddress };
                        dbcontext.AccountDbs.Add(account);
                        dbcontext.SaveChanges();
                        return account.Id;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
               
        }

        public Account GetAccountById(int accountId)
        {
            using (var dbcontext = new BankContext())
            {
                var check = dbcontext.AccountDbs.Where(x => x.Id == accountId).SingleOrDefault();
                var account = new Account() { Id = check.Id };
                return account;   
            }
        }

        public IEnumerable<Account> GetAll()
        {
            using (var dbcontext = new BankContext())
            {
                return (IEnumerable<Account>) dbcontext.AccountDbs.ToList();
            }
        }

        public void Update(Account account)
        {
            using (var dbcontext = new BankContext())
            {
                var dbObject = dbcontext.AccountDbs.SingleOrDefault(x => x.Id == account.Id);
                if(dbObject is null)
                {
                    throw new Exception("Id not found");
                }

                dbObject.Balance = account.Balance;
                dbObject.PaidIn = account.PaidIn;
                dbObject.Withdrawn = account.Withdrawn;

                dbcontext.SaveChanges();

            }
        }
    }
}
