using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;

namespace SeleniumWebDriver.ExtentReport.SeleniumUteis
{
    public class Relatorio
    {
        public ExtentReports report { get; set; }
        public ExtentTest test { get; set; }
        public string descrTeste;
        public string image;

        /// <summary>
        /// Método que inicia a captura de informações do teste
        /// </summary>
        /// <param name="descricaoTeste"></param>
        public void iniciarTeste(string descricaoTeste)
        {
            test = report.StartTest(descricaoTeste);       
            descrTeste = descricaoTeste;
        }

        /// <summary>
        /// Arquivo que realiza a criação do arquivo de Log
        /// </summary>
        public void criarArquivoLog()
        {
            string filepath = SeleniumConstantes.diretorioFolderLog + "ExtentReport.html";
            report = new ExtentReports(filepath, false);
            //report.LoadConfig(SeleniumComum.SeleniumUteis.getPathExtentConfig() + SeleniumConstantes.arquivoExtentConfig);
        }

        /// <summary>
        /// Método responsável para a geração de evidências
        /// </summary>
        public void gerarPrintScreen()
        {
            //captura printscreen
            Thread.Sleep(500);
            Screenshot ss = ((ITakesScreenshot)WebDriver.driver).GetScreenshot();
            
            //Salva arquivo
            string screenshot = ss.AsBase64EncodedString;
            byte[] screenshotAsByteArray = ss.AsByteArray;

            string time = DateTime.Now.ToString("HHmmss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            string printAtual = descrTeste + "_" + time + ".png";
            ss.SaveAsFile(SeleniumConstantes.diretorioFolderPrint + printAtual, System.Drawing.Imaging.ImageFormat.Png);
            ss.ToString();

            var urlImagem = $"{SeleniumConstantes.diretorioFolderPrint}{printAtual}".Replace("\\", "//");

            //Alterações Local/Server
            image = test.AddScreenCapture(urlImagem);

        }


        public void gravarLogPass(string mensagem)
        {
            gerarPrintScreen();
            test.Log(LogStatus.Pass, mensagem + image);
        }

        public void gravarLogFail(string mensagem)
        {
            gerarPrintScreen();
            test.Log(LogStatus.Fail, mensagem + image);
        }

        public void gravarLogInfo(string mensagem)
        {
            gerarPrintScreen();
            test.Log(LogStatus.Info, mensagem + image);

        }
    }
}
