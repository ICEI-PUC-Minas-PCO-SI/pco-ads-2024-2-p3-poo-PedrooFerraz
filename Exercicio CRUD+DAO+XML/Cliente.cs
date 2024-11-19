using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CRUD_DAO_XML
{
    public class Cliente
    {
        private string _nome;
        private string _email;

        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }

        public Cliente() { }
        public Cliente(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

    }
}
