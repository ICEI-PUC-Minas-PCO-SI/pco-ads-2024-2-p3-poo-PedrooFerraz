using Atividade_Classes_e_Métodos_Abstratos.Forms;
using Atividade_Classes_e_Métodos_Abstratos.Forms.Circulo;
using Atividade_Classes_e_Métodos_Abstratos.Forms.Octagono;
using Atividade_Classes_e_Métodos_Abstratos.Forms.Pentagono;
using Atividade_Classes_e_Métodos_Abstratos.Forms.Triangulo;

namespace Atividade_Classes_e_Métodos_Abstratos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadrado quadradoForm = new Quadrado();
            quadradoForm.ShowDialog();
        }

        private void círculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo();
            circulo.ShowDialog();
        }

        private void triânguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.ShowDialog();
        }

        private void hexágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hexagono hexagono = new Hexagono();
            hexagono.ShowDialog();
        }

        private void octágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Octagono octagono = new Octagono();
            octagono.ShowDialog();
        }

        private void pentágonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pentagono pentagono = new Pentagono();
            pentagono.ShowDialog();
        }

        private void retanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Retangulo retangulo = new Retangulo();
            retangulo.ShowDialog();
        }
    }
}
