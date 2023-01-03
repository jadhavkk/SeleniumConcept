using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maveric.SeleniumAdvance
{
    public class FileUpload
    {
        [Test]
        public void fu1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://www.foundit.in/";
            driver.FindElement(By.XPath("//div[@class='heroSection-buttonContainer_secondaryBtn__text']")).Click();

            Actions actions = new Actions(driver);
          driver.FindElement(By.XPath("//button[text()='Or select file to upload']")).SendKeys("C:\\Users\\komalj\\Desktop");

        }
    } 
}

