using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Pentagono
{
    public class FormaPentagono : Forma
    {
        public double Lado { get; set; }

        public FormaPentagono(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return (5 * Math.Pow(Lado, 2)) / (4 * Math.Tan(Math.PI / 5));
        }

        public override double CalcularPerimetro()
        {
            return 5 * Lado;
        }
    }
}
