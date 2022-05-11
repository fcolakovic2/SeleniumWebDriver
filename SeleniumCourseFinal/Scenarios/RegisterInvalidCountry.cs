namespace SeleniumCourseFinal
{
    using OpenQA.Selenium;
    using NUnit.Framework;

    public class RegisterInvalidCountry
    {
        IAlert alert;

        public RegisterInvalidCountry()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.RegistrationFormThroughTestScenarios();
        }

        [TestCase]
        public void NothingSelected()
        {

            Actions.FillRegistrationForm(
              "111111",
              "password",
              "Faris",
              "Adresa",
               -1,
              "71000",
              "fariscolakovic@icloud.com",
              1,
              true,
              "description"
              );
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.InvalidCountry, alert.Text);
            alert.Accept();
        }

    
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}