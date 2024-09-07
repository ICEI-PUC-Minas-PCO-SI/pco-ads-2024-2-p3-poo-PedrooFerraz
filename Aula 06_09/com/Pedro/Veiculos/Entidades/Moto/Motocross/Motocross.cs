using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_09.com.Pedro.Veiculos.Entidades.Moto.Motocross
{
    public class Motocross : Moto
    {
        public Motocross(string placa, string renavam)
            : base(placa, renavam) { }

        public override void Mostrar()
        {
            Console.WriteLine($"Motocross: Placa - {Placa}, Renavam - {Renavam}");
        }
    }

}
