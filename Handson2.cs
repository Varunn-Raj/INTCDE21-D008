using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc1;
using NUnit.Framework;

namespace UnitTestProject1
{
   
    [TestFixture]
    class Handson2
    {
        Program p;
        [SetUp]
        public void SetUp()
        {
            p = new Program();
        }
        [TearDown]
        public void TearDown()
        {
            p = null;
        }
        [TestCase]
        public void SubstractionTestcase1()
        {
            double x = p.Subtraction(40, 20);
            double y = 20;
            Assert.That(x, Is.EqualTo(y));
        }
        [TestCase]
        public void SubstractionTestcase2()
        {
            double x = p.Subtraction(20, 60);
            double y = -40;
            Assert.That(x, Is.EqualTo(y));
        }
        [TestCase]
        public void MultiplicationTestCase1()
        {
            double x = p.Multiplication(2, 3);
            double y = 6;
            Assert.That(x, Is.EqualTo(y));
        }
        [TestCase]
        public void MultiplicationTestCase2()
        {
            double x = p.Multiplication(0, 7);
            double y = 0;
            Assert.That(x, Is.EqualTo(y));
        }
        [TestCase]
        public void DivisionTestcase1()
        {
            double x = p.Division(24, 6);
            double y = 4;
            Assert.That(x, Is.EqualTo(y));
        }
        [TestCase]
        public void DivisionTestcase2()
        {
            var e = Assert.Throws<ArgumentException>(() => p.Division(8, 0));
            Assert.AreEqual("Second Parameter Can't be Zero", e.Message);

        }
    }
}
