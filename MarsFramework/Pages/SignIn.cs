using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace MarsFramework.Pages
{
    class SignIn
    {

        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion


        //Finding the Join 
        [FindsBy(How = How.XPath, Using = "//A[@class='item'][text()='Sign In']")]
        private IWebElement signin { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/input[1]")]
        private IWebElement username { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Login']")]
        private IWebElement clickloginBtn { get; set; }

        //Method is Loginsteps()here  inside Method we perform user actions
        internal void LoginSteps()
        {



            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:/Supriya/marsframework-master/MarsFramework/ExcelData/TestData.xlsx", "SignIn");
            GlobalDefinitions.driver.Navigate().GoToUrl(GlobalDefinitions.ExcelLib.ReadData(2, "Url"));

            
            //first click on sigin button
            signin.Click();

            //user should enter Username
            username.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            //user should enter password
           password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            clickloginBtn.Click();

        }
    }
}