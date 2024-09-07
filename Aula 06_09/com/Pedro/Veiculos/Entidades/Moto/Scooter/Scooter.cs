using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_09.com.Pedro.Veiculos.Entidades.Moto.Scooter
{
    public class Scooter : Moto
    {
        public Scooter(string placa, string renavam)
            : base(placa, renavam) { }

        public override void Mostrar()
        {
            Console.WriteLine($"Scooter: Placa: {Placa}, Renavam: {Renavam}");
        }
    }
}
