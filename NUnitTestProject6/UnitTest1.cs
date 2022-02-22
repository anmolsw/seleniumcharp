using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitTestProject6
{

    public class UnitTest1
    {
        IWebDriver driver;
        [Test]
        public void WikipediaSelectLangDropdown()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Url = "https://www.wikipedia.org";
            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);

            IWebElement element = driver.FindElement(By.XPath("//*[@id='searchLanguage']"));
            SelectElement selectElement = new SelectElement(element);

            selectElement.SelectByValue("bg");

            //this is atest
        }
        [Test]
        public void mousehover()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Url = "https://www.americangolf.co.uk";
            driver.Manage().Window.Maximize();

            Thread.Sleep(5000);
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/header/nav/div/div[1]/ul/li[2]/a"))).Build().Perform();
            
            try
            { 
                driver.FindElement(By.XPath("//*[@id='CLUBS_1']/ul/li[1]/ul/li[1]/a/span")).Click(); 
            }

            catch
            {
                System.Console.WriteLine("Element not interactable");
            }

            finally
            {
                driver.Quit();
            }
            
        }
    }


}