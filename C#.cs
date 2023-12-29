using OpenQA.Selenium;

namespace FirstTestC_2
{
    public class Tests
    {

        private IWebDriver driver;

        private readonly By forHomeButton = By.XPath("//a[text()='Для дому']");
        private readonly By search = By.XPath("/html/body/div[1]/div[2]/div[1]/div/div[1]/div/div/div[2]/div/form/div/input");
        private readonly By searchButton = By.XPath("/html/body/div[1]/div[2]/div[1]/div/div[1]/div/div/div[2]/div/form/button");

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://shafa.ua/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            var choiceThink = driver.FindElement(forHomeButton);
            choiceThink.Click();

            var searcharea = driver.FindElement(search);
            searcharea.SendKeys("куртки");

            var searchButtonClick = driver.FindElement(searchButton);
            searchButtonClick.Click();
        }

        [TearDown]
        public void Teardown()
        {

        }
    }
}