using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebDriver.Basics
{
    //modificador de acesso public
    public class StudentLoginPageObjects : WebDriver
    {
        //Tela mapeada: https://testmoz.com/1

        //Método construtor para inicializar os elementos
        public StudentLoginPageObjects()
        {
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
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void



        public void clicarContinue()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(btnContinue);
                btnContinue.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void


    }
}