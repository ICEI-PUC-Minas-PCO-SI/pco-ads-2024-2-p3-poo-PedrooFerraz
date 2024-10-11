using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Triangulo
{
    public class FormaTriangulo : Forma
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado { get; set; }

        public FormaTriangulo(double baseTriangulo, double altura, double lado)
        {
            Base = baseTriangulo;
            Altura = altura;
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 3 * Lado;
        }
    }
}
