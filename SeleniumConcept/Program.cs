
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = " https://github.com/login";   //set  //navigate to the url
          
            /*string title = driver.Title;
            Console.WriteLine(driver.Title);  //get the current title

            Console.WriteLine(driver.Url);//get current url

            string pagesource = driver.PageSource;
            Console.WriteLine(driver.PageSource); // get the  page source */

            By usernameLocator = By.Id("login_field");
            IWebElement element = driver.FindElement(usernameLocator);
            //element.Click();
            // element.SendKeys("AMERICA");

            driver.FindElement(By.Id("login_field")).SendKeys("Sakshi");
            driver.FindElement(By.Id("password")).SendKeys("sakshi@00");
            driver.FindElement(By.ClassName("commit")).Click(); 


        }
    }
}

