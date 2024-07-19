using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace TAProgram.Pages
{
    public class LoginPage
    {
        //Functions that allow user to login to TurnUp portal

        public void LoginActions(IWebDriver driver)
        {

            //Launch TurnUpPortal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");
            //Thread.Sleep(2000);

            //Identify Username textbox and valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            //Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //Identify Login button 
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);
            /* WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(5));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserName")));*/

        }
    }
}
