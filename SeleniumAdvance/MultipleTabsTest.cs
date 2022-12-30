using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.SeleniumAdvance
{
    public class MultipleTabsTest
    {
        [Test]
        public void PhpMyAdminTabTest()
        {
            IWebDriver driver = new ChromeDriver();
          
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.db4free.net/";
            driver.FindElement(By.LinkText("phpMyAdmin »")).Click();


            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.Id("input_username")).SendKeys("john");
            driver.FindElement(By.Id("input_password")).SendKeys("John@123");
            driver.FindElement(By.Id("input_go")).Click();
             driver.Close();


            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);





        }
    }
}
