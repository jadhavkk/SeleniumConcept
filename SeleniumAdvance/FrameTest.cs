using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Maveric.SeleniumAdvance
{
    public class FrameTest
    {
        [Test]
        public void Frame1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";
            //f12 /ctrl+shift+c

           // driver.FindElement(By.XPath(""));






            /* driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//frame[@name='login_page']")));
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("kevin123");
            //click on continue

            driver.FindElement(By.LinkText("CONTINUE")).Click();
                 driver.FindElement(By.LinkText("CONTINUE")).Click();
            driver.FindElement(By.LinkText("CONTINUE")).Click();

            driver.SwitchTo().DefaultContent();*/

            //switch  back to main url
        }
        }
}
