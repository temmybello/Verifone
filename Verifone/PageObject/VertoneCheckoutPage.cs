using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Verifone.Utlilities;

namespace Verifone.PageObject
{
    class VertoneCheckoutPage
    {
        public VertoneCheckoutPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

       
        IWebElement SignIn => driver.FindElement(By.XPath("//*[@class='login']"));
        IWebElement EmailAddress => driver.FindElement(By.XPath("//*[@id='email_create']"));
        IWebElement CreateAnAccount => driver.FindElement(By.XPath("//*[@id='SubmitCreate']/span"));
        IWebElement Mr => driver.FindElement(By.XPath("//*[@id='id_gender1']"));
        IWebElement CustomerFirstName => driver.FindElement(By.XPath("//*[@id='customer_firstname']"));
        IWebElement CustomerLastName => driver.FindElement(By.XPath("//*[@id='customer_lastname']"));
        IWebElement Email => driver.FindElement(By.XPath("//*[@id='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//*[@id='passwd']"));
        IWebElement Days => driver.FindElement(By.XPath("(//*[@class='form-control'])[1]"));
        IWebElement Month => driver.FindElement(By.XPath("//*[@id='months']"));
        IWebElement Years => driver.FindElement(By.XPath("//*[@id='years']"));
        IWebElement Newsletters => driver.FindElement(By.XPath("//*[@id='newsletter']"));
        IWebElement FirstName => driver.FindElement(By.XPath("//*[@id='firstname']"));
        IWebElement LastName => driver.FindElement(By.XPath("//*[@id='lastname']"));
        IWebElement Company => driver.FindElement(By.XPath("//*[@id='company']"));
        IWebElement Address => driver.FindElement(By.XPath("//*[@id='address1']"));
        IWebElement City => driver.FindElement(By.XPath("//*[@id='city']"));
        IWebElement Postcode => driver.FindElement(By.XPath("//*[@id='postcode']"));
        IWebElement State => driver.FindElement(By.XPath("//*[@id='id_state']"));
        IWebElement Country => driver.FindElement(By.XPath("//*[@id='id_country']"));
        IWebElement HomePhone => driver.FindElement(By.XPath("//*[@id='phone']"));
        IWebElement MobilePhone => driver.FindElement(By.XPath("//*[@id='phone_mobile']"));
        IWebElement Alias => driver.FindElement(By.XPath("//*[@id='alias']"));
        IWebElement Register => driver.FindElement(By.XPath("//*[@id='submitAccount']/span"));
        


        public IWebElement SelectYears { get; private set; }
        public IWebElement SelectMonth { get; private set; }
        public IWebElement SelectDays { get; private set; }
        public IWebElement SelectState { get; private set; }


        public void IClickSignIn()
        {
            SignIn.Click();
        }

        public void IEnterEmailAddress(String EmailText)
        {
            Thread.Sleep(5000);
            EmailAddress.SendKeys(EmailText);
        }

        public void IclickCreateAnAccount()
        {
            Thread.Sleep(5000);
            CreateAnAccount.Click();
        }

        public void IClickMr()
        {
            Thread.Sleep(5000);
            Mr.Click();
        }

        public void IEnterCustomerFirstName(String NameText)
        {
            CustomerFirstName.SendKeys(NameText);
        }
         public void IEnterCustomerLastName(String NameText)
        {
            CustomerLastName.SendKeys(NameText);
        }

        public void IEnterEmail(String EmailText)
        {
            Email.Clear();
            Email.SendKeys(EmailText);
        }

        public void IEnterPassword(String PasswordText)
        {
            Thread.Sleep(3000);
            Password.SendKeys(PasswordText);
        }

        public void ISelectDays()
        {
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(SelectDays);
            select.SelectByValue("5");
            Days.Click();
            Thread.Sleep(5000);
        }

        public void ISelectMonth()
        {
            Month.Clear();
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(SelectMonth);
            select.SelectByValue("3");
            Month.Click();
        }

        public void ISelectYears()
        {
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(SelectYears);
            select.SelectByValue("2014");
            Years.Click();
        }

        public void IClickState()
        {
            //State.Clear();
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(SelectState);
            select.SelectByValue("3");
            State.Click();
        }

        public void ISelectCountry()
        {
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(SelectState);
            select.SelectByValue("21");
            Country.Click();
        }
        
        public void IClickNewsletters()
        {
            Newsletters.Click();
        }

        public void IEnterFirstName(String NameText)
        {
            FirstName.SendKeys(NameText);
        }

        public void IEnterLastName(String NameText)
        {
            LastName.SendKeys(NameText);
        }

        public void IEnterCompany(String NameText)
        {
            Company.SendKeys(NameText);
        }

        public void IEnterAddress(String NameText)
        {
            Address.SendKeys(NameText);
        }

        public void IEnterCity(String NameText)
        {
            City.SendKeys(NameText);
        }

        public void IEnterPostCode(String NameText)
        {
            Postcode.SendKeys(NameText);
        }

        public void IEnterHomePhone()
        {
            HomePhone.SendKeys("0876654353");
        }

        public void IEnterMobilePhone()
        {
            MobilePhone.SendKeys("07676677788");
        }

        public void IEnterAlias(String NameText)
        {
            Alias.SendKeys(NameText);
        }

        public void IClickRegister()
        {
            Register.Click();
        }

        public void INavigateToWebsite(String Url)
        {
            driver.Navigate().GoToUrl(Url);
        }
    }
}
