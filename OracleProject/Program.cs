
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OraclProject
{
    public class Program
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = " https://www.oracle.com/in/database/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20); 
            driver.FindElement(By.XPath("//button[@id='u30-flyout']")).Click();
            driver.FindElement(By.XPath("//a[@class='u30darkcta']")).Click();
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);
            Thread.Sleep(1000);
            IWebElement element = driver.FindElement(By.XPath(" //h2[contains(text(),'Oracle account sign in')]"));
           string  elemen = element.Text;
            Console.Write(elemen);
         



         
        }

    }

}
