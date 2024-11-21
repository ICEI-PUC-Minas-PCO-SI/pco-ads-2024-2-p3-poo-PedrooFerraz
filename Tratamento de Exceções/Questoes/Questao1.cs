using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_de_Exceções.Questoes
{
    public static class Questao1
    {
        public static void Executar()
        {
            int number;

            while (true)
            {
                Console.Write("Digite um número inteiro: ");
                try
                {
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida! Por favor, insira um número inteiro.");
                }
            }

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} é um número primo.");
            }
            else
            {
                Console.WriteLine($"{number} não é um número primo.");
            }
        }


        public static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }


    }
}
