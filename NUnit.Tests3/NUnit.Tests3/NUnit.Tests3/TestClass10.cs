using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests3
{
    [TestFixture]
    public class TestClass10
    {
        [Test]
        public void BankAcountWithPositiveValue2()
        {
            var sum = 1500m;

            var account = new BankAcount(sum);

            var withdraw = 500m;
            account.Withdraw(withdraw);

            var expected = sum - withdraw - withdraw * 0.02m;

            Assert.AreEqual(expected, account.Amount);
        }
    }
}
