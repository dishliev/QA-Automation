using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests3
{
    [TestFixture]
    public class TestClass11
    {
        [Test]
        public void BankAcountTest1()
        {

            BankAcount acc = new BankAcount(1000m);
            Assert.Less(acc.Amount, 2500);


        }
        [Test]
        public void BankAcountTest2()
        {

            BankAcount acc = new BankAcount(5500);
            Assert.AreNotSame(5500, 400);


        }
        [Test]
        public void BankAcountTest3()
        {

            BankAcount acc = new BankAcount(100);
            Assert.AreSame(100, 400);


        }
        [Test]
        public void BankAcountTest4()
        {
            BankAcount acc = new BankAcount(656m);
            Assert.IsNotNull(acc, "This is not null");


        }
        [Test]
        public void BankAcountTest5()
        {
            BankAcount acc = new BankAcount(2000m);
            Assert.AreNotEqual(423, acc);

        }
    }
}
