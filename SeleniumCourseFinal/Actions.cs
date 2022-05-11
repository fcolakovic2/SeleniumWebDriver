namespace SeleniumCourseFinal
{
    using OpenQA.Selenium.Chrome;
    using Pages;

    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseURL);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost loginScenario = new LoginScenarioPost();

            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys(username);
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys(password);
            loginScenario.RepeatPasswordField.Clear();
            loginScenario.RepeatPasswordField.SendKeys(repeatPassword);
            loginScenario.LoginButton.Click();
        }

        public static void FillRegistrationForm(string id, string password, string name, string address, int country, string zip, string email, int gender, bool english, string aboutMe)
        {
            RegistrationScenarioPost registrationScenario = new RegistrationScenarioPost();

            registrationScenario.IdField.Clear();
            registrationScenario.IdField.SendKeys(id);

            registrationScenario.PasswordField.Clear();
            registrationScenario.PasswordField.SendKeys(password);

            registrationScenario.NameField.Clear();
            registrationScenario.NameField.SendKeys(name);

            registrationScenario.AddressField.Clear();
            registrationScenario.AddressField.SendKeys(address);

            if (country != -1) registrationScenario.USADropdown.Click();
            else registrationScenario.DefaultDropdownCountryValue.Click();

           
            registrationScenario.ZipField.Clear();
            registrationScenario.ZipField.SendKeys(zip);

            registrationScenario.EmailField.Clear();
            registrationScenario.EmailField.SendKeys(email);

          if (gender==1) registrationScenario.MaleRadioButton.Click();

          if (gender == 2) registrationScenario.FemaleRadioButton.Click();

            registrationScenario.CheckBoxLanguage.Click();

            registrationScenario.DescriptionField.Clear();
            registrationScenario.DescriptionField.SendKeys("About me");

            registrationScenario.RegisterButton.Click();








        }
    }
}
