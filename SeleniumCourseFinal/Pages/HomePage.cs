namespace SeleniumCourseFinal.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > header > div.mh-container.mh-container-inner.mh-row.clearfix > div > a > div > div > h1")]
        public IWebElement Header { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > header > div.mh-container.mh-container-inner.mh-row.clearfix > div > a > div > div > h2")]
        public IWebElement SubHeader { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > div > p:nth-child(1) > a > img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#page-17 > header > h1")]
        public IWebElement Headline { get; set; }
    }
}
