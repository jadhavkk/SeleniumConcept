
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ParaBankProject { 
    public class Program
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
           driver.Url = "https://parabank.parasoft.com/parabank/register.htm";
            driver.FindElement(By.Id("customer.firstName")).SendKeys("Sakshi");
            driver.FindElement(By.Id("customer.lastName")).SendKeys("Joshi");
            driver.FindElement(By.Id("customer.address.street")).SendKeys("Pune");
            driver.FindElement(By.Id("customer.address.city")).SendKeys("Pune");
            driver.FindElement(By.Id("customer.address.state")).SendKeys("Maharashtra");
            driver.FindElement(By.Id("customer.address.zipCode")).SendKeys("444000");
            driver.FindElement(By.Id("customer.phoneNumber")).SendKeys("9988776655");
            driver.FindElement(By.Id("customer.ssn")).SendKeys("3344");
            driver.FindElement(By.Id("customer.username")).SendKeys("Sakshi@gmail.com");
            driver.FindElement(By.Id("customer.password")).SendKeys("sakshi@00");
            driver.FindElement(By.Id("repeatedPassword")).SendKeys("sakshi@00");
            driver.FindElement(By.ClassName("button")).Click();

            //
        }
    }
}
