using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Handson3;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject2
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
        public void Dispose()
        {
            program = null;
        }

        [TestCase]
        public void Testcase1()
        {
            string x = program.ParseHostName("https://Facebook.com");
            string y = "Facebook.com";
            Assert.That(x, Is.EqualTo(y));
        }
        [TestCase]
        public void Testcase2()
        {

            string x = program.ParseHostName("http://instagram.com");
            string y = "twitter.com";
            Assert.That(x, Is.EqualTo(y));
        }
        [TestCase]
        public void Testcase3()
        {
            var ex = Assert.Throws<FormatException>(() => program.ParseHostName("https12://gmail.com"));
            Assert.That(ex.Message, Is.EqualTo("Url is not in correct format"));
        }
    }
}
