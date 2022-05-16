using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumHW
{
    public class LoginPage:BasePage
    {
        IWebElement _textLabel;
        IWebElement _nickEditBox;
        IWebElement _passwordEditBox;
        IWebElement _submitButton;
        IWebElement _errorMessage;
        public LoginPage(IWebDriver driver):base(driver)

        {
            _textLabel = FindElementByXPath("//div[contains(@class, 'title')] [contains(text(), 'Вход')]");
            _nickEditBox = FindElementByXPath("//input[@type = 'text'][@placeholder = 'Ник или e-mail']");
            _passwordEditBox = FindElementByXPath("//input[@type = 'password']");
            _submitButton = FindElementByXPath("//button[@type = 'submit'][contains(text(), 'Войти')]");
            //_errorMessage = FindElementByXPath("//div[contains(@class = 'auth - form__line auth - form__line_condensed')]");
            
            
            //*[@id="auth-container"]/div/div[2]/div/form/div[3]/div
            //_errorMessage = FindElementByXPath("//*[@id="auth - container"]/div/div[2]/div/form/div[3]/div");

        }

        public bool CheckLoginPageIsDisplayed()
        {
            return _textLabel != null &&
                   _nickEditBox != null &&
                   _passwordEditBox != null &&
                   _submitButton != null;
        }
        public void Login(string nick, string password)
        {
            _nickEditBox?.SendKeys(nick);
            _passwordEditBox?.SendKeys(password);
            
        }
        public void Submit()
        {
            _submitButton?.Click();
        }

        public bool CheckErrorMessageIsAppeared()
        {
            _errorMessage = FindElementByXPath("//div[contains(@class, 'auth-form__description auth-form__description_error')] [contains(text(), 'Неверный логин или пароль')]");
            return _errorMessage != null;
        }

    }
}
