using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Verifone.Utlilities;

namespace Verifone.PageObject
{
    class SelfFormPage
    {
        public SelfFormPage()
        {
            driver = Hooks1.driver;
            fileLocations = new FileLocations();
        }
        IWebDriver driver;
        private FileLocations fileLocations;

        IWebElement FirstName => driver.FindElement(By.XPath("//Input[@name='firstname']"));
        IWebElement LastName=> driver.FindElement(By.XPath("//Input[@name='lastname']"));
        IWebElement Female => driver.FindElement(By.XPath("//Input[@id='sex-1']"));
        IWebElement YearOfExperience => driver.FindElement(By.XPath("(//Input[@name='exp'])[1]"));
        IWebElement Date => driver.FindElement(By.XPath("//Input[@id='datepicker']"));
        IWebElement AutomationTester => driver.FindElement(By.XPath("//Input[@id='profession-1']"));
        IWebElement AutomationTools => driver.FindElement(By.XPath("//Input[@id='tool-0']"));
        IWebElement GotIt => driver.FindElement(By.XPath("/html/body/div[1]/div/a[1]"));
        IWebElement SelectContinents => driver.FindElement(By.XPath("//*[@id='continents']"));
        IWebElement Ok => driver.FindElement(By.XPath("//*[@id='cookieChoiceDismiss']"));
        IWebElement selectSelenuimCommands => driver.FindElement(By.XPath("(//*[@class='input-xlarge'])[2]"));
        IWebElement ChooseFile => driver.FindElement(By.XPath("//*[@id='photo']"));
        IWebElement Button => driver.FindElement(By.XPath("//*[@id='submit']"));
        
        
        
        
        public IWebElement SelectSelenuimCommands { get; private set; }

        public void IClickButton()
        {
            Button.Click();
        }
        public void IClickChooseFile(string fileImage)
        {
            // Scroll Vertical
           

            Thread.Sleep(5000);
             IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks1.driver;
            js.ExecuteScript("window.scrollTo(0,675.5555419921875)");
            //js.ExecuteScript("window.scrollBy(0, 1500)");
            string imageFolder = fileLocations.GetFolderLocation("TestDataImages");
                ChooseFile.SendKeys(imageFolder + fileImage);
                //ChooseFile.Click();
        }

        public void IClickOk()
        {
            Thread.Sleep(5000);
            Ok.Click();
        }
        
        
        public void IClickGotIt()
        {
            Thread.Sleep(5000);
            GotIt.Click();
        }

        public void IClickYearOfExperience()
        {
            YearOfExperience.Click();
        }
        public void IClickFemale()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks1.driver;
            js.ExecuteScript("window.scrollBy(0, 1500)");
            Thread.Sleep(5000);
            Female.Click();
        }
        public void IClickAutomationTools()
        {
            AutomationTools.Click();
        }
        public void IClickAutomationTester()
        {
            AutomationTester.Click();
        }
        public void IEnterDate()
        {
            Date.SendKeys("Sep 25, 2021");
        }
        public void IEnterLastName(String NameText)
        {
            LastName.SendKeys(NameText);
        }
        public void IEnterFirstName(String NameText)
        {
            FirstName.SendKeys(NameText);
        }
        public void ISelectSelenuimCommands()
        {
            //Thread.Sleep(5000);
            SelectElement select = new SelectElement(selectSelenuimCommands);
            select.SelectByText("Navigation Commands");
        }
        public void ISelectContinents()
        {
            //Thread.Sleep(5000);
            SelectElement select = new SelectElement(SelectContinents);
            select.SelectByText("Asia");
        }

        public void NavigateToTheWebsite(String Url)
        {
            driver.Navigate().GoToUrl(Url);
        }















    }
}
