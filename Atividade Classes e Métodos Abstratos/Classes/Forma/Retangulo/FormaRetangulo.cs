using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Retangulo
{
    public class FormaRetangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public FormaRetangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Largura * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }

        public override void Mostrar()
        {

        }

    }
}
