﻿
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FacebookProject
{
    public class Program
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.facebook.com/signup";
           // driver.FindElement(By.("")).SendKeys("");
            //driver.FindElement(By.("")).SendKeys("");
           

        }
    }
}
