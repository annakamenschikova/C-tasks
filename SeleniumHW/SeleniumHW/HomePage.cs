using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumHW
{
    public class HomePage:BasePage
    {
        const string LoginButtonXPath = "//div[contains(text(),'Вход')]";


        IWebElement loginButton;
        //IWebElement 
        public HomePage(IWebDriver driver):base(driver)
        {
            
            loginButton = FindElementByXPath(LoginButtonXPath);
            
        }

        public void GoToLoginPage()
        {
            loginButton?.Click();
        }


        public bool CheckLoginButtonIsDisplayed()
        {
            return loginButton != null;
        }



    }
    /*public class HomePage
    {
        IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;

        }
        public void GoToLoginPage()
        {
            IWebElement loginButton = _driver.FindElement(By.XPath("//div[contains(text(),'Вход')]"));
            loginButton.Click();

        }
    }*/
}
