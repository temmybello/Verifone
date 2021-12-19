using System;
using System.Threading;
using TechTalk.SpecFlow;
using Verifone.PageObject;

namespace Verifone.StepDefinition
{
    [Binding]
    public class StudentFormSteps
    {
        StudentRegistrationPage studentRegistrationPage;

        public StudentFormSteps()
        {
            studentRegistrationPage = new StudentRegistrationPage();
        }


        [Given(@"User navigate to the website ""(.*)""")]
        public void GivenUserNavigateToTheWebsite(string Url)
        {
            studentRegistrationPage.INavigateToWebsite(Url);
        }


        [Given(@"I enter First name ""(.*)""")]
        public void GivenIEnterFirstName(string NameText)
        {
            studentRegistrationPage.IEnterFirstName(NameText);
        }
        
        [Given(@"I enter last name ""(.*)""")]
        public void GivenIEnterLastName(string NameText)
        {
            studentRegistrationPage.IEnterLastName(NameText);
        }
        
        [Given(@"I enter Email ""(.*)""")]
        public void GivenIEnterEmail(string EmailText)
        {
            studentRegistrationPage.IEnterEmail(EmailText);
        }
        
        [Given(@"I click female")]
        public void GivenIClickFemale()
        {
            studentRegistrationPage.IClickFemale();
        }

        [Given(@"I enter mobile number")]
        public void GivenIEnterMobileNumber()
        {
            studentRegistrationPage.IEnterMobile();
        }

        [Given(@"I Click day")]
        public void GivenIClickDay()
        {
            studentRegistrationPage.IClickDayPicker();
        }


        [Given(@"User select month")]
        public void GivenUserSelectMonth()
        {
            Thread.Sleep(5000);
            studentRegistrationPage.ISelectMonth();
        }

        [Given(@"User select year")]
        public void GivenUserSelectYear()
        {
            Thread.Sleep(5000);
            studentRegistrationPage.ISelectYear();
        }
        [Given(@"i click date of birth")]
        public void GivenIClickDateOfBirth()
        {
            studentRegistrationPage.IClickDateOfBirth();
        }
        [Given(@"I Click subject")]
        public void GivenIClickSubject()
        {
            studentRegistrationPage.IClickSubject();
        }

        [Given(@"I click English")]
        public void GivenIClickEnglish()
        {
            studentRegistrationPage.IClickEnglish();
        }


        [Given(@"User click month drop down")]
        public void GivenUserClickMonthDropDown()
        {
            studentRegistrationPage.IClickMonthDropDown();
        }

        [Given(@"User click year drop down")]
        public void GivenUserClickYearDropDown()
        {
            studentRegistrationPage.IClickYearDropDown();
        }

        [Given(@"I click Hobbies")]
        public void GivenIClickHobbies()
        {
            studentRegistrationPage.IClickHobbies();
        }

        [Given(@"I click music")]
        public void GivenIClickMusic()
        {
            studentRegistrationPage.IClickMusic();
        }

        [Given(@"I click Arts")]
        public void GivenIClickArts()
        {
            studentRegistrationPage.IClickArts();
        }


        [Given(@"I click NCR")]
        public void GivenIClickNCR()
        {
            studentRegistrationPage.IClickNCR();
        }


        [Given(@"I select state drop down")]
        public void GivenISelectStateDropDown()
        {
            studentRegistrationPage.IClickStateDropDown();
        }

        [Given(@"i click Rajasthan")]
        public void GivenIClickRajasthan()
        {
            studentRegistrationPage.IClickRajasthan();
        }

        [Given(@"I click picture ""(.*)""")]
        public void GivenIClickPicture(string FileImage)
        {
            studentRegistrationPage.ClickOnChoosefile(FileImage);
        }



        [Given(@"I enter current address ""(.*)""")]
        public void GivenIEnterCurrentAddress(string NameText)
        {
            studentRegistrationPage.IEnterAddress(NameText);
        }

        [Given(@"I Click city")]
        public void GivenIClickCity()
        {
            studentRegistrationPage.IClickCity();

        }

        [Given(@"I click city drop down")]
        public void GivenIClickCityDropDown()
        {
            studentRegistrationPage.IClickCityDropDown();
        }
        [Given(@"I Click subject input")]
        public void GivenIClickSubjectInput()
        {
            studentRegistrationPage.IclickSubjectInput();
        }

        [Then(@"I click submit")]
        public void ThenIClickSubmit()
        {
            studentRegistrationPage.IClickSubmit();
        }
    }
}
