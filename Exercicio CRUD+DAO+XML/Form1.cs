using System.Collections;
using System.Windows.Forms;

namespace Exercicio_CRUD_DAO_XML
{
    public partial class Form1 : Form
    {
        private ClienteDAO clienteDAO;
        private bool isEditing = false;
        public Form1()
        {
            InitializeComponent();

            gridView.CellEndEdit += DataGridView1_CellEndEdit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clienteDAO = new ClienteDAO();
            clienteDAO.Carregar();
            gridView.DataSource = clienteDAO.GetClientes();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            cli.Nome = nameInput.Text;
            cli.Email = emailInput.Text;

            clienteDAO.Adicionar(cli);
            clienteDAO.Salvar();

            gridView.DataSource = null;
            gridView.DataSource = clienteDAO.GetClientes();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            clienteDAO.Remover(gridView.CurrentRow.Index);

            clienteDAO.Salvar();

            gridView.DataSource = null;
            gridView.DataSource = clienteDAO.GetClientes();

        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (isEditing) return;
            isEditing = true;

            string nome = gridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            string email = gridView.Rows[e.RowIndex].Cells[1].Value.ToString();

            Cliente clienteEditado = new Cliente(nome, email);

            clienteDAO.Alterar(clienteEditado, e.RowIndex);

            clienteDAO.Salvar();

            gridView.DataSource = null;
            gridView.DataSource = clienteDAO.GetClientes();

        }
    }
}
