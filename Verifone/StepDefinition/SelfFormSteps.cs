using System;
using System.Threading;
using TechTalk.SpecFlow;
using Verifone.PageObject;

namespace Verifone.StepDefinition
{
    [Binding]
    public class SelfFormSteps
    {
        SelfFormPage selfFormPage;

        public SelfFormSteps()
        {
            selfFormPage = new SelfFormPage();
        }
        


        [Given(@"The User navigate to the website ""(.*)""")]
        public void GivenTheUserNavigateToTheWebsite(string Url)
        {
            selfFormPage.NavigateToTheWebsite(Url);
        }
        
        [Given(@"I enter the first name ""(.*)""")]
        public void GivenIEnterTheFirstName(string NameText)
        {
            selfFormPage.IEnterFirstName(NameText);
        }
        
        [Given(@"I enter the last name ""(.*)""")]
        public void GivenIEnterTheLastName(string NameText)
        {
            selfFormPage.IEnterLastName(NameText);
        }
        
        [Given(@"I click Male")]
        [Given(@"I click Female")]
        public void GivenIClickFemale()
        {
            selfFormPage.IClickFemale();
        }

        [Given(@"I click selenuim commands")]
        public void GivenIClickSelenuimCommands()
        {
            selfFormPage.ISelectSelenuimCommands();
        }

        [When(@"I click choose file ""(.*)""")]
        public void WhenIClickChooseFile(string file)
        {
            selfFormPage.IClickChooseFile(file);
            Thread.Sleep(5000);
            ScenarioContext.Current["file"] = file;
        }

        [Then(@"I click button")]
        public void ThenIClickButton()
        {
            selfFormPage.IClickButton();
        }



        [Given(@"i click years of experinece")]
        public void GivenIClickYearsOfExperinece()
        {
            selfFormPage.IClickYearOfExperience();
        }

        [Given(@"I enter date")]
        public void GivenIEnterDate()
        {
            selfFormPage.IEnterDate();
        }


        [Given(@"I Click automation tester")]
        public void GivenIClickAutomationTester()
        {
            selfFormPage.IClickAutomationTester();
        }
        
        [Given(@"I click automation tool")]
        public void GivenIClickAutomationTool()
        {
            selfFormPage.IClickAutomationTools();
        }
        
        [Given(@"I select Continents")]
        public void GivenISelectContinents()
        {
            selfFormPage.ISelectContinents();
        }
        [Given(@"I click ok")]
        public void GivenIClickOk()
        {
            selfFormPage.IClickOk();
        }

        [Given(@"I click Got it")]
        public void GivenIClickGotIt()
        {
            selfFormPage.IClickGotIt();
        }



    }
}
