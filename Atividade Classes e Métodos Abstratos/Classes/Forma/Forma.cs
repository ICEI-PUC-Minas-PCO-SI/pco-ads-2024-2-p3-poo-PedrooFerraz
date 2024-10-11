using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Classes_e_Métodos_Abstratos.Classes.Forma
{
    public abstract class Forma
    {
             public abstract double CalcularArea();
             public abstract double CalcularPerimetro();
             public virtual void Mostrar() {}
    }
}
