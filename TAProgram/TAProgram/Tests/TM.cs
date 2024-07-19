
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAProgram.Pages;
using TAProgram.Utilities;


namespace TAProgram.Tests
{
    [TestFixture]
    public class TM : CommonDriver

    {
        [SetUp]
        public void SetUpSteps()

          

        { // Login page object initialization and definition

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToTMPage(driver);
        }
        [Test]
        public void CreateTime_Test()
        { // TM page object initialization and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTimeRecord(driver);
        }
        [Test]
        public void EditTime_Test() 
        { }
        [Test]

        public void DeleteTime_Test() 
        { }
        [TearDown]
        public void CloseTestRun ()
        { }
    }
}
