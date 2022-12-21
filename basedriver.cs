using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace travlephp.Drivers
{
    public class basedriver
    {
        public IWebDriver driver;

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://phptravels.com/demo/");
            driver.Manage().Window.Maximize();


        }

    
    }
}
