using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    class Materiais
    {
        public string Nome { get => Nome; set => Nome = value; }
        public string Validade { get => Validade; set => Validade = value; }
        public int Quantidade { get => Quantidade; set => Quantidade = value; }
        public string Descricao { get => Descricao; set => Descricao = value; }
        public string Tipo_Material { get => Tipo_Material; set => Tipo_Material = value; }
        public int IdMaterial { get => IdMaterial; set => IdMaterial = value; }
    }
}