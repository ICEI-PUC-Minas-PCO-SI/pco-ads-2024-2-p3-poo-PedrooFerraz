
using Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Hexagono;
using Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Octagono;
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
    public partial class Octagono : Form
    {
        public Octagono()
        {
            InitializeComponent();
        }

        private void Area_Click(object sender, EventArgs e)
        {
            double lado;

            if (double.TryParse(ladoValue.Text, out lado))
            {
                FormaOctagono octagono = new FormaOctagono(lado);
                double res = octagono.CalcularArea();
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
                FormaOctagono octagono = new FormaOctagono(lado);
                double res = octagono.CalcularPerimetro();
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
            imagemForma.Image = Image.FromFile("C:\\Users\\Pedro Henrique\\source\\repos\\POO PUC\\Atividade Classes e Métodos Abstratos\\Atividade Classes e Métodos Abstratos\\Img\\Octagono.png");
        }
    }
}
