namespace SeleniumCourseFinal
{
    using SeleniumCourseFinal.Pages;

    public static class NavigateTo
    {
        public static void LoginFormScenarioThroughTestCases()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameCasePost ucPost = new UsernameCasePost();

            menu.TestCases.Click();
            tcPage.UsernameCase.Click();
            ucPost.LoginFormLink.Click();
        }

        public static void LoginFormScenarioThroughMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            tsPage.LoginFormScenario.Click();
        }

        public static void RegistrationFormThroughTestScenarios()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            tsPage.RegistrationFormScenario.Click();
        }
    }
}
