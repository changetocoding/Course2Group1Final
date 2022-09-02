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
        private readonly BankContext dbcontext;

        public DbAccountRepository()
        {
            dbcontext = new BankContext();
        }
        
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
                if (ValidatingEmailAddress(emailAddress) is true)
                {
                    var check = dbcontext.AccountDbs.Where(x => x.Email == emailAddress).FirstOrDefault();
                    if (dbcontext.AccountDbs.Contains(check))
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

        public Account GetAccountById(int accountId)
        {
            var check = dbcontext.AccountDbs.Where(x => x.Id == accountId).FirstOrDefault();
            var account = new Account() { Id = check.Id};
            return account;               
        }

        public IEnumerable<Account> GetAll()
        {
            return (IEnumerable<Account>)dbcontext.AccountDbs.ToList();
            
        }

        public void Update(Account account)
        {             
            var check = dbcontext.AccountDbs.Where(x => x.Id == account.Id).FirstOrDefault();
            
            if (check.Id == account.Id)
            {
                check.Balance += account.Balance;
                dbcontext.SaveChanges();

                check.PaidIn += account.PaidIn;
                dbcontext.SaveChanges();


                account.Balance -= check.Balance;
                check.Withdrawn = account.Withdrawn;
                dbcontext.SaveChanges();
            }
            
            
        }
    }
}
