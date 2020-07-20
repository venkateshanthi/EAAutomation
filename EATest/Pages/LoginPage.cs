using EAAutoFramework.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EATest.Pages
{
    class LoginPage : BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Start now")]
        public IWebElement lnkStart { get; set; }
    }
}
