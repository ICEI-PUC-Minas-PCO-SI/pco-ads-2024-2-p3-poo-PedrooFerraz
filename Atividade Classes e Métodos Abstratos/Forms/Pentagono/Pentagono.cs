using Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Pentagono;
using Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Quadrado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Classes_e_Métodos_Abstratos.Forms.Octagono
{
    public partial class Pentagono : Form
    {
        public Pentagono()
        {
            InitializeComponent();
        }

        private void Area_Click(object sender, EventArgs e)
        {
            double lado;

            if (double.TryParse(ladoValue.Text, out lado))
            {
                FormaPentagono pentagono = new FormaPentagono(lado);
                double res = pentagono.CalcularArea();
                Result.Text = res.ToString();
                ladoValue.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }

        private void Perimetro_Click(object sender, EventArgs e)
        {
            double lado;

            if (double.TryParse(ladoValue.Text, out lado))
            {
                FormaPentagono pentagono = new FormaPentagono(lado);
                double res = pentagono.CalcularPerimetro();
                Result.Text = res.ToString();
                ladoValue.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            imagemForma.Image = Image.FromFile("C:\\Users\\Pedro Henrique\\source\\repos\\POO PUC\\Atividade Classes e Métodos Abstratos\\Atividade Classes e Métodos Abstratos\\Img\\Pentagono.png");
        }
    }
}
