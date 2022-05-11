using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCourseFinal.Scenarios
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    public class RegisterInvalidAddress
    {
        IAlert alert;

        public RegisterInvalidAddress()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.RegistrationFormThroughTestScenarios();
        }


        [TestCase]
        public void EmptyUsernameField()
        {
            Actions.FillRegistrationForm(
                "111111",
                "passpass",
                "Faris",
                "",
                1,
                "71000",
                "fariscolakovic@icloud.com",
                true,
                true,
                "description"
                );

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidAddress, alert.Text);
            alert.Accept();
        }


        [TestCase]
        public void NonAlphaNumericCharacter()
        {
            Actions.FillRegistrationForm(
                "111111",
                "passpass",
                "Faris",
                "Adresa!",
                1,
                "71000",
                "fariscolakovic@icloud.com",
                true,
                true,
                "description"
                );

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidAddress, alert.Text);
            alert.Accept();
        }



        [TestCase]
        public void NumbersInsideTheAddress()
        {
            Actions.FillRegistrationForm(
                "1111111",
                "passpass",
                "Faris",
                "Dzemala Bijedica 140",
                1,
                "71000",
               "fariscolakovic@icloud.com",
                true,
                true,
                "description"
                );

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidAddress, alert.Text);
            alert.Accept();
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
