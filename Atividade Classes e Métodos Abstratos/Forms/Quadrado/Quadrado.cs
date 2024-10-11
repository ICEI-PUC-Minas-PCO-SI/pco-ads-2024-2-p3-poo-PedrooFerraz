using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Quadrado;

namespace Atividade_Classes_e_Métodos_Abstratos.Forms
{
    public partial class Quadrado : Form
    {

        public Quadrado()
        {
            InitializeComponent();
        }

        private void Area_Click(object sender, EventArgs e)
        {
            double lado;

            if (double.TryParse(ladoValue.Text, out lado))
            {
                FormaQuadrado quadrado = new FormaQuadrado(lado);
                double res = quadrado.CalcularArea();
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
            imagemForma.Image = Image.FromFile("C:\\Users\\Pedro Henrique\\source\\repos\\POO PUC\\Atividade Classes e Métodos Abstratos\\Atividade Classes e Métodos Abstratos\\Img\\Quadrado.png");
        }

        private void Perimetro_Click(object sender, EventArgs e)
        {
            double lado;

            if (double.TryParse(ladoValue.Text, out lado))
            {
                FormaQuadrado quadrado = new FormaQuadrado(lado);
                double res = quadrado.CalcularPerimetro();
                Result.Text = res.ToString();
                ladoValue.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        
        }
    }
    }

