﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Paciente : Usuario
    {
        public Paciente(string nome, string cpf, string end, int idade, string sexo, string tel)
            : base (nome, cpf, end, idade, sexo, tel)
        {
            
        }
        
    }
}
