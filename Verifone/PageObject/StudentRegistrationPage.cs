using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Verifone.Utlilities;

namespace Verifone.PageObject
{
    class StudentRegistrationPage
    {
        public StudentRegistrationPage()
        {
            driver = Hooks1.driver;
            fileLocations = new FileLocations();
        }
        IWebDriver driver;
        private FileLocations fileLocations;

        IWebElement FirstName => driver.FindElement(By.XPath("//*[@id='firstName']"));
        IWebElement LastName => driver.FindElement(By.XPath("//*[@id='lastName']"));
        IWebElement Email => driver.FindElement(By.XPath("//*[@id='userEmail']"));
        IWebElement Female => driver.FindElement(By.XPath("//*[@id='genterWrapper']/div[2]/div[2]/label"));
        IWebElement Mobile => driver.FindElement(By.XPath("//*[@id='userNumber']"));
        IWebElement DayPicker => driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[2]/div[3]/div[4]"));
        IWebElement SelectMonth => driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[1]/select"));
        IWebElement MonthDropDown => driver.FindElement(By.XPath("//*[@id='dateOfBirthInput']"));
        IWebElement YearDropDown => driver.FindElement(By.XPath("//*[@id='dateOfBirthInput']"));
        IWebElement SelectYear => driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[1]/div[2]/div[2]/select"));
        IWebElement Subject => driver.FindElement(By.XPath("//*[@id='subjectsContainer']"));
        IWebElement DateOfBirth => driver.FindElement(By.XPath("//*[@id='dateOfBirthInput']"));
        IWebElement Hobbies => driver.FindElement(By.XPath("(//*[@id='hobbies-checkbox-1']"));
        IWebElement ChooseFile => driver.FindElement(By.XPath("//*[@id='uploadPicture']"));
        IWebElement Address => driver.FindElement(By.XPath("//*[@id='currentAddress']"));
        IWebElement StateDropDown => driver.FindElement(By.XPath("//*[@id='state']/div/div[1]/div[1]"));
        IWebElement Rajasthan => driver.FindElement(By.XPath("//*[@id='state']/div/div[1]/div[2]"));
        IWebElement CityDropDown => driver.FindElement(By.XPath("(//*[@class='css-19bqh2r'])[2]"));
        IWebElement City => driver.FindElement(By.XPath("//*[@id='city']/div/div[1]/div[1]"));
        IWebElement English => driver.FindElement(By.XPath("//*[@id='subjectsContainer']/div/div[1]/div[1]/div[1]"));
        IWebElement SubjectInput => driver.FindElement(By.XPath("//*[@id='subjectsInput']"));
        IWebElement Music => driver.FindElement(By.XPath("(//*[@class='custom-control-label'])[6]"));
        IWebElement NCR => driver.FindElement(By.XPath("//*[@id='state']/div/div[1]/div[2]"));
        IWebElement Arts => driver.FindElement(By.XPath("//*[@id='subjectsContainer']/div/div[1]/div[1]/div[1]"));
        IWebElement submit => driver.FindElement(By.XPath("//*[@id='submit']"));
        
        public void IClickSubmit()
        {
            submit.Click();
        }
        
        public void IClickArts()
        {
            Arts.Click();
        }
        public void IClickNCR()
        {
            Thread.Sleep(3000);
            NCR.Click();
        }
        
        public void IClickMusic()
        {
            Thread.Sleep(3000);
            Music.Click();
        }
        
        
        
        
        
        public void IclickSubjectInput()
        {
            Thread.Sleep(3000);
            SubjectInput.Click();
            
        }
        
        
        public void IClickEnglish()
        {
            Thread.Sleep(3000);
            English.SendKeys("English");
            English.Click();
        }



        public void IClickMonthDropDown()
        {
            Thread.Sleep(3000);
            MonthDropDown.Click();
        }

        public void IClickYearDropDown()
        {
            Thread.Sleep(3000);
            YearDropDown.Click();
        }

        public void ClickOnChoosefile(string fileImage)
        {
            Thread.Sleep(5000);
            //IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks1.driver;
            //js.ExecuteScript("window.scrollBy(0, 1500)");
            string imageFolder = fileLocations.GetFolderLocation("TestDataImages");
            ChooseFile.SendKeys(imageFolder + fileImage);
            ChooseFile.Click();
        }


        public void IClickCity()
        {
            City.Click();
        }
        
        public void IClickCityDropDown()
        {
            CityDropDown.Click();
        }
        
        public void IClickRajasthan()
        {
            Rajasthan.Click();
        }


        public void IClickStateDropDown()
        {
            StateDropDown.Click();
        }
        public void IEnterAddress(String NameText)
        {
            Address.SendKeys(NameText);
        }
        public void IClickHobbies()
        {
            Thread.Sleep(5000);
            Hobbies.Click();
        }

        public void IClickDateOfBirth()
        {
            //DateOfBirth.Clear();
            Thread.Sleep(5000);
            DateOfBirth.Click();
        }

        public void IClickSubject()
        {
            Thread.Sleep(5000);
            Subject.Click();
            //Subject.SendKeys("Arts");
        }

        public void ISelectYear()
        {
            //Thread.Sleep(5000);
            SelectElement select = new SelectElement(SelectYear);
            select.SelectByValue("2021");
        }


        public void IClickDayPicker()
        {
            Thread.Sleep(3000);
            DayPicker.Click();
        }

        public void ISelectMonth()
        {
            //SelectMonth.Click();
            Thread.Sleep(3000);
            SelectElement select = new SelectElement(SelectMonth);
            select.SelectByText("December");
        }

        public void IEnterMobile()
        {
            Mobile.SendKeys("0794432323");
        }

        public void IClickFemale()
        {
            Female.Click();
        }

        public void IEnterLastName(String NameText)
        {
            LastName.SendKeys(NameText);
        }
        public void IEnterEmail(String EmailText)
        {
            Email.SendKeys(EmailText);
        }


        public void IEnterFirstName(String NameText)
        {
            FirstName.SendKeys(NameText);
        }

        public void INavigateToWebsite(String Url)
        {
            Thread.Sleep(3000);
            driver.Navigate().GoToUrl(Url);
        }







    }
}
