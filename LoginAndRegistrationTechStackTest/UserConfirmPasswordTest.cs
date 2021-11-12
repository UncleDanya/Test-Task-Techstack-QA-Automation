using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoginAndRegistrationTechStackTest
{
    class UserConfirmPasswordTest
    {
        private IWebDriver driver;
        private UserService service;

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://sample-project.tech-stack.dev/");
            driver.Manage().Window.Maximize();
            service = new UserService(driver);

        }

        [Test]
        public void Test()
        {
            service.Create();
            service.Update();
            Thread.Sleep(1000);
            service.NewPassAvto();
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
