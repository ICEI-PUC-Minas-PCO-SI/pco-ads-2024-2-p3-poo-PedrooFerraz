using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_de_Exceções.Questoes
{
    public static class Questao3
    {

        public static void Executar()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }

            Console.WriteLine("Você pode inserir valores no vetor de 10 posições.");
            Console.WriteLine("Digite os valores e as posições (0 a 9).");

            while (true)
            {
                try
                {
                    Console.Write("Digite o valor (ou 'sair' para encerrar): ");
                    string input = Console.ReadLine();
                    if (input.ToLower() == "sair")
                        break;

                    int value = int.Parse(input);

                    Console.Write("Digite a posição (0 a 9): ");
                    int position = int.Parse(Console.ReadLine());

                    array[position] = value;
                    Console.WriteLine($"Valor {value} adicionado na posição {position}.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida! Certifique-se de digitar números inteiros.");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Posição inválida! Escolha uma posição entre 0 e 9.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                }
            }

            Console.WriteLine("\nEstado final do vetor:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Posição {i}: {array[i]}");
            }
        }
    }
}
