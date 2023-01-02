using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.Extensions;

namespace Maveric.SeleniumAdvance
{
    public class RedBus
    {
        [Test]
        public void BusTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.redbus.in/";
             driver.FindElement(By.Id("sign-in-icon-down")).Click();
            driver.FindElement(By.Id("signInLink")).Click();
            

            
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@class='modalIframe']")));
            driver.FindElement(By.Id("mobileNoInp")).SendKeys("7898");
           string errorMessage= driver.FindElement(By.XPath("//span[@class='error-message-fixed error-message-full top-fix']")).Text;
            Console.WriteLine(errorMessage);



        }

    }
    
}


