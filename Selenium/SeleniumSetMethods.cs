using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium
{
    class SeleniumSetMethods
    {

        //Enter text
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (element == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click into a button, Checkbox, option, etc
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (element == "Id")
                driver.FindElement(By.Id(elementtype)).Click();
            if (element == "Name")
                driver.FindElement(By.Name(elementtype)).Click();
        }

        //Selecting a DropDown control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (element == "Id")
                new SelectElement(driver.FindElement(By.Id(elementtype))).SelectByText(value);
            if (element == "Name")
                new SelectElement(driver.FindElement(By.Name(elementtype))).SelectByText(value);
        }




    }
}
