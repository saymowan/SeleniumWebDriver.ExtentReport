using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumWebDriver.ExtentReport.SeleniumUteis
{
    public class SeleniumUteis
    {

        public static string UltimoErro = "";

        public static String getPathSeleniumDriver()
        {
            // Função para definir o path do diretório
            String strAppDir = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);

            //Função para reduzir em duas camadas a arvore do path
            var gparent = Directory.GetParent(Directory.GetParent(strAppDir).ToString());

            //Conversão var -> String
            String aux = gparent.ToString();

            //Concatenar Path diretorio + Path Drivers
            String strAppFolderData = String.Concat(aux, "\\Drivers");

            return strAppFolderData; //+ strAppFolderData;
        }


        // Método para esperar elemento "Espera explícita"
        public static void esperarElemento(IWebElement elemento)
        {
            //Ajuste provisório no método SeleniumBase ->  WebDriver
            WebDriverWait espera = new WebDriverWait(WebDriver.driver, TimeSpan.FromSeconds(50));
            espera.Until(ExpectedConditions.ElementToBeClickable(elemento));
            //Tenta validar se o elemento está clicavel
            try

            {
                espera.Until(ExpectedConditions.ElementToBeClickable(elemento));
            }
            catch (Exception e)
            {
                UltimoErro = e.Message;
                Assert.Fail("O elemento: '" + UltimoErro + "' não apareceu");
            }
        }//fim void


    }
}