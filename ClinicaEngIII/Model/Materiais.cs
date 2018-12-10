using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Materiais
    {
        private string _nome, _validade, _descricao, _tipoMaterial;
        private int _quantidade;
        public string Nome { get => _nome; set => _nome = value; }
        public string Validade { get => _validade; set => _validade = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string Tipo_Material { get => _tipoMaterial; set => _tipoMaterial = value; }
        public int IdMaterial { get => IdMaterial; set => IdMaterial = value; }

        public Materiais(string nome, string validade, int quantidade, string descricao, string tipo)
        {
            this.Nome = nome;
            this.Validade = validade;
            this.Quantidade = quantidade;
            this.Descricao = descricao;
            this.Tipo_Material = tipo;
        }
    }
}