using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Browser initiate 
            IWebDriver driver = new ChromeDriver();

            //navigate to horse-dev
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");


            // Identfying the username 
            IWebElement firstName = driver.FindElement(By.Id("UserName"));
            firstName.SendKeys("hari");

            //Identify password 
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("123123");

            // Identify Login and click
            IWebElement loginbtn = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginbtn.Click();

            //assignment is to check whether hello hari is displayed on the page 
         
            // assignment 2 admin > time n material > create new 

            //Verification part
            // assignment 3 is to verify that the time an material object that you created is displayed on the table

            //Close the driver
            driver.Quit();
        
        }
    }
}
