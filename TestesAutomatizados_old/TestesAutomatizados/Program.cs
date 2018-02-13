using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestesAutomatizados
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate();

            driver.Navigate().GoToUrl("http://www.google.com.br");

            IWebElement caixaDeTexto = driver.FindElement(By.Name("q"));

            caixaDeTexto.SendKeys("Caelum");

        }
    }
}
