namespace SeleniumCourseFinal
{
    using OpenQA.Selenium;
    using NUnit.Framework;

    public class RegisterInvalidGender
    {
        IAlert alert;

  

        public RegisterInvalidGender()
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
                 1,
                "71000",
                "fariscolakovic@icloud.com",
                3,
                true,
                "description"
                );

            try 
            {
                Driver.driver.SwitchTo().Alert();
                Assert.Pass();
            }
            catch(NoAlertPresentException ex)
            {
                Assert.Fail();
            }

            

          
        }

        [TestCase]
        public void FirstSelected()
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

        [TestCase]
        public void SecondSelected()
        {
            Actions.FillRegistrationForm(
                "111111",
                "password",
                "Faris",
                "Adresa",
                 1,
                "71000",
                "fariscolakovic@icloud.com",
                2,
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