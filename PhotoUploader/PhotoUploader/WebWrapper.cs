using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PhotoUploader
{
    class WebWrapper
    {
        private ChromeDriver chromeDriver;

        public WebWrapper()
        {
            chromeDriver = new ChromeDriver();
        }

        public void OpenBrowser(string url)
        {
            chromeDriver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            chromeDriver.Quit();
        }

        public void ClickOnElementByName(string elementName)
        {
            var element = chromeDriver.FindElement(By.Name(elementName));
            element.Click();
        }

        public void ClickOnElementByClassName(string elementClassName)
        {
            var element = chromeDriver.FindElement(By.ClassName(elementClassName));
            element.Click();
        }

        public void ClickOnElementByPath(string elementPath)
        {
            var element = chromeDriver.FindElement(By.XPath(elementPath));
            element.Click();
        }

        public void ClickOnElementByCssSelector(string elementSelector)
        {
            var element = chromeDriver.FindElement(By.CssSelector(elementSelector));
            element.Click();
        }

        public void ClickOnElementByLinkText(string elementText)
        {
            var element = chromeDriver.FindElement(By.LinkText(elementText));
            element.Click();
        }

        public void FillFieldByName(string fieldName, string text)
        {
            var field = chromeDriver.FindElement(By.Name(fieldName));
            field.Clear();
            field.SendKeys(text);
        }

        public void FillFieldByClassName(string fieldClassName, string text)
        {
            var field = chromeDriver.FindElement(By.Name(fieldClassName));
            field.Clear();
            field.SendKeys(text);
        }

        public void UploadFile(string elementPath, string fileName)
        {
            var fileInput = chromeDriver.FindElement(By.XPath(elementPath));
            fileInput.SendKeys(fileName);
        }
    }
}
