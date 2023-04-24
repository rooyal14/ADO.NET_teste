using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    class Cliente
    {
        public string cpf;
        public string nome;
        public string senha;
        public string email;
        public string telefone;

        public Cliente(string cpf, string nome, string senha, string email, string telefone)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.senha = senha;
            this.email = email;
            this.telefone = telefone;
        }
    }
}
