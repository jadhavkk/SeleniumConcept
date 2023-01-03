using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace SeleniumAdvance
{
    public class ActionDemo1
    {
        [Test]
        public void Demo() {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://nasscom.in/about-us/contact-us";
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']")))//.Build().Perform();
            // driver.FindElement(By.XPath("//a[text()='Membership Benefits']")).Click();
            .MoveToElement(driver.FindElement(By.XPath("//a[text()='Become a Member']"))).Build().Perform();
            driver.FindElement(By.XPath("//a[text()='Membership Benefits']")).Click();
        }

        [Test]
        public void KeyBoardTest()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://nasscom.in/about-us/contact-us";

            Actions actions = new Actions(driver);
            actions.KeyDown(Keys.Shift).SendKeys("Good Evening").KeyUp(Keys.Shift).Pause(TimeSpan.FromSeconds(1))
                   .SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Pause(TimeSpan.FromSeconds(1))
                   .SendKeys(Keys.Enter).Build().Perform();






        }

    } }
