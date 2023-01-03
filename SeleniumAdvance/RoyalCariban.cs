using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace Maveric.SeleniumAdvance
{
    public class royalcaribbean
    {
        [Test]
        public void Royal()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.royalcaribbean.com/account/create";
           // driver.FindElement(By.XPath("//span[text()='Sign In']")).Click();
           // driver.FindElement(By.PartialLinkText("Create an account")).Click();
            driver.FindElement(By.XPath("//input[@data-placeholder='First name/Given name']")).SendKeys("Dennis");
            driver.FindElement(By.XPath("//input[@data-placeholder='Last name/Surname']")).SendKeys("Rich");
            driver.FindElement(By.XPath("//span[text()='Month']")).Click();
            driver.FindElement(By.XPath("//span[normalize-space()='April']")).Click();
            driver.FindElement(By.XPath("//span[text()='Day']")).Click();

           driver.FindElement(By.XPath("//span[normalize-space()='4']")).Click();

            //driver.FindElement(By.XPath("//span[text()='']")).Click();
            driver.FindElement(By.XPath("//input[@id='mat-input-3']")).SendKeys("1997");

            driver.FindElement(By.XPath("//span[text()='Country/Region of residence']")).Click();
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//span[normalize-space()='India']"))).Perform();
            driver.FindElement(By.XPath("//span[normalize-space()='India']")).Click();


           driver.FindElement(By.XPath("//input[@data-placeholder='Email address']")).Click();
            actions.MoveToElement(driver.FindElement(By.XPath("//input[@data-placeholder='Email address']"))).SendKeys("vaishu33@gmail.com").Perform();


           //driver.FindElement(By.XPath("//input[@data-placeholder='Email address']")).SendKeys("arti@45");
            
                driver.FindElement(By.XPath("//input[@data-placeholder='Create new password']")).SendKeys("Arti@45545");

            driver.FindElement(By.XPath("//span[text()='Select one security question']")).Click();
            actions.MoveToElement(driver.FindElement(By.XPath("//span[text()=' What was the name of your first pet? ']"))).Perform();
            driver.FindElement(By.XPath("//span[text()=' What was the name of your first pet? ']")).Click();

            driver.FindElement(By.XPath("//input[@data-placeholder='Answer']")).Click();
            actions.MoveToElement(driver.FindElement(By.XPath("//input[@data-placeholder='Answer']"))).SendKeys("Have a Good Day").Perform();

            driver.FindElement(By.XPath("//span[@class='mat-checkbox-inner-container mat-checkbox-inner-container-no-side-margin']")).Click();

            driver.FindElement(By.XPath("(//span[@class='mat-checkbox-inner-container mat-checkbox-inner-container-no-side-margin'])[2]")).Click();

            driver.FindElement(By.XPath("//button[text()=' Done ']")).Click();
            //span[text()='Select one security question']

        }
    }
    
    }
/*Navigate onto https://www.royalcaribbean.com/
2.  Close if any pop up. or load create an account page directly and do from step 4
3.  Click Sign in and Click Create an account
4.  First Name as Dennis 
5.  Last Name as Rich
6.  Select Month as April 
7.  Day as 4
8.  Year as 1990
9.  Country as India
10. Any email address and password 
11. Select as “What was your first car's make or model?”
12. Type answer 
13. Accept the terms and condition 
14. Click done*/
