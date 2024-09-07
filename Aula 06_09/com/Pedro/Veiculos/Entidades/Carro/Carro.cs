using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Aula_06_09.com.Pedro.Veiculos;
using Aula_06_09.com.Pedro.Veiculos.Entidades.Servicos;

namespace Aula_06_09.com.Pedro.Veiculos.Entidades.Carro
{
    public class Carro : Veiculo
    {
        protected SeguroCarro seguro;
        protected int QtdPortas;
        public Carro(string placa, string renavam, SeguroCarro seguro, int qtdPortas)
            : base(placa, renavam)
        {
            this.seguro = seguro;
            QtdPortas = qtdPortas;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Carro: Placa - {Placa}, Renavam - {Renavam}, Quantidade Portas - {QtdPortas}");
            seguro.SeguroParticular();
        }
    }
}
