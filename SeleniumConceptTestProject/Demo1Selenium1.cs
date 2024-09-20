using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConceptTestProject
{
    public class Demo1SeleniumAdvance
    {
        [Test]
        public void MultipleTabTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();
            //SwitchTabs
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //usernameandpassword
            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            driver.FindElement(By.Id("input_password")).SendKeys("admin");
            driver.FindElement(By.Id("input_go")).Click();

            driver.Close();

            //Switchto1st tab and Print title
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);
        }
    }
    public class Demo1SeleniumAdvance2
    {
        [Test]
        public void MultipleTabTest2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.online.citibank.co.in/";

            //Close Pop Up

            driver.FindElement(By.ClassName("newclose")).Click();
            driver.FindElement(By.ClassName("newclose2")).Click();

            //ClickBanking

            driver.FindElement(By.Id("topMnubanking")).Click();
            driver.FindElement(By.LinkText("Citi Commercial Bank")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//a[contains(text(),'Branch/ATM')]")).Click();


        }




    }
}   


    
    

