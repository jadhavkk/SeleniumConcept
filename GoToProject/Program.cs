
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            driver.FindElement(By.XPath("//a[contains(text(),'Try Free')]")).Click();  //new 
               
        
        }
    }
}

