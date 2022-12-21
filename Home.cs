using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using travlephp.Drivers;

namespace travlephp.Pages
{
    public class Home : basedriver
    {
         public Home(IWebDriver driver)
         {
            PageFactory.InitElements(driver, this);
         }
        //IWebDriver driver;
        //public Home(IWebDriver driver) => this.driver = driver;

        //firstname
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='First Name']")]

        public IWebElement firstname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/section[1]/div/div/div[2]/div/div/div/div/div/div/div/div[1]/input[2]")]

        public IWebElement lastname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/section[1]/div/div/div[2]/div/div/div/div/div/div/div/div[1]/input[3]")]

        public IWebElement businessname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/section[1]/div/div/div[2]/div/div/div/div/div/div/div/div[1]/input[4]")]

        public IWebElement email { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"number\"]")]

        public IWebElement result { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/section[1]/div/div/div[2]/div/div/div/div/div/div/div/div[1]/div/div[1]/button")]

        public IWebElement submit { get; set; }


        //signup
        [FindsBy(How = How.XPath, Using = "//*[@id=\"loginSignup\"]/li[2]/a")]

        public IWebElement signup { get; set; }


        //signin
        [FindsBy(How = How.XPath, Using = "//*[@id=\"loginSignup\"]/li[1]/a")]

        public IWebElement signin { get; set; }












    }



}
