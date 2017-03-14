# SeleniumWebDriver.ExtentReport

Projeto criado para estudos nível intermediário

Dificuldade: intermediária

Tecnologias escolhidas:
- Linguagem C#
- Framework .NET
- Framework de testes automatizados: Selenium WebDriver
- Framework de testes automatizados: NUnit
- Padrão de escrita de código de testes: PageObjects
- Padrão de melhorias em ações com try catch
- Framework de report de execução de testes: ExtentReport

### Arquitetura do projeto:

- Classe filha -> Classe mãe herdada
- Classe de Teste -> WebDriver
- Classe de PageObject -> WebDriver
- Classe Selenium Uteis: métodos genéricos
- Classe Selenium Constantes: parâmetros do projeto

### Features:

Melhorias e boas práticas

Criação de métodos genéricos de ação em classes PageObjects

Tratamento de exceções ao navegar ou realizar alguma ação na página web

Inclusão do relatório de execução de testes com evidências passo a passo

### Pré-requisitos:

- Para evitar problemas de exibição dos testes na tela Test Explorer pós build, instale o NuGet: NUnit3TestAdapter
- Crie no diretório físico "C" a pasta "LogsSelenium" e as subpastas "Log" e "Printscreen"

**************************
### Passo a passo do projeto
**************************
### 1. PageObjects: 
* Foi criado uma pasta para armazenar todas as classes que fazem referência á pageobjects

### 2. Tests
* Foi criado uma pasta para armazenar todas as classes de testes

### 3. Classe Tests - Criação de métodos para ações
* Toda ação, navegação no sistema terá um método vinculado dentro da classe PageObject para tratamento de exceções
* Try catch utilizado para tratar exceções

### 4. Criação de um novo teste
* Foi criado um mapeamento de pageobjects na tela Quiz.
* Foi criado um novo teste para clicar em radio buttons, checkbox e enviar um input na tela de quiz.

### 5. Inclusão do ExtentReport para relatório de execução de testes
* Criação da classe Relatorio.cs e métodos de ação do relatório
* Inclusão do Nuget: ExtentReport (versão 2.41)

Na classe WebDriver.cs incluir informações do relatório:
* Criação do construtor
* Criação de método de log e print final

Na classe PageObjects.cs:
* Camada PageObjects recebe o parâmetro do relatório no construtor.
* Ao instanciar uma classe PageObjects será necessário passar "Relatório como parâmetro"
* Todos os métodos que tem Try catch irão representar um step, assim implementada a gravação de sucesso/falha

Nos métodos de teste:
* Chamar método para iniciar a gravação no relatório
* Toda a configuração de relatório fica fora dos métodos de teste, por isso não é vísivel nenhuma mudança.

### Exemplo de relatório de execução de testes:
Abaixo uma imagem de exemplo do relatório emitido pelo ExtentReport:
[![ExtentReport](http://i.imgur.com/iAstOMp.png)](http://extentreports.com/)

***
### Melhorias futuras:
* Arquivo de configuração e customização do ExtentReport conforme seu projeto.
* Método para validar se o diretório do relatório já está criado.
* DDT
* Banco de dados
* Trabalhando com ID Dinâmicos

