namespace SeleniumCourseFinal
{
    using OpenQA.Selenium;
    using NUnit.Framework;

    public class RegisterInvalidEmail
    {
        IAlert alert;

        public RegisterInvalidEmail()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.RegistrationFormThroughTestScenarios();
        }

        [TestCase]
        public void EmptyEmail()
        {

            Actions.FillRegistrationForm(
              "111111",
              "password",
              "Faris",
              "Adresa",
               -1,
              "71000",
              "",
              1,
              true,
              "description"
              );
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidEmail, alert.Text);
            alert.Accept();
        }

        [TestCase]
        public void MailWithoutAtSign()
        {

            Actions.FillRegistrationForm(
              "111111",
              "password",
              "Faris",
              "Adresa",
               -1,
              "71000",
              "fariscolakovicicloud.com",
             1,
              true,
              "description"
              );
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidEmail, alert.Text);
            alert.Accept();
        }

        [TestCase]
        public void MailWithoutDot()
        {

            Actions.FillRegistrationForm(
              "111111",
              "password",
              "Faris",
              "Adresa",
               -1,
              "71000",
              "fariscolakovic@icloudcom",
              1,
              true,
              "description"
              );
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidEmail, alert.Text);
            alert.Accept();
        }

        [TestCase]
        public void MailWithOnlyLetters()
        {

            Actions.FillRegistrationForm(
              "111111",
              "password",
              "Faris",
              "Adresa",
               -1,
              "71000",
              "fariscolakovicicloudcom",
              1,
              true,
              "description"
              );
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidEmail, alert.Text);
            alert.Accept();
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}