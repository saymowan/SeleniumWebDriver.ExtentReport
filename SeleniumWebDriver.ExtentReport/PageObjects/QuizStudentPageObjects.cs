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


        #region   Ações questão 1
        public void clicarQuestion1Radio1()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(question1Radio1);
                question1Radio1.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void


        public void clicarQuestion1Radio2()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(question1Radio2);
                question1Radio2.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void


        public void clicarQuestion1Radio3()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(question1Radio3);
                question1Radio3.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void


        public void clicarQuestion1Radio4()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(question1Radio4);
                question1Radio4.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void
        #endregion

        #region Ações questão 2
        public void clicarQuestion2Radio1()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(question2Radio1);
                question2Radio1.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void

        public void clicarQuestion2Radio2()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(question2Radio2);
                question2Radio2.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void
        #endregion

        #region Ações questão 3
        public void clicarQuestion3Check1()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(question3Check1);
                question3Check1.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void

        public void clicarQuestion3Check2()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(question3Check2);
                question3Check2.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void

        public void clicarQuestion3Check3()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(question3Check3);
                question3Check3.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void

        public void clicarQuestion3Check4()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(question3Check4);
                question3Check4.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void
        #endregion

        #region Ações questão 4
        public void preencherQuestion4Input(string valor)
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(question4Input);
                question4Input.Clear();
                question4Input.SendKeys(valor);
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void
        #endregion

        public void clicarSubmit()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(btnSubmit);
                btnSubmit.Click();
            }
            catch
            {
                Assert.Fail();
            }
        }//fim void
    }
}