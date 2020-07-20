using EAAutoFramework.Base;
using EATest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EATest
{
    [TestClass]
    public class UnitTest1
    {

        string url = "https://www.gov.uk/check-uk-visa";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);
            DriverContext.Driver.Manage().Window.Maximize();
            Gov();



        }
              
        public void Gov()
        {
            var loginpage = new LoginPage();
            loginpage.lnkStart.Click();
        }

    }
}
