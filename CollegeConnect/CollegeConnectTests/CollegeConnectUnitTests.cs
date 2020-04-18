using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using DataModels.Models;

namespace CollegeConnectTests
{
    [TestFixture]
    class CollegeConnectUnitTests
    {
        [Test]
        public void InputOttawa_CheckInputNotSplChar_ExpectedTrue() // input given without any special character
        {
            
            Student student = new Student();
            student.Start = "Ottawa";
                bool result = student.CheckNotEmpty();
            Assert.AreEqual(result, true);
        }
        [Test]
        public void InputOttawaexclamation_CheckInputNotSplChar_ExpectedFalse()//  input given with special character !
        {

            Student student = new Student();
            student.Start = "Ottawa!";
            bool result = student.CheckNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputOttawaat_CheckInputNotSplChar_ExpectedFalse() //  input given with special character @
        {

            Student student = new Student();
            student.Start = "Ottawa@";
            bool result = student.CheckNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputOttawahash_CheckInputNotSplChar_ExpectedFalse() //  input given with special character #
        {

            Student student = new Student();
            student.Start = "Otta#wa";
            bool result = student.CheckNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputOttawastar_CheckInputNotSplChar_ExpectedFalse() //  input given with special character *
        {

            Student student = new Student();
            student.Start = "*Ottawa";
            bool result = student.CheckNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputSouth_CheckDestNotSplChar_ExpectedTrue() //  input given without special character 
        {

            Student student = new Student();
            student.Dest = "South";
            bool result = student.CheckDestNotEmpty();
            Assert.AreEqual(result, true);
        }
        [Test]
        public void InputSouthexc_CheckDestNotSplChar_ExpectedFalse() //  input given with special character !
        {

            Student student = new Student();
            student.Dest = "Sou!th";
            bool result = student.CheckDestNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputSouthat_CheckDestNotSplChar_ExpectedFalse() //  input given with special character @
        {

            Student student = new Student();
            student.Dest = "S@outh";
            bool result = student.CheckDestNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputSouthhash_CheckDestNotSplChar_ExpectedFalse() //  input given with special character #
        {

            Student student = new Student();
            student.Dest = "Sout#h";
            bool result = student.CheckDestNotEmpty();
            Assert.AreEqual(result, false);
        }
        [Test]
        public void InputSouthstar_CheckDestNotSplChar_ExpectedFalse() //  input given with special character *
        {

            Student student = new Student();
            student.Dest = "Sout*h";
            bool result = student.CheckDestNotEmpty();
            Assert.AreEqual(result, false);
        }

    }
}
