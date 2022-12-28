
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Maveric.SalesForceProject
{
    public class Program
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            driver.FindElement(By.Name("UserFirstName")).SendKeys("Jack");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Martina");
            driver.FindElement(By.Name("UserEmail")).SendKeys("jack22@gmail.com");
            driver.FindElement(By.Name("UserTitle")).SendKeys("Sales Manager");
            driver.FindElement(By.Name("CompanyName")).SendKeys("Employees");
            driver.FindElement(By.Name("CompanyEmployees")).SendKeys("1-50 employees");
            driver.FindElement(By.Name("CompanyCountry")).SendKeys("India");
            driver.FindElement(By.Name("CompanyState")).SendKeys("Ladakh");
            driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[1]")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();



            //
        }
    }
}
