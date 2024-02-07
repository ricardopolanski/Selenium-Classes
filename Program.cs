using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SetupEnvironment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            

            driver.Navigate().GoToUrl("http://testing.todorvachev.com/selectors/name/");

            IWebDriver element = (IWebDriver)driver.FindElement(By.Name(""));

            Thread.Sleep(5000);

            driver.Quit();

        }
    }
}
