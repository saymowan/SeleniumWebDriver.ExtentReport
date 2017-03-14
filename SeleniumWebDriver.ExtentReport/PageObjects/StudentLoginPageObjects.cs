using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriver.ExtentReport;
using SeleniumWebDriver.ExtentReport.SeleniumUteis;

namespace SeleniumWebDriver.ExtentReport
{
    //modificador de acesso public
    public class StudentLoginPageObjects : WebDriver
    {
        //Tela mapeada: https://testmoz.com/1
        /// <summary>
        ///  Método construtor para inicializar os elementos
        ///  Parâmetro enviado:  relatorio
        ///  Motivo do parâmetro: utilizar o mesmo objeto em todas as classes para gravar no relatório
        ///  Variável dentro do construtor
        /// </summary>

        public StudentLoginPageObjects(Relatorio relatorio)
        {
            Relatorio = relatorio;
            PageFactory.InitElements(WebDriver.driver, this);
        }

        /// <summary>
        /// Método para mapear um elemento
        /// How: indica o tipo de elemento conforme encontrado na página web
        /// Using: o valor do elemento na tela
        /// IWebElement: elemento novo criado a partir de um mapeamento na tela
        /// </summary>
        [FindsBy(How = How.Id, Using = "id_student-name")]
        public IWebElement inputYourName { get; set; }

        //Mapeamento do botão da tela
        [FindsBy(How = How.Name, Using = "student")]
        public IWebElement btnContinue { get; set; }



        /// <summary>
        /// Método para inserir informação em campo
        /// Tenta esoerar o elemento na tela
        /// Limpa o campo
        /// Envia informação
        /// ERRO: não conseguiu fazer alguma das ações anteriores, o teste irá resultar em erro
        /// </summary>
        public void preencherName(string YourName)
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(inputYourName);
                inputYourName.Clear();
                inputYourName.SendKeys(YourName);
                Relatorio.gravarLogPass("Campo YourName preenchido.");
            }
            catch
            {
                Relatorio.gravarLogFail("Não foi possível preencher o campo YourName.");
                Assert.Fail();
            }
        }//fim void



        public void clicarContinue()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(btnContinue);
                btnContinue.Click();
                Relatorio.gravarLogPass("Botão Continue clicado.");
            }
            catch
            {
                Relatorio.gravarLogFail("Não foi possível clicar no botão.");
                Assert.Fail();
            }
        }//fim void


    }
}