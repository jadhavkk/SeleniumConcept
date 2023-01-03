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
using OpenQA.Selenium.Interactions;

namespace Maveric.PhpTravels
{
    public class PhpTravel
    {
        [Test]
        public void PhpTravelTest()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.phptravels.net/home";
           
            driver.FindElement(By.XPath("(//i[@class='la la-angle-down'])[3]")).Click();

            driver.FindElement(By.LinkText("English")).Click();

            driver.FindElement(By.XPath("//a[@class='active_flights waves-effect']")).Click();


            
             driver.FindElement(By.XPath("//input[@id='autocomplete']")).SendKeys("LAX");
            driver.FindElement(By.XPath("//b[text()='LAX']")).Click();

            driver.FindElement(By.XPath("//input[@id='autocomplete2']")).SendKeys("DLM");
            driver.FindElement(By.XPath("//b[text()='DLM']")).Click();

           

            //driver.FindElement(By.XPath("(//div[@class='autocomplete-result'])[1]")).Click();
            driver.ExecuteJavaScript(("document.querySelector('#departure').value='2023-01-30';"));

            driver.FindElement(By.XPath("//p[text()='Travellers ']")).Click();

            driver.FindElement(By.XPath("//i[@class='la la-plus']")).Click();

            driver.FindElement(By.XPath("//button[@id='flights-search']")).Click();



            //driver.Quit();



        }
    } }
/*Launch the web site https://www.phptravels.net/home
2.  Goto Flights  
3.  Choose "FROM" location as "Los Angeles" (LAX) 
4.  Choose "TO" as "Dallas" (DAL) 
5.  Set the travel date “2022-05-30”
6.  Adult as 2 
7.  Get the first flight details and print  
8.  Close the browser*/


