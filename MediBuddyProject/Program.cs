
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MediBuddyProject
{
    public class Program
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.medibuddy.in/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
           
            driver.FindElement(By.XPath("//a[@ng-click='userSignin()']")).Click();
            driver.FindElement(By.XPath("//div[text()='I have an Insurance/Corporate Account']")).Click();
            driver.FindElement(By.XPath("//div[text()='Login using Username & Password']")).Click();
            driver.FindElement(By.XPath("//input[@name='userName']")).SendKeys("john");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("john123");
            driver.FindElement(By.XPath("//input[@type='checkbox']")).Click();
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

           string actual_Text = driver.FindElement(By.XPath("//*[contains(text(),'incorrect')]")).Text;
           Console.WriteLine(actual_Text);


            //



        }
    }

}
