using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;
using travlephp.Drivers;
using travlephp.Pages;

namespace travlephp.StepDefinitions
{
    [Binding]
    public class PhphomeStepDefinitions : basedriver
    {
        
        [Given(@"Navigate to homepage")]
        public void GivenNavigateToHomepage()
        {
           
            Setup();
            //throw new PendingStepException();
        }

       
        [When(@"Fill the demo request form")]
        public void WhenFillTheDemoRequestForm()
        {

            //throw new PendingStepException();
             Home hm = new Home(driver);
             hm.firstname.SendKeys("rakshith");
             hm.lastname.SendKeys("k");
             hm.businessname.SendKeys("hotel");
            hm.email.SendKeys("rakshith@gmail.com");
            hm.result.SendKeys("10");

        }

        [When(@"click on submit button")]
        public void WhenClickOnSubmitButton()
        {
            //throw new PendingStepException();
            Home he = new Home(driver);
            he.submit.Click();
            Thread.Sleep(2000);

            var alert = driver.SwitchTo().Alert();
            alert.Accept();
            Thread.Sleep(2000);

            /*Actions action = new Actions(driver);
            action.Click();
            action.SendKeys(OpenQA.Selenium.Keys.End).Build().Perform();
            Thread.Sleep(2000);*/

        }

        [Then(@"Instant demo request form submitted successfully")]
        public void ThenInstantDemoRequestFormSubmittedSuccessfully()
        {
            //throw new PendingStepException();
           

        }


        //signup

        [Given(@"Navigate to the homepage")]
        public void GivenNavigateToTheHomepage()
        {
            // throw new PendingStepException();
            //Setup();
        }

        [When(@"user click on signup button")]
        public void WhenUserClickOnSignupButton()
        {
            //throw new PendingStepException();
            Home hh = new Home(driver);
            hh.signup.Click();
        }

        [Then(@"it should navigate to registration page")]
        public void ThenItShouldNavigateToRegistrationPage()
        {
            throw new PendingStepException();
        }

        //signin

        [Given(@"Navigating to the homepage")]
        public void GivenNavigatingToTheHomepage()
        {
            //throw new PendingStepException();
           // Setup();
           
        }

        [When(@"user click on the sigin button")]
        public void WhenUserClickOnTheSiginButton()
        {
            //throw new PendingStepException();
            Home hq = new Home(driver);
            hq.signin.Click();

        }

        [Then(@"it should display  the signin page")]
        public void ThenItShouldDisplayTheSigninPage()
        {
            throw new PendingStepException();
        }




    }
}
