using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using DataModels.Models;

namespace CollegeConnectTests
{
    [TestFixture]
    class UnitTests
    {
        [Test]
        public void InputOttawa_CheckInputNotEmpty_ExpectedTrue()
        {
            
            Student student = new Student();
            student.Start = "Ottawa";
                bool result = student.CheckNotEmpty();
            Assert.AreEqual(result, true);
        }
        [Test]
        public void InputOttawaexclamation_CheckInputNotEmpty_ExpectedFalse()
        {

            Student student = new Student();
            student.Start = "Ottawa!";
            bool result = student.CheckNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputOttawaat_CheckInputNotEmpty_ExpectedFalse()
        {

            Student student = new Student();
            student.Start = "Ottawa@";
            bool result = student.CheckNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputOttawahash_CheckInputNotEmpty_ExpectedFalse()
        {

            Student student = new Student();
            student.Start = "Otta#wa";
            bool result = student.CheckNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputOttawastar_CheckInputNotEmpty_ExpectedFalse()
        {

            Student student = new Student();
            student.Start = "*Ottawa";
            bool result = student.CheckNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputSouth_CheckDestNotEmpty_ExpectedTrue()
        {

            Student student = new Student();
            student.Dest = "South";
            bool result = student.CheckDestNotEmpty();
            Assert.AreEqual(result, true);
        }
        [Test]
        public void InputSouthexc_CheckDestNotEmpty_ExpectedFalse()
        {

            Student student = new Student();
            student.Dest = "Sou!th";
            bool result = student.CheckDestNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputSouthat_CheckDestNotEmpty_ExpectedFalse()
        {

            Student student = new Student();
            student.Dest = "S@outh";
            bool result = student.CheckDestNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputSouthhash_CheckDestNotEmpty_ExpectedFalse()
        {

            Student student = new Student();
            student.Dest = "Sout#h";
            bool result = student.CheckDestNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputSouthstar_CheckDestNotEmpty_ExpectedFalse()
        {

            Student student = new Student();
            student.Dest = "Sout*h";
            bool result = student.CheckDestNotEmpty();
            Assert.AreEqual(result, false);
        }

    }
}
