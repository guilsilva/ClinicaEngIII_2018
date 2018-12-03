using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    class Secretaria : Usuario
    {
        public double Salario{ get => Salario; set => Salario = value; }
        public string Ramal { get => Ramal; set => Ramal = value; }
        public string HrTrabalho { get => HrTrabalho; set => HrTrabalho = value; }
        
        public Secretaria(double salario, string ramal, string hrTrab,
           string nome, string cpf, string end, int idade, string sexo, string tel)
            : base (nome, cpf, end, idade, sexo, tel)
        {
            this.Salario = salario;
            this.Ramal = ramal;
            this.HrTrabalho = hrTrab;
        }
    }
}
