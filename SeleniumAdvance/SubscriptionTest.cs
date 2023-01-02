using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Support.UI;

namespace Maveric.SubscriptionTest
{
    public class AddSubscriptionTest
    {
        [Test]
        public void SubTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.automationworld.com/";
            driver.FindElement(By.XPath("//div[@class='close-olytics-image-bottom-midpurple']")).Click();
            driver.FindElement(By.XPath("//span[@class='site-navbar__label']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.Id("id24_344")).Click();
            driver.FindElement(By.Name("demo59703")).SendKeys("Jack");

             driver.FindElement(By.Name("demo59704")).SendKeys("jack123");
            driver.FindElement(By.Name("demo59705")).SendKeys("IT Manager");
            driver.FindElement(By.Name("demo59706")).SendKeys("");
            driver.FindElement(By.Name("demo59707")).SendKeys("fdhdhjd");
                driver.FindElement(By.Name("demo59708")).SendKeys("Maveric");
            driver.FindElement(By.Name("demo59709")).SendKeys("846576");

            SelectElement sel = new SelectElement(driver.FindElement(By.Name("demo59710")));
            sel.SelectByText("ARUBA");
            driver.FindElement(By.Name("demo59713")).SendKeys("Pune");
           
            driver.FindElement(By.Id("submitbtn")).Click() ;

            string textPrint = driver.FindElement(By.XPath("//li[contains(text(),'Email Address is required.')]")).Text;
               
            Console.WriteLine(textPrint); 




        }
    }
}

/*Create Class SubscriptionTest
2.  CModify namespace as Maveric.SubscriptionTest
3. Create AddSubscriptionTest
4.      Navigate onto https://www.automationworld.com/
5.      Close if any popup
6.      Click on Subscribe
7.      Click No for Do you wish
to receive/continue to receive Automation
World magazine free of charge
8.      Fill first name, last name, job title, company url, companyname,
phone and leave email address as blank
9.      Select Country as  India and city as chennai
10.   Check - terms and condition
11.   Click on Submit
12.   Get the error message and print -
Error Displayed: Email
Address is required.*/
