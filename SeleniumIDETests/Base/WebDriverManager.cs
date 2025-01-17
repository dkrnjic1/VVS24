using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;

namespace SeleniumIDETests.Base
{
    internal class WebDriverManager
    {
        private static WebDriverManager _instance;
        private IWebDriver _driver;

        private WebDriverManager()
        {
            _driver = new EdgeDriver(); 
        }

        public static WebDriverManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WebDriverManager();
                }
                return _instance;
            }
        }

        public IWebDriver GetDriver()
        {
            return _driver;
        }

        public void QuitDriver()
        {
            _driver.Quit();
            _instance = null;
        }
    }
}
