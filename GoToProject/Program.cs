
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Medi.GoToProject
{
    public class Program
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.goto.com/meeting";//  wait for the page load to complete
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            
            driver.FindElement(By.Id("truste-consent-button")).Click();

            Actions actions = new Actions(driver);
            try
            {
                actions.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
            }

            catch { }

            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("Try Free")).Click();


            driver.FindElement(By.Id("first-name")).SendKeys("John");
            driver.FindElement(By.Id("last-name")).SendKeys("wick");

            driver.FindElement(By.Id("login__email")).SendKeys("john@gmail.com");

            SelectElement selectcompys = new SelectElement(driver.FindElement(By.Id("CompanySize")));
            selectcompys.SelectByText("10-99");

            driver.FindElement(By.XPath("//*[contains(text(),'Start My Trial')]"));
           // driver.FindElement(By.XPath("Start My Trial


           string actual_err = driver.FindElement(By.XPath("//div(@class='inputField__requirements")).Text;
            Console.WriteLine(actual_err); 
           


           


        }
    }
}

