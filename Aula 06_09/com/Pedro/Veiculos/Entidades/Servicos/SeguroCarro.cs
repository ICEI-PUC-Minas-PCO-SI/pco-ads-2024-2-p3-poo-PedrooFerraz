using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_09.com.Pedro.Veiculos.Entidades.Servicos
{
    public class SeguroCarro : Seguro
    {
        public string Empresa { get; private set; }
        public double Valor { get; private set; }

        public SeguroCarro(string empresa, double valor)
        {
            Empresa = empresa;
            Valor = valor;
        }

        public void SeguroParticular()
        {
            Console.WriteLine($"Seguro da empresa: {Empresa}. Valor: R${Valor}");
        }
    }
}
