using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Medico : Usuario
    {
        private string _crm;
        private string _area;
        private double _salario;
        public string Crm { get => _crm; set => _crm = value; } 
        public string Area { get => _area; set => _area = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public Medico(string crm, string area, double salario,
            string nome, string cpf, string end, int idade, string sexo, string tel)
            : base(nome, cpf, end, idade, sexo, tel)
        {
            this.Crm = crm;
            this.Area = area;
            this.Salario = salario;
        }
    }
}
