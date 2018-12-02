using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    class Consulta
    {
        public int Sala { get => Sala; set => Sala = value; }
        public string TipoConsulta { get => TipoConsulta; set => TipoConsulta = value; }
        public string DtHr { get => DtHr; set => DtHr = value; }
        public string TipoExame { get => TipoExame; set => TipoExame = value; }
        public string Receita { get => Receita; set => Receita = value; }
        public int IdMedico { get => IdMedico; set => IdMedico = value; }
        public int IdPaciente { get => IdPaciente; set => IdPaciente = value; }
        public Consulta(int sala, string tipoCons, string dtHr, 
            string tipoEx, string receita, int idMed, int idPac)
        {
            this.Sala = sala;
            this.TipoConsulta = tipoCons;
            this.DtHr = dtHr;
            this.TipoExame = tipoEx;
            this.Receita = receita;
            this.IdMedico = idMed;
            this.IdPaciente = idPac;
        }
    }
}
