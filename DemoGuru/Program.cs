using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DemoGuruProject
{
    public class Program
    {//
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/test/newtours/register.php";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
          
             driver.FindElement(By.Name("firstName")).SendKeys("Viraj");
            driver.FindElement(By.Name("lastName")).SendKeys("Gutte");
            driver.FindElement(By.Name("phone")).SendKeys("8877665544");
            driver.FindElement(By.Id("userName")).SendKeys("viraj");
            driver.FindElement(By.Name("address1")).SendKeys("Pune");
            driver.FindElement(By.Name("city")).SendKeys("Beed");
             driver.FindElement(By.Name("state")).SendKeys("Maharashtra");
            driver.FindElement(By.Name("postalCode")).SendKeys("776688");

            SelectElement selectcountry = new SelectElement(driver.FindElement(By.Name("country")));
            selectcountry.SelectByText("INDIA");
            driver.FindElement(By.Id("email")).SendKeys("viraj@11");
            driver.FindElement(By.Name("password")).SendKeys("vgutte#44");
            driver.FindElement(By.Name("confirmPassword")).SendKeys("vgutte#44");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
//
        }
    }

}
