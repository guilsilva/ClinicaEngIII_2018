using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Usuario
    {
        public Usuario(){}
        public Usuario(string nome, string cpf, string end, int idade, string sexo, string tel)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = end;
            this.Idade = idade;
            this.Sexo = sexo;
            this.Telefone = tel;
        }
        public string Cpf { get => Cpf; set => Cpf = value; }
        public string Endereco { get => Endereco; set => Endereco = value; }
        public string Nome { get => Nome; set => Nome = value; }
        public string Sexo { get => Sexo; set => Sexo = value; }
        public string Telefone { get => Telefone; set => Telefone = value; }
        public int Idade { get => Idade; set => Idade = value; }
        public int IdUsuario { get => IdUsuario; set => IdUsuario = value; }
    }
}
