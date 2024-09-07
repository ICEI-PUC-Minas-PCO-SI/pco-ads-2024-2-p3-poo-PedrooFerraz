using Aula_06_09.com.Pedro.Veiculos.Entidades.Carro.Picape;
using Aula_06_09.com.Pedro.Veiculos.Entidades.Carro.Sedan;
using Aula_06_09.com.Pedro.Veiculos.Entidades.Moto.Motocross;
using Aula_06_09.com.Pedro.Veiculos.Entidades.Moto.Scooter;
using Aula_06_09.com.Pedro.Veiculos.Entidades.Servicos;

namespace Aula_06_09
{

    public class Program
    {
        public static void Main(string[] args)
        {
            SeguroCarro seguroSedan = new SeguroCarro("Seguradora A", 2000.0);
            SeguroCarro seguroPicape = new SeguroCarro("Seguradora B", 3500.0);

            Sedan sedan = new("ABC-1234", "001122334455", seguroSedan, 4);
            Picape picape = new("DEF-5678", "667788990011", seguroPicape, 2);

            Motocross motocross = new("GHI-9101", "223344556677");
            Scooter scooter = new("JKL-1112", "889910101112");

            sedan.Mostrar();
            Console.WriteLine();

            picape.Mostrar();
            Console.WriteLine();

            motocross.Mostrar();
            Console.WriteLine();

            scooter.Mostrar();
        }
    }
}


