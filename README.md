# Calculadora - Teste Unitario

Projeto de uma calculadora simples desenvolvida em C# (.NET) com implementacao de testes unitarios utilizando xUnit. Desenvolvido no contexto academico para pratica de testes automatizados e garantia de qualidade de codigo.

## Visao Geral

Este projeto foi desenvolvido como parte de atividades academicas com o objetivo de aplicar conceitos de teste unitario em C#. A calculadora opera com numeros inteiros e reais, oferecendo operacoes basicas de soma, subtracao, multiplicacao e divisao, todas validadas por meio de testes automatizados.

## Funcionalidades

- **Operacoes matematicas basicas**:
  - Soma de dois numeros;
  - Subtracao de dois numeros;
  - Multiplicacao de dois numeros;
  - Divisao de dois numeros.
- **Testes unitarios**: cobertura de testes para todas as operacoes da calculadora;
- **Validacao de casos de teste**: incluindo testes para operacoes com numeros positivos, negativos e zero.

## Estrutura do Projeto

```
Calculadora_Teste_Unitario/
├── Calculadora/              # Projeto principal da calculadora
│   ├── Calculadora.csproj    # Configuracao do projeto (.NET 8.0)
│   └── Calculator.cs         # Classe Calculator com as operacoes
├── Calculadora.Test/         # Projeto de testes unitarios
│   ├── Calculadora.Test.csproj  # Configuracao dos testes (xUnit)
│   └── CalculatorTest.cs     # Classe de testes com os casos de teste
├── Calculadora.sln           # Solucao do Visual Studio
├── .gitignore                # Arquivo de ignoracao do Git
└── README.md                 # Documentacao do projeto
```

## Tecnologias Utilizadas

- **C#**: linguagem de programacao;
- **.NET 8.0**: framework de desenvolvimento;
- **xUnit**: framework de testes unitarios;
- **FluentAssertions** (opcional): biblioteca para assertions mais legiveis nos testes;
- **coverlet.collector**: coleta de cobertura de codigo.

## Como Executar

### Pre-requisitos

- .NET 8.0 SDK instalado;
- Visual Studio 2022 ou VS Code com extensao C#;
- Git para clonar o repositorio.

### Passos

1. Clone o repositorio:
   ```bash
   git clone https://github.com/Arturqueiiroz/Calculadora_Teste_Unitario.git
   cd Calculadora_Teste_Unitario
   ```

2. Restaure as dependencias:
   ```bash
   dotnet restore
   ```

3. Compile o projeto:
   ```bash
   dotnet build
   ```

4. Execute os testes unitarios:
   ```bash
   dotnet test
   ```

### Executar no Visual Studio

1. Abra o arquivo `Calculadora.sln` no Visual Studio;
2. No Gerenciador de Testes, execute todos os testes para validar as operacoes.

## Contexto Academico

Este projeto foi desenvolvido como parte de atividades academicas, com foco em:

- Pratica de desenvolvimento em C# e .NET;
- Implementacao de testes unitarios com xUnit;
- Aplicacao de boas praticas de teste automatizado;
- Validacao de logica de programa com cobertura de testes.

## Autor

**Artur Queiroz**  
GitHub: [@Arturqueiiroz](https://github.com/Arturqueiiroz)

## Licenca

Este projeto foi desenvolvido para fins academicos e esta disponivel para estudo e contribuicoes.

---

*Projeto desenvolvido no contexto academico para aprendizado e pratica de testes unitarios em C#.*
