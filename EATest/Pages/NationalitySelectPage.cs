using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace EATest.Pages
{

    class NationalitySelectPage : BasePage
    {
      
        [FindsBy(How = How.LinkText, Using = "Next step")]
        public IWebElement lnkNextStep { get; set; }
    }
}
