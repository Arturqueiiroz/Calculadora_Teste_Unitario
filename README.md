# Calculadora — Testes Unitários

Projeto de uma calculadora simples desenvolvida em C# (.NET), com implementação de testes unitários utilizando xUnit. Desenvolvido no contexto acadêmico para a prática de testes automatizados e a aplicação de conceitos relacionados à qualidade de código.

## Visão Geral

Este projeto foi desenvolvido como parte de atividades acadêmicas com o objetivo de aplicar conceitos de testes unitários em C#.

A calculadora realiza operações com números inteiros e reais, oferecendo funcionalidades básicas de soma, subtração, multiplicação e divisão. Todas as operações são validadas por meio de testes automatizados.

## Funcionalidades

* **Operações matemáticas básicas:**

  * Soma de dois números;
  * Subtração de dois números;
  * Multiplicação de dois números;
  * Divisão de dois números.
* **Testes unitários:** testes para validar as operações da calculadora;
* **Validação de diferentes cenários:** testes envolvendo números positivos, negativos e zero.

## Estrutura do Projeto

```text
Calculadora_Teste_Unitario/
├── Calculadora/                  # Projeto principal da calculadora
│   ├── Calculadora.csproj        # Configuração do projeto (.NET 8.0)
│   └── Calculator.cs             # Classe Calculator com as operações
├── Calculadora.Test/             # Projeto de testes unitários
│   ├── Calculadora.Test.csproj   # Configuração do projeto de testes
│   └── CalculatorTest.cs         # Classe com os testes unitários
├── Calculadora.sln               # Solução do Visual Studio
├── .gitignore                    # Arquivo de configuração do Git
└── README.md                     # Documentação do projeto
```

## Tecnologias Utilizadas

* **C#:** linguagem de programação utilizada no desenvolvimento;
* **.NET 8.0:** plataforma utilizada para o desenvolvimento da aplicação;
* **xUnit:** framework utilizado para a implementação dos testes unitários;
* **coverlet.collector:** ferramenta utilizada para coleta de cobertura de código.

## Como Executar

### Pré-requisitos

* .NET 8.0 SDK instalado;
* Visual Studio 2022 ou VS Code com a extensão C#;
* Git para clonar o repositório.

### Passos

1. Clone o repositório:

   ```bash
   git clone https://github.com/Arturqueiiroz/Calculadora_Teste_Unitario.git
   cd Calculadora_Teste_Unitario
   ```

2. Restaure as dependências:

   ```bash
   dotnet restore
   ```

3. Compile o projeto:

   ```bash
   dotnet build
   ```

4. Execute os testes unitários:

   ```bash
   dotnet test
   ```

### Executar no Visual Studio

1. Abra o arquivo `Calculadora.sln` no Visual Studio;
2. Acesse o Gerenciador de Testes;
3. Execute os testes para validar as operações da calculadora.

## Contexto Acadêmico

Este projeto foi desenvolvido como parte de atividades acadêmicas, com foco na aplicação prática de conceitos relacionados ao desenvolvimento em C# e à realização de testes automatizados.

Durante o desenvolvimento, foram trabalhados os seguintes conhecimentos:

* Prática de desenvolvimento em C# e .NET;
* Implementação de testes unitários com xUnit;
* Aplicação de conceitos de testes automatizados;
* Validação da lógica da aplicação por meio de testes;
* Organização de projetos e separação entre código da aplicação e código de testes.

## Autor

**Artur Queiroz**

GitHub: [@Arturqueiiroz](https://github.com/Arturqueiiroz)

## Licença

Este projeto foi desenvolvido para fins acadêmicos e está disponível para estudo e contribuições.

---

*Projeto desenvolvido no contexto acadêmico para aprendizado e prática de testes unitários em C# e .NET.*
