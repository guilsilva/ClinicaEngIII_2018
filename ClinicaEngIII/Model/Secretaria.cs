using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Secretaria : Usuario
    {
        public double _salario;
        public string _ramal, _hrTrabalho;
        public double Salario{ get => _salario; set => _salario = value; }
        public string Ramal { get => _ramal; set => _ramal = value; }
        public string HrTrabalho { get => _hrTrabalho; set => _hrTrabalho = value; }
        
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
