using Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Triangulo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Classes_e_Métodos_Abstratos.Forms.Triangulo
{
    public partial class Triangulo : Form
    {
        public Triangulo()
        {
            InitializeComponent();
        }

        private void Area_Click(object sender, EventArgs e)
        {
            double baseTriangulo, altura, lado;

            if (double.TryParse(baseValue.Text, out baseTriangulo) && double.TryParse(alturaValue.Text, out altura) && double.TryParse(ladoValue.Text, out lado))
            {
                FormaTriangulo triangulo = new FormaTriangulo(baseTriangulo, altura, lado);
                double res = triangulo.CalcularArea();
                Result.Text = res.ToString();
                baseValue.Text = string.Empty;
                alturaValue.Text = string.Empty;
                ladoValue.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
        }

        private void Perimetro_Click(object sender, EventArgs e)
        {
            double baseTriangulo, altura, lado;

            if (double.TryParse(baseValue.Text, out baseTriangulo) && double.TryParse(alturaValue.Text, out altura) && double.TryParse(ladoValue.Text, out lado))
            {
                FormaTriangulo triangulo = new FormaTriangulo(baseTriangulo, altura, lado);
                double res = triangulo.CalcularPerimetro();
                Result.Text = res.ToString();
                baseValue.Text = string.Empty;
                alturaValue.Text = string.Empty;
                ladoValue.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            imagemForma.Image = Image.FromFile("C:\\Users\\Pedro Henrique\\source\\repos\\POO PUC\\Atividade Classes e Métodos Abstratos\\Atividade Classes e Métodos Abstratos\\Img\\Triangulo.png");
        }
    }
}
