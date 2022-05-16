using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumHW
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.onliner.by";

            driver.Manage().Window.Maximize();
        
            
            /*IWebElement loginButton = driver.FindElement(By.XPath("//div[contains(text(),'Вход')]"));

            
            loginButton.Click();

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var textLabel = driver.FindElement(By.XPath("//div[contains(@class, 'title')] [contains(text(), 'Вход')]"));

            var nick = driver.FindElement(By.XPath("//input[@type = 'text'][@placeholder = 'Ник или e-mail']"));
            nick.Click();
            nick.SendKeys("123w@gmail.com");

            var password = driver.FindElement (By.XPath("//input[@type = 'password']"));
            password.Click();
            password.SendKeys("12345");

            var submit = driver.FindElement(By.XPath("//div[@class = 'auth-form__control auth-form__control_condensed-additional']"));
            submit.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var errorText = driver.FindElement(By.XPath("//div[contains(text(),'Неверный логин или пароль')]"));

            
            
            
            
            //var error1 = driver.FindElement(By.XPath("//div[@class = 'auth-form__description auth-form__description_error auth-form__description_base auth-form__description_extended-other']"));


            //var error = driver.FindElement(By.XPath("//div[contains(@class, 'description')] [contains(text(), 'Неверный логин или пароль')]"));



            //var text = textLabel.Text;*/

            driver.Close();
        }
    }
}
