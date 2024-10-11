using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Quadrado
{
    public class FormaQuadrado : Forma
    {

        public double Lado { get; set; }

        public FormaQuadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }

        public override void Mostrar()
        {

        }

    }
}
