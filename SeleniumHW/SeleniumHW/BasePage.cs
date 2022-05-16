using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumHW
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement FindElementByXPath (string xPath)
        {
            //var textLabel = _driver.FindElements(By.XPath(xPath));
            IWebElement element = null;
            int attemptsNumber = 0;

            //Waiter
            while (attemptsNumber < 10)
            {
                try
                {
                    element = _driver.FindElement(By.XPath(xPath));
                }
                catch (Exception exc)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("Can't find element");
                }
                if (element != null)
                {
                    break;
                }

                attemptsNumber++;
            }

            return element;
        }
    }
}
