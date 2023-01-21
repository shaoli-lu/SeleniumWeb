using DevNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager;

namespace SeleniumWeb
{
    [TestClass]
    public class ParkerTimerTest
    {
        [TestMethod]
        public void LoginWaitFor15minParkerTimerKicksIn()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://bol.rwbaird.com/Login");
            IWebElement usernameField = driver.FindElement(By.Id("Username"));
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            IWebElement loginButton = driver.FindElement(By.Id("loginButton"));
            usernameField.SendKeys("yodleeeehehehe");
            passwordField.SendKeys("hahahahaha#1");
            loginButton.Click();
            Assert.AreEqual("https://bairdonline.rwbaird.com/Web/user/dashboard/ucd/1", driver.Url);


        }
    }
}
