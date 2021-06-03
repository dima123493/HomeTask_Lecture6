using OpenQA.Selenium;
using HomeTask_Lecture6.Users;
namespace HomeTask_Lecture6.Pages
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement UsernameBox => Driver.FindElement(By.ClassName("username"));

        private IWebElement PasswordBox => Driver.FindElement(By.ClassName("password"));

        private IWebElement FirstnameBox => Driver.FindElement(By.ClassName("firstname"));

        private IWebElement LastnameBox => Driver.FindElement(By.ClassName("lastname"));

        public HomePage Login(User user)
        {
            UsernameBox.Click();
            UsernameBox.SendKeys(user.Username);
            PasswordBox.Click();
            PasswordBox.SendKeys(user.Password);
            FirstnameBox.Click();
            FirstnameBox.SendKeys(user.FirstName);
            LastnameBox.Click();
            LastnameBox.SendKeys(user.LastName);

            return new HomePage(Driver);
        }
    }
}