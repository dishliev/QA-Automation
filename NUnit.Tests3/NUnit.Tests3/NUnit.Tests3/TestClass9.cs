using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests3
{
    [TestFixture]
    public class TestClass9
    {
        [Test]
        public void BankAcountWithPositiveValue1()
        {
            var sum = 1500m;
           
            var account = new BankAcount(sum);
           
            var withdraw = 1100m;
            account.Withdraw(withdraw);
           
            var expected = sum - withdraw - withdraw * 0.05m;
         
            Assert.AreEqual(expected, account.Amount);
      
        }
    }
}
