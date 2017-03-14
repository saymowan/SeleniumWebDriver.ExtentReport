using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumWebDriver.ExtentReport.SeleniumUteis;
using System.Threading;

namespace SeleniumWebDriver.ExtentReport
{
    //Modificar de acesso public
    public class Tests : WebDriver
    {

        /// <summary>
        /// Método de teste usa decoração [Test]: após build será exibido no menu "Test Explorer"
        /// Todo método de teste tem um assert para validar o resultado esperado
        /// </summary>
        [Test]
        public void acessarTestMoz()
        {
            Assert.AreEqual("Testmoz Test", driver.Title);
        }


        /// <summary>
        /// Método de teste que insere nome, clica no botão e acessa a página de Quiz
        /// Inclui métodos provenientes de classes PageObject com tratamento de exceções
        /// </summary>
        [Test]
        public void acessarQuizTestMoz()
        {
            StudentLoginPageObjects studentLogin = new StudentLoginPageObjects(Relatorio);

            //Inserir um valor em campo inpuut: limpe o campo e envie a string/valor
            studentLogin.preencherName("Nome teste quiz");

            //Após inserir as informações clicar no botão para continuar
            studentLogin.clicarContinue();

            //Validar que avançou para a próxima página
            //Utilize algum elemento ou frase da página
            Assert.AreEqual("This quiz determines if you know anything about Testmoz.", driver.FindElement(By.Id("introduction")).Text);
        }

        /// <summary>
        /// Método de teste para inserir valores na tela Quiz e avançar
        /// </summary>
        [Test]
        public void preencherQuiz()
        {
            //Iniciar a gravação no relatório
            Relatorio.iniciarTeste("Teste preenchimento de quiz");

            StudentLoginPageObjects login = new StudentLoginPageObjects(Relatorio);
            login.preencherName("Teste Preencher Quiz");
            login.clicarContinue();

            Thread.Sleep(100);
            //Escolher valores nas perguntas - página QUIZ
            QuizStudentPageObjects quiz = new QuizStudentPageObjects(Relatorio);
            quiz.clicarQuestion1Radio1();
            quiz.clicarQuestion2Radio2();
            quiz.clicarQuestion3Check2();
            quiz.clicarQuestion3Check4();
            quiz.preencherQuestion4Input("URL");

            quiz.clicarSubmit();

            QuizResultPageObjects quizResult = new QuizResultPageObjects(Relatorio);
            quizResult.validaQuizResult();
          
        }//fim test





    }//fim class
}//fim namespace