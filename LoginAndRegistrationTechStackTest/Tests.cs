using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace LoginAndRegistrationTechStackTest
{
    public class Tests
    {
        private IWebDriver driver;
        private UserService service;

        private readonly By _actualLogin = By.XPath("//span[text()='dansidorcov@gmail.com']");
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://sample-project.tech-stack.dev/");
            driver.Manage().Window.Maximize();
            service = new UserService(driver);
        }

        [Test]
        public void UserAccountCreateTest()
        {
            var actualLogin = driver.FindElement(_actualLogin).Text;

            Assert.AreEqual("DANSIDORCOV@GMAIL.COM", actualLogin, "Login is wrong");
        }

        [TearDown]
        public void TearDown()
        {
            service.Delete();
            driver.Quit();
            driver.Dispose();
        }
    }
}