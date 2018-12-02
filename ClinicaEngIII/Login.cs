using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Login
    {
        public string Nome { get => Nome; set => Nome = value; }
        public string Senha { get => Senha; set => Senha = value; }
        public Login(string nome, string senha)
        {
            this.Nome = nome;
            this.Senha = senha;
        }
    }
}
