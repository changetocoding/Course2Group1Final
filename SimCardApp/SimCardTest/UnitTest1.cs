using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCardApp;
using System;

namespace SimCardTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Recharging_Your_Account()
        {

            var simcard = new SimCardAccount(200);

            simcard.Recharge(200);

            Assert.AreEqual(400, simcard.Airtime);
        }

        [TestMethod]
        public void Buying_Data_Bundles()
        {

            var simcard = new SimCardAccount(500);

            simcard.BuyData(200);

            Assert.AreEqual(300, simcard.Airtime);
        }

        [TestMethod]
        public void Borrow_Airtime()
        {

            var simcard = new SimCardAccount(0);

            simcard.BorrowAirtime(200);

            Assert.AreEqual(200, simcard.Airtime);
        }


        [TestMethod]
        public void Transfer_Airtime_To_Friend()
        {

            var simcard = new SimCardAccount(400);
            var otherSimcard = new SimCardAccount();

            simcard.Withdraw(200);
            otherSimcard.Add(200);

            Assert.AreEqual(200, simcard.Airtime);
            Assert.AreEqual(200, otherSimcard.Airtime);
           
        }


        [TestMethod]
        public void Checking_Account_Balance()
        {

            var simcard = new SimCardAccount(10);

            var check = simcard.CheckBalance();

            Assert.IsTrue(check);
           
        }
    }
}
