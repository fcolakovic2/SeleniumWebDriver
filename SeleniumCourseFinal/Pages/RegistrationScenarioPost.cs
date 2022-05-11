
namespace SeleniumCourseFinal.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
   

    public class RegistrationScenarioPost
    {
        public RegistrationScenarioPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "userid")]
        public IWebElement IdField { get; set; }

        [FindsBy(How = How.Name, Using = "passid")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement NameField { get; set; }

        [FindsBy(How = How.Name, Using = "address")]
        public IWebElement AddressField { get; set; }

        [FindsBy(How = How.Name, Using = "country")]
        public IWebElement CountryDropDown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(2)")]
        public IWebElement AustraliaDropdown { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(1)")]
        public IWebElement DefaultDropdownCountryValue { get; set; }
        

        [FindsBy(How = How.CssSelector, Using = "#post-70 > div > form > ul > li:nth-child(10) > select > option:nth-child(6)")]
        public IWebElement USADropdown { get; set; }


        [FindsBy(How = How.Name, Using = "zip")]
        public IWebElement ZipField { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement EmailField { get; set; }

        //ovdje idu radio buttons

        [FindsBy(How = How.XPath, Using = "//input[@value='Male']")]
        public IWebElement MaleRadioButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Female']")]
        public IWebElement FemaleRadioButton { get; set; }

        [FindsBy(How = How.Name, Using = "languageQuestion")]
        public IWebElement CheckBoxLanguage { get; set; }

        [FindsBy(How = How.Id, Using = "desc")]
        public IWebElement DescriptionField { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='REGISTER']")]
        public IWebElement RegisterButton { get; set; }

    }
}
