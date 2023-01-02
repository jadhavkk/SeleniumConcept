using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;

namespace Maveric.SeleniumAdvance
{
    public class CitiBank
    {
        [Test]
        public void BankTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = " https://www.online.citibank.co.in/";
           driver.FindElement(By.XPath("//a[@class='fancybox-item fancybox-close']")).Click();
            driver.FindElement(By.XPath("//span[@class='txtSign']")).Click();
            
            //swtich to 2 tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//div[@onclick='ForgotUserID();']")).Click();
            //// div[contains(text(),'Forgot User ID?')] 
            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();
            driver.FindElement(By.Id("citiCard1")).SendKeys("4545");
            driver.FindElement(By.Id("citiCard2")).SendKeys("4545");
            //input[name='citiCard2']
            //driver.FindElement(By.Id("citiCard3")).SendKeys("8887");
            driver.FindElement(By.Id("citiCard4")).SendKeys("9998");
            driver.FindElement(By.Id("cvvnumber")).SendKeys("345");
            //#cvvnumber

            //date field - approach 1
            //driver.FindElement(By.Id("bill-date-long")).Click();

            //date fi app-2
            //click and try to automate-----javascript exexute use
            


            driver.ExecuteJavaScript("document.querySelector('#bill-date-long').value = '14/04/2000'");



            /*  SelectElement month = new SelectElement(driver.FindElement(By.XPath("//select[@class='ui-datepicker-month']")));
              month.SelectByText("Apr");
              SelectElement year = new SelectElement(driver.FindElement(By.XPath("//select[@class='ui-datepicker-year']")));
              year.SelectByText("2022");
              driver.FindElement(By.LinkText("14")).Click();
              driver.FindElement(By.XPath("//input[@type='button']")).Click();
              Thread.Sleep(1000);
              string textPrint = driver.FindElement(By.XPath("//li[contains(text(),'• Please accept Terms and Conditions ')]")).Text;
              Console.WriteLine(textPrint);*/
          
            //driver.ExecuteJavaScript("document.querySelector("li[contains(text(),'accept Terms')]")).


            //date fi app-2
            //click and try to automate/








        }
    } }/*Click on Forgot User ID?
5.  Choose Credit Card
6.  Enter credit card number as 4545 4545 8887 9998 
7.  Enter cvv number 
8.  Enter date as “14/04/2022”
9.  Click on Proceed 
10.  Get the text and print it “Please accept Terms and Conditions”
}*/
