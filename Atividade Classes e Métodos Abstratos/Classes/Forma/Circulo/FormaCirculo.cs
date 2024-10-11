using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Circulo
{
    public class FormaCirculo : Forma
    {
        public double Raio { get; set; }

        public FormaCirculo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

    }
}
