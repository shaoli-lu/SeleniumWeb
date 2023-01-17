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
    public class SeleniumTest
    {
        [TestMethod]
        public void TestStreetFighterVThenVerifyStreetFighterVIsDisplayed()
        {
            By googleSearchBar = By.Name("q");
            By googleSearchButton = By.Name("btnK");
            By googleResultText = By.XPath(".//h2//span[text()='Street Fighter V']");

            //IWebDriver webDriver = new EdgeDriver();
            ChromeDriverManager.InstallLatest();
            //IWebDriver webDriver = new ChromeDriver();
            //IWebDriver webDriver = new FirefoxDriver();
            webDriver.Manage().Window.Maximize();

            webDriver.Navigate().GoToUrl("https://www.google.com/"); 
            webDriver.FindElement(googleSearchBar).SendKeys("Street Fighter V");
            //webDriver.FindElement(googleSearchButton).Click();
            //webDriver.Navigate().Forward();

            var actualResultText = webDriver.FindElement(googleResultText);
            Assert.IsTrue(actualResultText.Text.Equals("Street Fighter V"));

            webDriver.Quit();


        }
    }
}