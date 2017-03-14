using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumWebDriver.ExtentReport.SeleniumUteis;

namespace SeleniumWebDriver.ExtentReport
{
    public class QuizResultPageObjects : WebDriver
    {

        public QuizResultPageObjects(Relatorio relatorio)
        {
            Relatorio = relatorio;
            PageFactory.InitElements(WebDriver.driver, this);
        }

        [FindsBy(How = How.Id, Using = "conclusion")]
        public IWebElement resultQuizResult { get; set; }

        string mensagemQuizResult = "Congrats. You're done. When you're done viewing this page, don't click the logout button. Click here instead to head back to the homepage.";

        public void validaQuizResult()
        {
            try
            {
                SeleniumUteis.SeleniumUteis.esperarElemento(resultQuizResult);
                Assert.AreEqual(mensagemQuizResult, resultQuizResult.Text);
                Relatorio.gravarLogPass("Acesso á página QuizResult validado com sucesso.");
            }
            catch
            {
                Relatorio.gravarLogFail("Não foi possível validar o acesso á página QuizResult.");
                Assert.Fail();
            }


        }

    }
}
