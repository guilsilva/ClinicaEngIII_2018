using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    class Anamnese
    {
        public string Doencas { get => Doencas; set => Doencas = value; }
        public string Drogas { get => Drogas; set => Drogas = value; }
        public string Cirurgias { get => Cirurgias; set => Cirurgias = value; }
        public string Medicamentos { get => Medicamentos; set => Medicamentos = value; }
        public string Alergias { get => Alergias; set => Alergias = value; }
        public string TipoSanguineo { get => TipoSanguineo; set => TipoSanguineo = value; }
        public int IdAnamnese { get => IdAnamnese; set => IdAnamnese = value; }
        public int IdPaciente { get => IdPaciente; set => IdPaciente = value; }
        public Anamnese(string doenca, string drogas, string cirurgias, string medicamentos, string alergias,
            string tipoSangue, int idPac)
        {
            this.Doencas = doenca;
            this.Drogas = drogas;
            this.Cirurgias = cirurgias;
            this.Medicamentos = medicamentos;
            this.Alergias = alergias;
            this.TipoSanguineo = tipoSangue;
            this.IdPaciente = idPac;
        }
    }
}
