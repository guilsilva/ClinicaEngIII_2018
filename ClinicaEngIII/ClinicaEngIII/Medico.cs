using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Medico
    {
        private string nome;
        private string crm;
        private string endereco;
        private string sexo;
        private string telefone;
        private string area;
        private double salario;
        private string hrAtendimento;

        public string Crm { get => crm; set => crm = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Area { get => area; set => area = value; }
        public double Salario { get => salario; set => salario = value; }
        public string HrAtendimento { get => hrAtendimento; set => hrAtendimento = value; }
    }
}
