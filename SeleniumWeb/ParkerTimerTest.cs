using DevNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using WebDriverManager;

namespace SeleniumWeb
{
    [TestClass]
    public class ParkerTimerTest
    {
        [TestMethod]
        public void LoginWaitFor15minParkerTimerKicksIn()
        {
            ////
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");

            //ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            //service.Start();

            //IWebDriver driver = new ChromeDriver(service, options);
            //driver.Navigate().GoToUrl("http://www.example.com/login");


            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));



            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://bol.rwbaird.com/Login");
            IWebElement usernameField = driver.FindElement(By.Id("Username"));
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            IWebElement loginButton = driver.FindElement(By.Id("loginButton"));
            usernameField.SendKeys("yodleeeehehehe");
            passwordField.SendKeys("blahblah#1");
            loginButton.Click();
            Assert.AreEqual("https://bairdonline.rwbaird.com/Web/user/dashboard/ucd/1", driver.Url);
            //Wait 15 minutes before logging out
            Console.WriteLine("Waiting 15 minutes...");
            Thread.Sleep(813); //defaul 813s

            //User logout
            driver.FindElement(By.Id("baird-timeout-warning")).Click();

        }
    }
}
