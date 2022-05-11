namespace SeleniumCourseFinal
{
    using OpenQA.Selenium;
    using NUnit.Framework;

    public class RegisterInvalidZIP
    {
        IAlert alert;

        public RegisterInvalidZIP()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.RegistrationFormThroughTestScenarios();
        }

        [TestCase]
        public void OnlyLettersInZIPCode()
        {

            Actions.FillRegistrationForm(
              "111111",
              "password",
              "Faris",
              "Adresa",
              1,
              "abc",
              "fariscolakovic@icloud.com",
              1,
              true,
              "description"
              );
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidZIP, alert.Text);
            alert.Accept();
        }

        [TestCase]
        public void LettersAndNumbersInZIPCode()
        {

            Actions.FillRegistrationForm(
              "111111",
              "password",
              "Faris",
              "Adresa",
              1,
              "1abc1",
              "fariscolakovic@icloud.com",
              1,
              true,
              "description"
              );
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidZIP, alert.Text);
            alert.Accept();
        }



        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}