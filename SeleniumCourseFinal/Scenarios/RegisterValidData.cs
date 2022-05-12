namespace SeleniumCourseFinal
{
    using OpenQA.Selenium;
    using NUnit.Framework;

    public class RegisterValidData
    {
        IAlert alert;

        public RegisterValidData()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.RegistrationFormThroughTestScenarios();
        }

        [TestCase]
        public void CorrectData()
        {

            Actions.FillRegistrationForm(
                "111111",
                "password",
                "Faris",
                "Adresa",
                 1,
                "71000",
                "fariscolakovic@icloud.com",
                1,
                true,
                "description"
                );


            try
            {
                Driver.driver.SwitchTo().Alert();
                Assert.Fail();
            }
            catch (NoAlertPresentException ex)
            {
                Assert.Pass();
            }


        }




        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}