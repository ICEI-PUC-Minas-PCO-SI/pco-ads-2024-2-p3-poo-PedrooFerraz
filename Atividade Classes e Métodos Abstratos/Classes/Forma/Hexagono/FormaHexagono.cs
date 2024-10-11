using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Hexagono
{
    public class FormaHexagono : Forma
    {
        public double Lado { get; set; }

        public FormaHexagono(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return (3 * Math.Sqrt(3) * Math.Pow(Lado, 2)) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 6 * Lado;
        }
    }
}
