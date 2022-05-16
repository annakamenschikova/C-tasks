using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumHW;
using System.Threading;

namespace Tests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void LoginButtonIsDisplayed()

        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.onliner.by";

            driver.Manage().Window.Maximize();
            HomePage homePage = new HomePage(driver);
            Assert.IsTrue(homePage.CheckLoginButtonIsDisplayed());
            driver.Close();
        }

        [TestMethod]
        public void LoginPageIsDisplayed()

        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.onliner.by";

            driver.Manage().Window.Maximize();
            HomePage homePage = new HomePage(driver);
            homePage.GoToLoginPage();
            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue(loginPage.CheckLoginPageIsDisplayed());
            driver.Close();
        }
        [TestMethod]
        public void LoginWithInvalidCreadentials()

        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.onliner.by";

            driver.Manage().Window.Maximize();
            HomePage homePage = new HomePage(driver);
            homePage.GoToLoginPage();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Login("12345", "krkjrbvkjrb");
            loginPage.Submit();
            Assert.IsTrue(loginPage.CheckErrorMessageIsAppeared());
            
            driver.Close();
        }


    

    }
}
