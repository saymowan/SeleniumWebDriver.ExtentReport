using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWebDriver.Basics
{
    //modificador de acesso public
    public class QuizStudentPageObjects : WebDriver
    {
        //Tela mapeada: https://testmoz.com/1

        //Método construtor para inicializar os elementos
        public QuizStudentPageObjects()
        {
            PageFactory.InitElements(WebDriver.driver, this);
        }

        /// <summary>
        /// Cada radiobutton tem um ID, agrupar por questão
        /// </summary>
        
        #region Question 1
        [FindsBy(How = How.Id, Using = "45_0")]
        public IWebElement question1Radio1 { get; set; }

        [FindsBy(How = How.Id, Using = "45_1")]
        public IWebElement question1Radio2 { get; set; }

        [FindsBy(How = How.Id, Using = "45_2")]
        public IWebElement question1Radio3 { get; set; }

        [FindsBy(How = How.Id, Using = "45_4")]
        public IWebElement question1Radio4 { get; set; }
        #endregion

        #region Question 2
        [FindsBy(How = How.Id, Using = "46_0")]
        public IWebElement question2Radio1 { get; set; }

        [FindsBy(How = How.Id, Using = "46_1")]
        public IWebElement question2Radio2 { get; set; }
        #endregion

        #region Question 3
        [FindsBy(How = How.Id, Using = "47_0")]
        public IWebElement question3Check1 { get; set; }

        [FindsBy(How = How.Id, Using = "47_1")]
        public IWebElement question3Check2 { get; set; }

        [FindsBy(How = How.Id, Using = "47_2")]
        public IWebElement question3Check3 { get; set; }

        [FindsBy(How = How.Id, Using = "47_3")]
        public IWebElement question3Check4 { get; set; }
        #endregion

        #region Question 4
        [FindsBy(How = How.Id, Using = "id_q-48")]
        public IWebElement question4Input { get; set; }
        #endregion


        //Mapeamento do botão da tela
        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement btnSubmit { get; set; }



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