using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    class Paciente : Usuario
    {
        public Paciente(string nome, string cpf, string end, int idade, string sexo, string tel)
        {
            this.paciente = new Paciente(nome, cpf, end, idade, sexo, tel);
        }
        Usuario paciente;
    }
}
