using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
     
        [Test]
        public void Test1()
        {
            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();
            //Navigate to vns nulp
            driver.Navigate().GoToUrl("http://vns.lpnu.ua/login/index.php");
            //
            driver.FindElement(By.Name("username")).Clear();
            driver.FindElement(By.Name("username")).SendKeys("Test");
            Thread.Sleep(1000);
            //
            driver.FindElement(By.Name("password")).Clear();
            driver.FindElement(By.Name("password")).SendKeys("Test" + Keys.Enter);
            Thread.Sleep(1000);
            //
            IWebElement actual = driver.FindElement(By.XPath("//a[@id='loginerrormessage']"));
            Thread.Sleep(1500);
            string expect = "Ви не пройшли ідентифікацію (неправильне ім’я користувача або пароль).<br />Спробуйте ще раз.";
            Assert.AreEqual(expect, actual.Text);
            Thread.Sleep(1000);
            //
            driver.Quit();
        }
    }
}