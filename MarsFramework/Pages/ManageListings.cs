using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using OpenQA.Selenium;


namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[3]/i[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = " //button[normalize-space()='Yes']")]
        private IWebElement popupYesButton { get; set; }
       

        internal void Listings()
        {

            //Populate the Excel Sheet 
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:/Supriya/marsframework-master/MarsFramework/ExcelData/TestDataManageListings.xlsx", "ManageListings");

            //click on Managelistings link
            // manageListingsLink.Click();

            //click on View icon
            view.Click();


        }
        internal void EditiconActions()
        {
            //click on Editicon in Actions in ManageListings
            edit.Click();

        }

        internal void DeleteiconActions()
        {

            // Reading Text "Selenium" from excel to delete 
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:/Supriya/marsframework-master/MarsFramework/ExcelData/TestDataManageListings.xlsx", "ManageListings");

            //Read "Title" from Excel Updatedshareskill sheet
          string Exceldelete= GlobalDefinitions.ExcelLib.ReadData(2, "Deleteaction");

            //click on Editicon in Actions in ManageListings
            delete.Click();
           GlobalDefinitions.wait(3);

            if (Exceldelete.Equals("Yes"))
            {
                popupYesButton.Click();

            }




        }
    }
}
