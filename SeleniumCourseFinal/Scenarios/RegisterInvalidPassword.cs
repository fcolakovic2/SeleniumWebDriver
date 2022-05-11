using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCourseFinal.Scenarios
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    public class RegisterInvalidPassword
    {
        IAlert alert;

        public RegisterInvalidPassword()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.RegistrationFormThroughTestScenarios();
        }


        [TestCase]
        public void LessThan7Chars()
        {
            Actions.FillRegistrationForm(
                "111111",
                "pass",
                "Faris",
                "Adresa",
                1,
                "71000",
                "fariscolakovic@icloud.com",
                1,
                true,
                "description"
                );

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.PasswordOutOfRange, alert.Text);
            alert.Accept();
        }


        [TestCase]
        public void MoreThan5Chars()
        {
            Actions.FillRegistrationForm(
                "1111111",
                "passpasswordpass",
                "Faris",
                "Adresa",
                1,
                "71000",
               "fariscolakovic@icloud.com",
                1,
                true,
                "description"
                );

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.PasswordOutOfRange, alert.Text);
            alert.Accept();
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
