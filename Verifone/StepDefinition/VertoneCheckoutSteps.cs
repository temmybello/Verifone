using System;
using System.Threading;
using TechTalk.SpecFlow;
using Verifone.PageObject;

namespace Verifone.StepDefinition
{
    [Binding]
    public class VertoneCheckoutSteps
    {

        VertoneCheckoutPage vertoneCheckoutPage;

        public VertoneCheckoutSteps()
        {
            vertoneCheckoutPage = new VertoneCheckoutPage();
        }


        [Given(@"I navigate to the website ""(.*)""")]
        public void GivenINavigateToTheWebsite(string Url)
        {
            vertoneCheckoutPage.INavigateToWebsite(Url);
        }
        
        
        [Given(@"I click signin")]
        public void GivenIClickSignin()
        {
            vertoneCheckoutPage.IClickSignIn();
        }

        [Given(@"I enter email address ""(.*)""")]
        public void GivenIEnterEmailAddress(string EmailText)
        {
            vertoneCheckoutPage.IEnterEmailAddress(EmailText);
        }

        [Given(@"I click create and account")]
        public void GivenIClickCreateAndAccount()
        {
            vertoneCheckoutPage.IclickCreateAnAccount();
        }

        [Given(@"I click Mr")]
        public void GivenIClickMr()
        {
            vertoneCheckoutPage.IClickMr();
        }

        [Given(@"I enter first name ""(.*)""")]
        public void GivenIEnterFirstName(string Nametext)
        {
            vertoneCheckoutPage.IEnterCustomerFirstName(Nametext);
        }

        [Given(@"I enter Last name ""(.*)""")]
        public void GivenIEnterLastName(string NameText)
        {
            vertoneCheckoutPage.IEnterCustomerLastName(NameText);
        }

        [Given(@"I enter email ""(.*)""")]
        public void GivenIEnterEmail(string EmailText)
        {
            vertoneCheckoutPage.IEnterEmail(EmailText);
        }

        [Given(@"I enter password ""(.*)""")]
        public void GivenIEnterPassword(string PasswordText)
        {
            vertoneCheckoutPage.IEnterPassword(PasswordText);
        }

        [Given(@"I click day")]
        public void GivenIClickDay()
        {
            Thread.Sleep(5000);
            vertoneCheckoutPage.ISelectDays();
        }


        [Given(@"I Select Month")]
        public void GivenISelectMonth()
        {
            vertoneCheckoutPage.ISelectMonth();
        }

        [Given(@"I Select Year")]
        public void GivenISelectYear()
        {
            vertoneCheckoutPage.ISelectYears();
        }


        [Given(@"I click Sign up for our newsletter")]
        public void GivenIClickSignUpForOurNewsletter()
        {
            vertoneCheckoutPage.IClickNewsletters();
        }

        [Given(@"I enter User First name ""(.*)""")]
        public void GivenIEnterUserFirstName(string NameText)
        {
            vertoneCheckoutPage.IEnterFirstName(NameText);
        }

        [Given(@"I enter User Last name ""(.*)""")]
        public void GivenIEnterUserLastName(string NameText)
        {
            vertoneCheckoutPage.IEnterLastName(NameText);
        }

        [Given(@"I enter company ""(.*)""")]
        public void GivenIEnterCompany(string NameText)
        {
            vertoneCheckoutPage.IEnterCompany(NameText);
        }

        [Given(@"I enter address ""(.*)""")]
        public void GivenIEnterAddress(string NameText)
        {
            vertoneCheckoutPage.IEnterAddress(NameText);
        }

        [Given(@"I enter city ""(.*)""")]
        public void GivenIEnterCity(string NameText)
        {
            vertoneCheckoutPage.IEnterCity(NameText);
        }

        [Given(@"I select state")]
        public void GivenISelectState()
        {
            vertoneCheckoutPage.ISelectState();
        }

        [Given(@"I Select country")]
        public void GivenISelectCountry()
        {
            vertoneCheckoutPage.ISelectCountry();
        }

        [Given(@"I enter Postal code ""(.*)""")]
        public void GivenIEnterPostalCode(string NameText)
        {
            vertoneCheckoutPage.IEnterPostCode(NameText);
        }

        

        [Given(@"I enter Home phone")]
        public void GivenIEnterHomePhone()
        {
            vertoneCheckoutPage.IEnterHomePhone();
        }

        [Given(@"I enter Mobile phone")]
        public void GivenIEnterMobilePhone()
        {
            vertoneCheckoutPage.IEnterMobilePhone();
        }

        [When(@"I enter assign an address alias for future reference ""(.*)""")]
        public void WhenIEnterAssignAnAddressAliasForFutureReference(string NameText)
        {
            vertoneCheckoutPage.IEnterAlias(NameText);
        }


        [Then(@"I click register")]
        public void ThenIClickRegister()
        {
            vertoneCheckoutPage.IClickRegister();
        }































    }
}
