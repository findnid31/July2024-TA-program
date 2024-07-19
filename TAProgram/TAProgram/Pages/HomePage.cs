using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TAProgram.Pages
{
    public class HomePage
    {
        public void NavigateToTMPage(IWebDriver driver)
        {
            // Navigate to Time & material page
            IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationTab.Click();

            IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterialOption.Click();
        }

    }
}
//public void VerifyLoggedInUser
    //Check if user has logged in successfully
          //IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

/*if (hellohari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully.Test Passed");
}
else
{
    Console.WriteLine("User has not logged in.Test Failed"); 
}*/