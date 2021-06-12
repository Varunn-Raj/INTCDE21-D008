using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Handson4;
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
        public void Dispose()
        {
            program = null;
        }

        [TestCase]
        public void LoginTestcase1()
        {
            string exp = "Invalid user id/password";
            string act = program.ValidateUser("user_22", "secret@user12s");
            Assert.That(act, Is.EqualTo(exp));
        }
        [TestCase]
        public void LoginTestcase2()
        {
            string act = program.ValidateUser("user_113", "secret@user11");
            string exp = string.Format("Invalid user id/password");
            Assert.That(act, Is.EqualTo(exp));

        }
        [TestCase]
        public void LoginTestcase3()
        {

            string act = program.ValidateUser("user_22", "secret@user22");
            string exp = string.Format("Welcome user_22!!!");
            Assert.That(act, Is.EqualTo(exp));

        }
        [TestCase]
        public void LoginTestcase4()
        {
            string exp = "Invalid user id/password";
            string act = program.ValidateUser("user_23", "secret@user12s");
            Assert.That(act, Is.EqualTo(exp));
        }


    }
}
