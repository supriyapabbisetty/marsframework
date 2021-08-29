using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using MarsFramework.Global;
using System.Linq;
using System;
using System.Threading;
using AutoItX3Lib;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }


        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/label")]
        private IWebElement HourlybasisserviceLbel { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement Oneoffservice { get; set; }


        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/label")]
        private IWebElement OnsiteLbel { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement Onsite { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the table of MOnday days
        [FindsBy(How = How.XPath, Using = "//div[3]//div[1]//div[1]//input[1]")]
        private IWebElement Mon { get; set; }

        //Storing the table of Tueday days
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input")]
        private IWebElement Tue { get; set; }


        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Worksamples Uploadfile
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        private IWebElement upload { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //selecting Activelabel
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/label")]
        private IWebElement Activelabel { get; set; }

        //selecting Activeradiobutton
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        private IWebElement Activeradiobutton { get; set; }

        //selecting Hiddenlabel
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/label")]
        private IWebElement Hiddenlabel { get; set; }

        //selecting Hiddenradiobutton
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement Hiddenradionbutton { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //define new element for Editpen in Shareskill
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[2]/i[1]")]
        private IWebElement Elementpen { get; set; }

        //popup messagebox xpath for Assertion
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]")]
        private IWebElement Popupmessage { get; set; }

        //popup messagebox xpath for Assertion
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/a[3]")]
        private IWebElement manageListingLink { get; set; }

        

        internal void addShareSkill()
        {

            ShareSkillButton.Click();
            //reading Data from excel in shareskill page
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:/Supriya/marsframework-master/MarsFramework/ExcelData/TestDataShareSkill.xlsx", "ShareSkill");

            //reading data from CSV "Title" in Shareskill page after opening 

            //Reading "Title" "Selenium" from Excel
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            //Reading "Description" from Excel
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            //Reading "Category" from Excel
            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

            //Reading"SubCategory"from Excel
            SubCategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));

            //Reading"Tags"from Excel
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            //to add Tags press"Enter key"
            Tags.SendKeys(Keys.Enter);

            GlobalDefinitions.wait(5000);

            //Reading"ServiceType"from Excel
            String excelservicetypeData = GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType");
            Console.WriteLine("MY excelservicetypeData:" + excelservicetypeData);

            String Hourlybasisservice = HourlybasisserviceLbel.Text;

            if (excelservicetypeData.Equals(Hourlybasisservice)) {

                Oneoffservice.Click();
            }

            GlobalDefinitions.wait(5000);

            String excelLocationType = GlobalDefinitions.ExcelLib.ReadData(2, "LocationType");

            String onsiteLabelText = OnsiteLbel.Text;
            if (excelLocationType.Equals(onsiteLabelText))
            {

                Onsite.Click();
            }
            string Excelstartdate = GlobalDefinitions.ExcelLib.ReadData(2, "Startdate");
            

            //Reading"Startdate"from Excel
            StartTimeDropDown.SendKeys(Excelstartdate);

            //Reading"Enddate"from Excel
            EndTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));

            String excelMonday = GlobalDefinitions.ExcelLib.ReadData(2, "Selectday");

            if (excelMonday.Equals("Mon")) {

                Mon.Click();
            }


            GlobalDefinitions.wait(5000);

            string Excelstarttime = GlobalDefinitions.ExcelLib.ReadData(2, "Starttime");

            Console.WriteLine(Excelstarttime);

            //Reading"Starttime"from Excel
            StartTime.SendKeys(Excelstarttime);
            string Excelendtime = GlobalDefinitions.ExcelLib.ReadData(2, "Endtime");
            Console.WriteLine(Excelendtime);
            //Reading"Endtime"from Excel
            EndTimeDropDown.SendKeys(Excelendtime);

            //Reading"SkillTrade"from Excel
            

            //Reading"Skill-Exchange"from Excel
            SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
            SkillExchange.SendKeys(Keys.Enter);

            //Worksample uploadimage
            upload.Click();

            AutoItX3 autoit = new AutoItX3();
           // GlobalDefinitions.wait(5000);
            autoit.WinActivate("Open");
            //GlobalDefinitions.wait(3000);
            Thread.Sleep(1000);

            autoit.Send(@"C:\Supriya\marsframework-master\flower.jpg");
            //Thread.Sleep(1000);

            GlobalDefinitions.wait(5000);
            autoit.Send("{ENTER}");

            GlobalDefinitions.wait(5000);

            //Reading"Active"from Excel
            String Hidden = GlobalDefinitions.ExcelLib.ReadData(2, "Active");

            String Hiddenlabeltext = Hiddenlabel.Text;
            if (Hidden.Equals(Hiddenlabeltext))
            {

                Hiddenradionbutton.Click();
            }


            //click on 
           Save.Click();


            String messageFromScreen=Popupmessage.Text;

            GlobalDefinitions.wait(20000);

            // Assert expected result= actual result
            NUnit.Framework.Assert.AreNotEqual("Please complete the form correctly", messageFromScreen);
        }

        internal void gotoManageListing()
        {
            manageListingLink.Click();
        }

        internal void addShareSkillWithIncomplteForm()
        {

            ShareSkillButton.Click();
            //reading Data from excel in shareskill page
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:/Supriya/marsframework-master/MarsFramework/ExcelData/TestDataShareSkill.xlsx", "ShareSkill");

            //reading data from CSV "Title" in Shareskill page after opening 

            //Reading "Title" "Selenium" from Excel
            // Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            //Reading "Description" from Excel
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            //Reading "Category" from Excel
            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

            //Reading"SubCategory"from Excel
            SubCategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));

            //Reading"Tags"from Excel
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            //to add Tags press"Enter key"
            Tags.SendKeys(Keys.Enter);

            GlobalDefinitions.wait(5000);

            //Reading"ServiceType"from Excel
            String excelservicetypeData = GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType");
            Console.WriteLine("MY excelservicetypeData:" + excelservicetypeData);

            String Hourlybasisservice = HourlybasisserviceLbel.Text;

            if (excelservicetypeData.Equals(Hourlybasisservice))
            {

                Oneoffservice.Click();
            }

            GlobalDefinitions.wait(5000);

            String excelLocationType = GlobalDefinitions.ExcelLib.ReadData(2, "LocationType");

            String onsiteLabelText = OnsiteLbel.Text;
            if (excelLocationType.Equals(onsiteLabelText))
            {

                Onsite.Click();
            }
            string Excelstartdate = GlobalDefinitions.ExcelLib.ReadData(2, "Startdate");


            //Reading"Startdate"from Excel
            StartTimeDropDown.SendKeys(Excelstartdate);

            //Reading"Enddate"from Excel
            EndTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));

            String excelMonday = GlobalDefinitions.ExcelLib.ReadData(2, "Selectday");

            if (excelMonday.Equals("Mon"))
            {

                Mon.Click();
            }


            GlobalDefinitions.wait(5000);

            string Excelstarttime = GlobalDefinitions.ExcelLib.ReadData(2, "Starttime");

            Console.WriteLine(Excelstarttime);

            //Reading"Starttime"from Excel
            StartTime.SendKeys(Excelstarttime);
            string Excelendtime = GlobalDefinitions.ExcelLib.ReadData(2, "Endtime");
            Console.WriteLine(Excelendtime);
            //Reading"Endtime"from Excel
            EndTimeDropDown.SendKeys(Excelendtime);

            //Reading"SkillTrade"from Excel


            //Reading"Skill-Exchange"from Excel
            SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
            SkillExchange.SendKeys(Keys.Enter);


            //Reading"Active"from Excel
            String Hidden = GlobalDefinitions.ExcelLib.ReadData(2, "Active");

            String Hiddenlabeltext = Hiddenlabel.Text;
            if (Hidden.Equals(Hiddenlabeltext))
            {

                Hiddenradionbutton.Click();
            }


            //click on 
            Save.Click();

            GlobalDefinitions.wait(2000);

            String messageFromScreen = Popupmessage.Text;

            //Console.WriteLine(messageFromScreen);


            // Assert expected result= actual result
            NUnit.Framework.Assert.AreEqual("Please complete the form correctly.", messageFromScreen);
        }


        internal void ManualEditShareSkill()
        {

            Elementpen.Click();

            //clear "Title" txt field to edit
            Title.Clear();

            //Enter new txt in "Title"
            Title.SendKeys("selenium to Java");

            //clear "Description"txt field to edit
            Description.Clear();

            //enter text in "Description"txt field to edit
            Description.SendKeys("Updated description");


            //click on Save
            Save.Click();


        }
        internal void EditShareSkill()
        {
            //click on pen to edit in Shareskillpage
            Elementpen.Click();

            GlobalDefinitions.wait(5000);

            //Read data from Excel to updata in Shareskill
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:/Supriya/marsframework-master/MarsFramework/ExcelData/TestDataShareSkill.xlsx", "EditShareSkill");

            //clear "Title" txt field to edit
            Title.Clear();

            //Read "Title" from Excel Updatedshareskill sheet
            Title.SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Title")));

            //clear"Description" txt field to edit
            Description.Clear();


            //Read"Description"from Excel Updatedshareskillsheet
            Description.SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Description")));

            //Read "CategoryDropDown"from Excel Updatedshareskillsheet
            CategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

            //Read"SubCategoryDropDown"from Excel Updatedshareskill sheet
            SubCategoryDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));


            //Read"Tags"from Excel Updatedshareskillsheet
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            //to add Tags press"Enter key"
            Tags.SendKeys(Keys.Enter);

             GlobalDefinitions.wait(5000);
            

            //Read"ServiceType"from Excel Updatedshareskillsheet
            String excelservicetypeData = GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType");
            Console.WriteLine("MY excelservicetypeData:" + excelservicetypeData);

            String Hourlybasisservice = HourlybasisserviceLbel.Text;

            if (excelservicetypeData.Equals(Hourlybasisservice))
            {

                Oneoffservice.Click();
            }


            //Read"ServiceType"from Excel Updatedshareskillsheet
            String excelLocationType = GlobalDefinitions.ExcelLib.ReadData(2, "LocationType");

            String onsiteLabelText = OnsiteLbel.Text;
            if (excelLocationType.Equals(onsiteLabelText))
            {

                Onsite.Click();
            }


            //Read"Startdate"from Excel Updatedshareskill
            StartTime.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));


            //Read"EndDate"from Excel Updatedshareskillsheet 
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));


            //Read"Selectday"from Excel Updateshareskillsheet
            

            String excelTueday = GlobalDefinitions.ExcelLib.ReadData(2, "Selectday");

            if (excelTueday.Equals("Tue"))
            {

                Tue.Click();
            }



            //Read "Starttime"from Excel Updatedshareskillsheet
            StartTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"));


            //Read"Endtime"from Excel Updatedshareskillsheet
            EndTimeDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));


          
            //Read"SkillTrade"from Excel Updatedshareskillsheet
            

            //Reading"Skill-Exchange"from Excel
            SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
            //press Enter to save Tag in Skillexchange
            SkillExchange.SendKeys(Keys.Enter);

            //Reading"CreditAmount"from Excel
            // CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));

            //Reading"Active"from Excel
            String Hidden = GlobalDefinitions.ExcelLib.ReadData(2, "Active");

            String Hiddenlabeltext = Hiddenlabel.Text;
            if (Hidden.Equals(Hiddenlabeltext))
            {

                Hiddenradionbutton.Click();
            }


            //Click on Save button to save Edit data
            Save.Click();


        }


    }
}
