using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCourseFinal.Scenarios
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    public class RegisterInvalidName
    {
        IAlert alert;

        public RegisterInvalidName()
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
                "",
                "Adresa",
                1,
                "71000",
                "fariscolakovic@icloud.com",
                true,
                true,
                "description"
                );

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidUsername, alert.Text);
            alert.Accept();
        }


        [TestCase]
        public void NumbersInsideAUsername()
        {
            Actions.FillRegistrationForm(
                "1111111",
                "passpass",
                "Faris1",
                "Adresa",
                1,
                "71000",
               "fariscolakovic@icloud.com",
                true,
                true,
                "description"
                );

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidUsername, alert.Text);
            alert.Accept();
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
