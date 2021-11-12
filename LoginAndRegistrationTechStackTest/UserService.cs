using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoginAndRegistrationTechStackTest
{
    class UserService
    {
        private IWebDriver driver;
        private UserService service;

        public UserService(IWebDriver driver)
        {
            this.driver = driver;
        }

        public UserService(UserService service)
        {
            this.service = service;

        }

        private readonly By _signInButton = By.XPath("//a[text()='Create Account']");
        private readonly By _emailInputButton = By.XPath("//input[@class='form-control']");
        private readonly By _passInputButton = By.XPath("//input[@type='password']");
        private readonly By _passConfirmInputButton = By.XPath("//input[@name='confirmPassword']");
        private readonly By _signUpButton = By.XPath("//button[@class='btn btn-success']");
        private readonly By _dropDown = By.XPath("//a[@class='dropdown-toggle nav-link']");
        private readonly By _myAccountButton = By.XPath("//a[@class='dropdown-item']");
        private readonly By _deleteButton = By.XPath("//button[@class='btn btn-danger']");
        private readonly By _actualLogin = By.XPath("//span[text()='dansidorcov@gmail.com']");
        private readonly By _changePassInputButton = By.XPath("//input[@name='password']");
        private readonly By _changeConfirmInputButton = By.XPath("//input[@name='confirmPassword']");
        private readonly By _changePassButton = By.XPath("//button[@class='btn btn-primary']");
        private readonly By _logOutButton = By.XPath("//a[@href='/logout']");
        private readonly By _loginButton = By.XPath("//a[@href='/login']");
        private readonly By _loginChangeButton = By.XPath("//button[@class='col-md-3 btn btn-primary']");

        private const string _emailLogin = "DANSIDORCOV@GMAIL.COM";
        private const string _passLogin = "wudcif-pysfa9-vYkwuh";
        private const string _changepassword = "VudiWudPaker";
        public void Create()
        {
            var signIn = driver.FindElement(_signInButton);
            signIn.Click();

            var email = driver.FindElement(_emailInputButton);
            email.SendKeys(_emailLogin);

            var pass = driver.FindElement(_passInputButton);
            pass.SendKeys(_passLogin);

            var confirmPass = driver.FindElement(_passConfirmInputButton);
            confirmPass.SendKeys(_passLogin);

            var signUp = driver.FindElement(_signUpButton);
            signUp.Click();
        }

        public void Update()
        {
            var log = driver.FindElement(_dropDown);
            log.Click();

            var enter = driver.FindElement(_myAccountButton);
            enter.Click();

            var change = driver.FindElement(_changePassInputButton);
            change.SendKeys(_changepassword);

            var confrimPass = driver.FindElement(_changeConfirmInputButton);
            confrimPass.SendKeys(_changepassword);

            var changeButton = driver.FindElement(_changePassButton);
            changeButton.Click();
        }

        public void NewPassAvto()
        {
            var logOut = driver.FindElement(_dropDown);
            logOut.Click();
            Thread.Sleep(1000);

            var logOutButton = driver.FindElement(_logOutButton);
            logOutButton.Click();

            var loginBut = driver.FindElement(_loginButton);
            loginBut.Click();

            var logEmail = driver.FindElement(_emailInputButton);
            logEmail.SendKeys(_emailLogin);

            var logNewPass = driver.FindElement(_passInputButton);
            logNewPass.SendKeys(_changepassword);

            var loginChangeButton = driver.FindElement(_loginChangeButton);
            loginChangeButton.Click();
        }

        public void Login()
        {
            var loginBut = driver.FindElement(_loginButton);
            loginBut.Click();

            var logEmail = driver.FindElement(_emailInputButton);
            logEmail.SendKeys(_emailLogin);

            var logNewPass = driver.FindElement(_passInputButton);
            logNewPass.SendKeys(_passLogin);

            var loginChangeButton = driver.FindElement(_loginChangeButton);
            loginChangeButton.Click();
        }

        public void Delete()
        {
            var dropDown = driver.FindElement(_dropDown);
            dropDown.Click();

            var myAccount = driver.FindElement(_myAccountButton);
            myAccount.Click();

            var deleteAccount = driver.FindElement(_deleteButton);
            deleteAccount.Click();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
        }
    }
}
