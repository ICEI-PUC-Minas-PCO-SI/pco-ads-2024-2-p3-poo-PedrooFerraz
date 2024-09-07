using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_06_09.com.Pedro.Veiculos.Entidades.Servicos;

namespace Aula_06_09.com.Pedro.Veiculos.Entidades.Carro.Picape
{
    public class Picape : Carro
    {
        public Picape(string placa, string renavam, SeguroCarro seguro, int qtdPortas)
            : base(placa, renavam, seguro, qtdPortas) { }

        public override void Mostrar()
        {
            Console.WriteLine($"Carro: Placa - {Placa}, Renavam - {Renavam}, Quantidade Portas - {QtdPortas}");
            seguro.SeguroParticular();
        }
    }
}
