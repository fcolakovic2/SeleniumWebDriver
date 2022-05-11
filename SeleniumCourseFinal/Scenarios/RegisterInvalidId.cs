using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCourseFinal.Scenarios
{
    using OpenQA.Selenium;
    using NUnit.Framework;
    public class RegisterInvalidId
    {
        IAlert alert;

        public RegisterInvalidId()
        {

        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.RegistrationFormThroughTestScenarios();
        }


        [TestCase]
        public void LessThan5Chars()
        {
            Actions.FillRegistrationForm(
                "1",
                "password",
                "Faris",
                "Adresa",
                1,
                "71000",
                "fariscolakovic@icloud.com",
                true,
                true,
                "description"
                );

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.IdOutOfRange, alert.Text);
            alert.Accept();
        }


        [TestCase]
        public void MoreThan5Chars()
        {
            Actions.FillRegistrationForm(
                "111111111111111111",
                "password",
                "Faris",
                "Adresa",
                1,
                "71000",
               "fariscolakovic@icloud.com",
                true,
                true,
                  "description"
                );

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.IdOutOfRange, alert.Text);
            alert.Accept();
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
