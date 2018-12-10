using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Exame
    {
        string _tipoEx, _hrDt, _idMed, _idPac;
        public string TipoExame { get => _tipoEx; set => _tipoEx = value; }
        public string HrDt { get => _hrDt; set => _hrDt = value; }
        public string IdMedico { get => _idMed; set => _idMed = value; }
        public string IdPaciente { get => _idPac; set => _idPac = value; }
        public Exame(string tipoEx, string hrDt, string idMed, string idPac)
        {
            this.TipoExame = tipoEx;
            this.HrDt = hrDt;
            this.IdMedico = idMed;
            this.IdPaciente = idPac;
        }
    }
}