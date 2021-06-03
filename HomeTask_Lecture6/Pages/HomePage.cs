using OpenQA.Selenium;

namespace HomeTask_Lecture6.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement Table => Driver.FindElement(By.XPath("//th[text()='1']"));

        public string FindTable()
        {
            return Table.Text;
        }
    }
}