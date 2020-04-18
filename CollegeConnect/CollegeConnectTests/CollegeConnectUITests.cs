using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Compatibility;


namespace CollegeConnectTests
{
    [TestFixture]
    public class UITests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://collegeconnect20200330060626.azurewebsites.net";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheLoadTest()
        {
            driver.Navigate().GoToUrl("https://collegeconnect20200330060626.azurewebsites.net");
            driver.FindElement(By.XPath("//body")).Click();
            driver.FindElement(By.XPath("//html")).Click();
            driver.FindElement(By.XPath("//h1")).Click();
            Assert.AreEqual("CollegeConnect - CollegeConnect", driver.Title);
        }

        [Test]
        public void TheAuthTest() //Checks if unregistered user cannot post a ride
        {
            driver.Navigate().GoToUrl("https://collegeconnect20200330060626.azurewebsites.net");
            driver.FindElement(By.LinkText("Post Ride")).Click();
            driver.FindElement(By.XPath("//h1")).Click();
            Assert.AreEqual("Log in", driver.FindElement(By.XPath("//h1")).Text);
        }

        [Test]
        public void TheAuthfindTest() //Checks if unregistered user cannot find a ride
        {
            driver.Navigate().GoToUrl("https://collegeconnect20200330060626.azurewebsites.net");
            driver.FindElement(By.LinkText("Find Ride")).Click();
            driver.FindElement(By.XPath("//h1")).Click();
            Assert.AreEqual("Log in", driver.FindElement(By.XPath("//h1")).Text);
        }

        [Test]
        public void TheSearchauthTest() //Checks if authorized user can search ride
        {
            driver.Navigate().GoToUrl("https://collegeconnect20200330060626.azurewebsites.net");
            driver.FindElement(By.LinkText("Find Ride")).Click();
            driver.FindElement(By.Id("Input_Email")).Click();
            driver.FindElement(By.Id("Input_Email")).Clear();
            driver.FindElement(By.Id("Input_Email")).SendKeys("aadhi231@conestogac.on.ca");
            driver.FindElement(By.Id("Input_Password")).Click();
            driver.FindElement(By.Id("Input_Password")).Clear();
            driver.FindElement(By.Id("Input_Password")).SendKeys("Ishu@123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.XPath("//h1")).Click();
            driver.FindElement(By.XPath("//h1")).Click();
            driver.FindElement(By.XPath("//h1")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [doubleClick | //h1 | ]]
            Assert.AreEqual("Search", driver.FindElement(By.XPath("//h1")).Text);
            driver.FindElement(By.Id("logout")).Click();
        }

        [Test]
        public void TheAllRideTest() // Checks if all posted rides are listed
        {
            driver.Navigate().GoToUrl("https://collegeconnect20200330060626.azurewebsites.net");
            driver.FindElement(By.LinkText("Find Ride")).Click();
            driver.FindElement(By.Id("Input_Email")).Click();
            driver.FindElement(By.Id("Input_Email")).Clear();
            driver.FindElement(By.Id("Input_Email")).SendKeys("aadhi231@conestogac.on.ca");
            driver.FindElement(By.Id("Input_Password")).Click();
            driver.FindElement(By.Id("Input_Password")).Clear();
            driver.FindElement(By.Id("Input_Password")).SendKeys("Ishu@123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.LinkText("See all Rides Posted")).Click();
            Assert.AreEqual("All Rides - CollegeConnect", driver.Title);
            driver.FindElement(By.Id("logout")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
