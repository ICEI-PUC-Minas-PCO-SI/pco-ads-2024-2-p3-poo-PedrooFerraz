using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_de_Exceções.Questoes
{
    public static class Questao2
    {
        public static void Executar()
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Escolha uma operação: +, -, *, /, %");
                char operation = Console.ReadLine()[0];

                double result = MathOperations(num1, num2, operation);
                Console.WriteLine($"O resultado é: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida! Por favor, insira números válidos.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
        public static double MathOperations(double num1, double num2, char operation)
        {
            return operation switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '*' => num1 * num2,
                '/' => num1 / num2,
                '%' => num1 % num2,
                _ => throw new InvalidOperationException("Operação inválida!")
            };
        }

    }
}
