﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoFuncional.tests.utils
{
    class ClassDriver
    {
        private static ClassDriver classDriver;
        private IWebDriver driver;


        public IWebDriver Driver
        {
            get
            {
                return driver;
            }

            set
            {
                driver = value;
            }
        }

        private ClassDriver()
        {

        }

        public static ClassDriver GetInstance()
        {
            if (classDriver == null)
            {
                classDriver = new ClassDriver();
            }
            return classDriver;
        }

        public void StartDriver(string typeBrowser)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("test-type");
            chromeOptions.AddArguments("no-sandbox");
            driver = new ChromeDriver(chromeOptions);
            
        }

        public void QuitDriver()
        {
            Driver.Quit();
        }
    }
}
