using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using Calc1;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject1
{
  
    [TestFixture]
    public class UnitTest1
    {
        Program program;
        [SetUp]
        public void SetUp()
        {
            program = new Program();
        }
        [TearDown]
        public void TearDown()
        {
            program = null;
        }

        [TestCase]
        public void add()
        {
            double x = program.Addition(10, 12);
            double y = 22;
            Assert.That(x, Is.EqualTo(y));
        }
    }
}

