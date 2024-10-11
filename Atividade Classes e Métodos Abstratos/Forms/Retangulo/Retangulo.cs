using Atividade_Classes_e_Métodos_Abstratos.Classes.Forma.Retangulo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Classes_e_Métodos_Abstratos.Forms.Pentagono
{
    public partial class Retangulo : Form
    {
        public Retangulo()
        {
            InitializeComponent();
        }

        private void Area_Click(object sender, EventArgs e)
        {
            double altura, largura;

            if (double.TryParse(alturaValue.Text, out altura) && double.TryParse(larguraValue.Text, out largura))
            {
                FormaRetangulo retangulo = new FormaRetangulo(altura, largura);
                double res = retangulo.CalcularArea();
                Result.Text = res.ToString();
                alturaValue.Text = string.Empty;
                larguraValue.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
        }

        private void Perimetro_Click(object sender, EventArgs e)
        {
            double altura, largura;

            if (double.TryParse(alturaValue.Text, out altura) && double.TryParse(larguraValue.Text, out largura))
            {
                FormaRetangulo retangulo = new FormaRetangulo(altura, largura);
                double res = retangulo.CalcularPerimetro();
                Result.Text = res.ToString();
                alturaValue.Text = string.Empty;
                larguraValue.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            imagemForma.Image = Image.FromFile("C:\\Users\\Pedro Henrique\\source\\repos\\POO PUC\\Atividade Classes e Métodos Abstratos\\Atividade Classes e Métodos Abstratos\\Img\\Retangulo.png");
        }
    }
}
