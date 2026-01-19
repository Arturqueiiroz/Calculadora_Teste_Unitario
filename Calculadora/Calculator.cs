namespace Calculadora
{
    public class Calculator
    {
        // Método para efetuar a soma de dois números inteiros
        public static int Sum(int primeiroNumero, int segundoNumero)
        {
            // Condição para verificar se os números são positivos
            if (primeiroNumero <0 || segundoNumero <0)
            {
                return -1;
            }
            // Retorna a soma de ambos os valores inteiros
            return primeiroNumero + segundoNumero;
        }

    }
}