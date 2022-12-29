
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Maveric.SalesForceProject
{
    public class Program
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            
            driver.FindElement(By.Name("UserFirstName")).SendKeys("Jack");
            driver.FindElement(By.Name("UserLastName")).SendKeys("Martina");
            driver.FindElement(By.XPath("//input[contains(@id,'UserEma')]")).SendKeys("jack22@gmail.com");


            SelectElement selectTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectTitle.SelectByText("IT Manager");
            driver.FindElement(By.Name("CompanyName")).SendKeys("Maveric System");

            SelectElement selectemployees = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectemployees.SelectByText("101-500 employees");
            driver.FindElement(By.Name("CompanyEmployees")).Click();

              
           // driver.FindElement(By.XPath("span[contains(@id='User Phone)]")).Click();
               
                 SelectElement selectcountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectcountry.SelectByText("INDIA");


            driver.FindElement(By.ClassName("checkbox - ui")).Click();
            //driver.FindElement(By.XPath("(//div[@class='checkbox-ui'])[1]")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();
             
            //

            //
        }
    }
}
