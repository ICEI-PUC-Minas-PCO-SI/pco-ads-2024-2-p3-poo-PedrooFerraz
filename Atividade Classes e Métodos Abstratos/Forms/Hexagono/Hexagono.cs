using Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Hexagono;
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

namespace Atividade_Classes_e_Métodos_Abstratos.Forms.Circulo
{
    public partial class Hexagono : Form
    {
        public Hexagono()
        {
            InitializeComponent();
        }

        private void Area_Click(object sender, EventArgs e)
        {
            double lado;

            if (double.TryParse(ladoValue.Text, out lado))
            {
                FormaHexagono hexagono = new FormaHexagono(lado);
                double res = hexagono.CalcularArea();
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
                FormaHexagono hexagono = new FormaHexagono(lado);
                double res = hexagono.CalcularPerimetro();
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
            imagemForma.Image = Image.FromFile("C:\\Users\\Pedro Henrique\\source\\repos\\POO PUC\\Atividade Classes e Métodos Abstratos\\Atividade Classes e Métodos Abstratos\\Img\\Hexagono.png");
        }
    }
}
