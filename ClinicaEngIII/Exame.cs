using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    class Exame
    {
        public string TipoExame { get => TipoExame; set => TipoExame = value; }
        public string HrDt { get => HrDt; set => HrDt = value; }
        public int IdMedico { get => IdMedico; set => IdMedico = value; }
        public int IdPaciente { get => IdPaciente; set => IdPaciente = value; }
        public Exame(string tipoEx, string hrDt, int idMed, int idPac)
        {
            this.TipoExame = tipoEx;
            this.HrDt = hrDt;
            this.IdMedico = idMed;
            this.IdPaciente = idPac;
        }
    }
}