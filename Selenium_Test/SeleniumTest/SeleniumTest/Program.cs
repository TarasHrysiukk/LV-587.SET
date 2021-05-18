using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("http://vns.lpnu.ua/login/index.php");

            //Maximize the window
           // driver.Manage().Window.Maximize();

            //Find the button
            //driver.FindElement(By.PartialLinkText("Sign")).Click();
            //Thread.Sleep(1000);
            //
            driver.FindElement(By.Name("username")).Clear();
            driver.FindElement(By.Name("username")).SendKeys("Test");
            Thread.Sleep(1000);
            //
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("Test" + Keys.Enter);
            Thread.Sleep(1000);
            //
            IWebElement actual = driver.FindElement(By.Id("yui_3_17_2_1_1621316293025_29"));
            Thread.Sleep(1500);
            
            //Close the browser
            driver.Close();
        }
    }
}
