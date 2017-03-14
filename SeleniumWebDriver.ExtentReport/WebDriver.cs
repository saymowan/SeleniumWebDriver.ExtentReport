using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using SeleniumWebDriver.ExtentReport.SeleniumUteis;

namespace SeleniumWebDriver.ExtentReport
{
    //Modificador de acesso public
    public class WebDriver
    {

        //variável global referente ao driver (navegador)
        public static IWebDriver driver { get; set; }

        //variável global que será usada em todas as classes PageObject
        public Relatorio Relatorio { get; protected set; }


        /// <summary>
        /// Construtor de classe com instanciação do objeto do relatório
        /// </summary>
        public WebDriver()
        {
            Relatorio = new Relatorio();
        }


        //decoração simbolizando método que executa antes de iniciar o teste
        [SetUp]
        public void SetUp()
        {
            //Método responsável para criar o log de relatórios antes de iniciar o teste
            Relatorio.criarArquivoLog();

            //ChromeDriver: nativo do selenium, usar path para o driver
            //Criei um método que retorna o path do driver: SeleniumUteis.SeleniumUteis.getPathSeleniumDriver
            driver = new ChromeDriver(SeleniumUteis.SeleniumUteis.getPathSeleniumDriver());

            //Ação que navega para o site
            driver.Navigate().GoToUrl(SeleniumConstantes.urlBase);

            //Ação que maximiza a tela
            driver.Manage().Window.Maximize();
        }

        //decoração simbolizando método que serpa executado depois que o teste finalizar
        //Método que analisa o resultado do teste e grava um log final
        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Success))
            {
                logSucessoEAddPrint(true); //(Esse metodo deve gravar log de sucesso e adicionar um print, coloquei um parametro bool e um if dentro dele pra gravar falha tbm...)
            }
            else
            {
                logSucessoEAddPrint(false);
            }
            Relatorio.report.Flush();
            driver.Quit();
        }

        /// <summary>
        /// Método executado ao finalizar o teste para informar sucesso/falha
        /// </summary>
        /// <param name="aux"></param>
        public void logSucessoEAddPrint(bool aux)
        {
            Relatorio.report.EndTest(Relatorio.test);
            if (aux == true)
            {
                Relatorio.test.Log(LogStatus.Pass, "Teste executado com sucesso!");
            }

            else
            {
                Relatorio.test.Log(LogStatus.Fail, "Teste com falha, favor verificar a evidência do teste.");
            } // fim if



        }
    }
}