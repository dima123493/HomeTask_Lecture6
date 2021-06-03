using System;
using System.Configuration;
using HomeTask_Lecture6.Pages;
using OpenQA.Selenium;


namespace HomeTask_Lecture6.Framework
{
    public class SiteNavigator
    {
        public static double FindElement { get; internal set; }

        public static RegistrationPage NavigateToLoginPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["url"]);
            return new RegistrationPage(driver);
        }
    }
 }