using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercicio_CRUD_DAO_XML
{
    internal class ClienteDAO
    {
        private List<Cliente> clientes;

        public ClienteDAO()
        {
            this.clientes = new List<Cliente>();
        }

        //Operações em Memória Primária
        public void Adicionar(Cliente cliente)
        {
            this.clientes.Add(cliente);
        }
        public void Remover(int index)
        {
            this.clientes.RemoveAt(index);
        }
        public List<Cliente> GetClientes()
        {
            return this.clientes;
        }

        public void Alterar(Cliente clienteAtualizado, int index)
        {
            clientes[index] = clienteAtualizado;
        }

        //Operações em Memória Secundária (Persistência)

        public void Salvar()
        {
            // chamar bib xml.serializer
            XmlSerializer ser = new XmlSerializer(typeof(List<Cliente>));
            FileStream fs = new FileStream("C:\\Users\\Public\\temp\\Clientes.xml", FileMode.Create);

            ser.Serialize(fs, this.clientes);
            fs.Close();
        }

        public void Carregar()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Cliente>));
            FileStream fs = new FileStream("C:\\Users\\Public\\temp\\Clientes.xml", FileMode.Open);

            try
            {
                this.clientes = ser.Deserialize(fs) as List<Cliente>;
            }
            catch (InvalidOperationException ex)
            {
                ser.Serialize(fs, this.clientes);
            }
            finally 
            { 
                fs.Close(); 
            }

        }


    }
}
