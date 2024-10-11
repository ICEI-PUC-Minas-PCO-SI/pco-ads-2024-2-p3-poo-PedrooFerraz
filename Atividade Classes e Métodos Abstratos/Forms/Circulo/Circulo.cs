using Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Circulo;
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
    public partial class Circulo : Form
    {
        public Circulo()
        {
            InitializeComponent();
        }

        private void Area_Click(object sender, EventArgs e)
        {
            double raio;

            if (double.TryParse(raioValue.Text, out raio))
            {
                FormaCirculo circulo = new FormaCirculo(raio);
                double res = circulo.CalcularArea();
                Result.Text = res.ToString();
                raioValue.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            imagemForma.Image = Image.FromFile("C:\\Users\\Pedro Henrique\\source\\repos\\POO PUC\\Atividade Classes e Métodos Abstratos\\Atividade Classes e Métodos Abstratos\\Img\\Circulo.png");
        }

        private void Perimetro_Click(object sender, EventArgs e)
        {
            double raio;

            if (double.TryParse(raioValue.Text, out raio))
            {
                FormaCirculo quadrado = new FormaCirculo(raio);
                double res = quadrado.CalcularPerimetro();
                Result.Text = res.ToString();
                raioValue.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }
    }
}
