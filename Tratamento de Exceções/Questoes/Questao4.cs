using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_de_Exceções.Questoes
{
    public static class Questao4
    {
        class ExcecaoAcimaDeCem : Exception
        {
            public ExcecaoAcimaDeCem(string mensagem) : base(mensagem) { }
        }

        public static void SomarNumeros()
        {
            int soma = 0;
            int quantidade = 0;

            Console.WriteLine("Digite números inteiros. A soma será interrompida ao ultrapassar 100.");
            Console.WriteLine("Digite 'sair' para encerrar.");

            while (true)
            {
                Console.Write("Digite um número: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "sair")
                {
                    break;
                }

                int numero = int.Parse(input);

                soma += numero;
                quantidade++;

                if (soma > 100)
                {
                    throw new ExcecaoAcimaDeCem("A soma dos números ultrapassou 100.");
                }
            }

            double media = quantidade > 0 ? (double)soma / quantidade : 0;
            Console.WriteLine($"\nSoma total: {soma}");
            Console.WriteLine($"Quantidade de números somados: {quantidade}");
            Console.WriteLine($"Média: {media:F2}");
        }

        public static void Executar()
        {
            try
            {
                SomarNumeros();
            }
            catch (ExcecaoAcimaDeCem ex)
            {
                Console.WriteLine($"\nExceção: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nErro: Entrada inválida. Por favor, insira apenas números inteiros.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro inesperado: {ex.Message}");
            }
        }

    }
}
