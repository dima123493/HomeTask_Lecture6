﻿using OpenQA.Selenium;

namespace HomeTask_Lecture6.Pages
{
    public class BasePage
    {
        public IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }
    }
}
