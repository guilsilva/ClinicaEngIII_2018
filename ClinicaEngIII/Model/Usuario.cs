using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Usuario
    {
        private string _nome;
        private string _cpf;
        private string _end;
        private string _sexo;
        private string _tel;
        private int _idade;
        private int _pkUsuarioId;
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
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Endereco { get => _end; set => _end = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Telefone { get => _tel; set => _tel = value; }
        public int Idade { get => _idade; set => _idade = value; }
        public int pk_UsuarioId { get => _pkUsuarioId; set => _pkUsuarioId = value; }
    }
}
