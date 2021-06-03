using HomeTask_Lecture6.Framework;
using HomeTask_Lecture6.Users;
using HomeTask_Lecture6.Pages;
using NUnit.Framework;
using BasicFramework.Tests;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium;

namespace HomeTask_Lecture6.Tests
{

[TestFixture]
public class LoginTest : BaseTest
{
    private User _users;
    private const string Title = "Testing Challenge #10 - ";

[SetUp]
        public void Initialize()
        {
            _users = User.UserData();
        }
        #region
        [Test]
        public void UsersRegistration()
        {
            HomePage home = SiteNavigator.NavigateToLoginPage(Driver).Login(_users);
            WebDriverWait wait = new(Driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//h1[text()='Testing Challenge #10 - ']")));
            Assert.AreEqual(Title, wait);
        }
        #endregion
    }
}