using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_09.com.Pedro.Veiculos
{
    public class Veiculo
    {
        public string Placa { get; private set; }
        public string Renavam { get; private set; }

        public Veiculo(string placa, string renavam)
        {
            Placa = placa;
            Renavam = renavam;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Veículo: Placa: {Placa}, Renavam: {Renavam}");
        }
    }
}