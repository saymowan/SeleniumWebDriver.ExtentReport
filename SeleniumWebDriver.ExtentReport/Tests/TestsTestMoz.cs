using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumWebDriver.Basics
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
            StudentLoginPageObjects studentLogin = new StudentLoginPageObjects();

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
            StudentLoginPageObjects login = new StudentLoginPageObjects();
            login.preencherName("Teste Preencher Quiz");
            login.clicarContinue();

            Thread.Sleep(100);
            //Escolher valores nas perguntas - página QUIZ
            QuizStudentPageObjects quiz = new QuizStudentPageObjects();
            quiz.clicarQuestion1Radio1();
            quiz.clicarQuestion2Radio2();
            quiz.clicarQuestion3Check2();
            quiz.clicarQuestion3Check4();
            quiz.preencherQuestion4Input("URL");

            quiz.clicarSubmit();
            Assert.AreEqual("Congrats. You're done. When you're done viewing this page, don't click the logout button. Click here instead to head back to the homepage.", driver.FindElement(By.Id("conclusion")).Text);

        }//fim test
    }//fim class
}//fim namespace