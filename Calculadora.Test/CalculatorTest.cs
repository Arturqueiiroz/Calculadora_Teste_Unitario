namespace Calculadora.Test
{
    public class CalculatorTest
    {
        // Teste unitário para o método Sum da classe Calculator
        // Usando o framework XUnit.

        // O atributo [Fact] indica que este é um método de teste unitário.
        [Fact(DisplayName = "Dados numero validos, quando ha soma, retorna sucesso")]

        // Métod convencional GWT
        // G = Given: Dados/Entregue
        // W = When: Quando
        // T = Then: Então

        public void DadosNumerosValidos_QuandoSoma_RetornaSucesso()
        {
            // Arrange: Configuração dos dados de entrada e do resultado esperado
            int primeiroNumero = 5;
            int segundoNumero = 10;
            int resultadoEsperado = 15;

            // Act: Ação, chamada do método que está sendo testado.
            int resultadoAtual = Calculator.Sum(primeiroNumero, segundoNumero);

            // Assert: Verificação se o resultado atual é ingual ao resultado esperado. 
            Assert.Equal(resultadoEsperado, resultadoAtual);


        }
    }
}
