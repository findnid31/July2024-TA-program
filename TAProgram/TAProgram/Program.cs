using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        //Open Chrome Browser
        IWebDriver driver = new ChromeDriver();

        //Launch TurnUpPortal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

        //Identify Username textbox and valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");

        //Identify password textbox and enter valid password
        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");

        //Identify Login button 
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();

        //Check if user has logged in successfully
          IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (hellohari.Text == "Hello hari!")
        {
            Console.WriteLine("User has logged in successfully.Test Passed");
        }
        else
        {
            Console.WriteLine("User has not logged in.Test Failed");
        }

        //


    }
}