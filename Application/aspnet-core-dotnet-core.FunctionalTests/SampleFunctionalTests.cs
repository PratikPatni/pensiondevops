using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace SampleWebApplication.FunctionalTests
{
    [TestClass]
    public class SampleFunctionalTests
    {

        [TestMethod]
        public void SampleFunctionalTest1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://blazewebapp.azurewebsites.net/");
            Assert.IsTrue(driver.Title.ToUpper().Contains("ASP.NET"));
        }
    }
}