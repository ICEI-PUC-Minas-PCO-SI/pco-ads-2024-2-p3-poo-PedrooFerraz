using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Octagono
{
    public class FormaOctagono : Forma
    {
        public double Lado { get; set; }

        public FormaOctagono(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return 2 * (1 + Math.Sqrt(2)) * Math.Pow(Lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 8 * Lado;
        }

    }
}
