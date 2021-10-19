using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.google.com.co/");
            Console.WriteLine("Driver initialized");
        }

        [Test]
        public void ExecuteTest()
        {
            IWebElement barraNav = driver.FindElement(By.Name("q"));
            barraNav.SendKeys("Hola mundo");
            Console.WriteLine("Test executed");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Driver Closed");
        }
    }
}
