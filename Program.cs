using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SetupEnvironment
{
    internal class Program
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            IWebElement element = driver.FindElement(By.Id("user-name"));

            if (element.Displayed)
            {
                GreenMessage("Yes, I can see the element!!");
            }
            else
            {
                RedMessage("No");
            }

            Thread.Sleep(3000);

            driver.Quit();

        }

        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
