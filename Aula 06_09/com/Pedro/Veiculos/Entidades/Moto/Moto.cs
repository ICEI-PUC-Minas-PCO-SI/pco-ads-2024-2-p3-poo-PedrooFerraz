using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_06_09.com.Pedro.Veiculos;

namespace Aula_06_09.com.Pedro.Veiculos.Entidades.Moto
{
    public class Moto : Veiculo
    {
        public Moto(string placa, string renavam)
            : base(placa, renavam) { }

        public override void Mostrar()
        {
            Console.WriteLine($"Moto: Placa - {Placa}, Renavam - {Renavam}");
        }
    }
}
