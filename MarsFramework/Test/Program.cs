using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void Test()
            {

                GlobalDefinitions.wait(5000);
                //create Shareskill
                ShareSkill shareSkill = new ShareSkill();
                shareSkill.addShareSkill();

                GlobalDefinitions.wait(5000);


               // shareSkill.addShareSkillWithIncomplteForm();
                //GlobalDefinitions.wait(5000);

                GlobalDefinitions.driver.Navigate().Back();
                GlobalDefinitions.wait(5000);
                shareSkill.gotoManageListing();


                 //call ManageLsitings
                 ManageListings ManageListings = new ManageListings();
                  ManageListings.Listings();


                  GlobalDefinitions.driver.Navigate().Back();



                  //call EditiconActions
                   ManageListings.EditiconActions();
                  GlobalDefinitions.driver.Navigate().Back();

                  //GlobalDefinitions.wait(5000);

                  ManageListings.DeleteiconActions();

            }
               


        }
    }
}