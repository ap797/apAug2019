using OpenQA.Selenium;
using System;
using System.Threading;

namespace ConsoleApp1
{
    internal class TimenMaterialPage
    {
        internal void ClickCreateNew(IWebDriver driver)
        {

            //Click create new button
            driver.FindElement(By.XPath("//a[contains(.,'Create New')]")).Click();
        }

        internal void EnterValidDataandSave(IWebDriver driver)
        {

            //Enter code 
            driver.FindElement(By.Id("Code")).SendKeys("Floods");

            // Enterd description
            driver.FindElement(By.Id("Description")).SendKeys("Be safe");

            //Price per unit
            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys("10");

            //click save
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }

        internal void ValidateData(IWebDriver driver)
        {

            //Wait
            Thread.Sleep(3000);
            //Verification part
            // assignment 3 is to verify that the time an material object that you created is displayed on the table
            try
            {
                while (true)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        //Identify the code element
                        IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]"));
                        Console.WriteLine(code.Text);
                        if (code.Text == "H162RDA00075618")
                        {
                            Console.WriteLine("Test Passed, code found on table");
                            return;
                        }
                    }
                    driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]")).Click();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Test Failed, Code not found");
            }
        }
    }
}