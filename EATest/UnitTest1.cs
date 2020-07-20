using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EATest
{
    [TestClass]
    public class UnitTest1
    {

        string url = "https://www.confirmtkt.com/";
        private IWebDriver _driver;

        [TestMethod]
        public void TestMethod1()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(url);
        }
    }
}
