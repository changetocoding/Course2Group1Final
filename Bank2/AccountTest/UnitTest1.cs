using Bank2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AccountTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adding_Funds_To_The_Account()
        {
            var account = new Account(1000);

            account.Add(500);

            Assert.AreEqual(1500, account.Balance);
        }

        [TestMethod]
        public void Withdrawing_Funds_From_Account()
        {
            var account = new Account(5000);

            account.Withdraw(1500);

            Assert.AreEqual(3500, account.Balance);
        }

        [TestMethod]
        public void Transferring_Funds_To_Other_Account()
        {
            var account = new Account(7000);
            var otheraccount = new Account();

            account.Withdraw(3500);
            otheraccount.Add(3500);

            Assert.AreEqual(3500, account.Balance);
            Assert.AreEqual(3500, otheraccount.Balance);
        }
        [TestMethod]
        public void Checking_Low_Account_Balance()
        {
            var account = new Account(5000);

           var result= account.CheckLowBalance();

            Assert.IsTrue(result);
        }
    }
}
