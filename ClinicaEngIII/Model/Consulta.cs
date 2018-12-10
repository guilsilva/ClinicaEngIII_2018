using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Consulta
    {
        private int _sala;
        private string _tipoConsulta, _dtHr, _tipoExame, _receita, _idMedico, _idPaciente;
        public int Sala { get => _sala; set => _sala = value; }
        public string TipoConsulta { get => _tipoConsulta; set => _tipoConsulta = value; }
        public string DtHr { get => _dtHr; set => _dtHr = value; }
        public string TipoExame { get => _tipoExame; set => _tipoExame = value; }
        public string Receita { get => _receita; set => _receita = value; }
        public string IdMedico { get => _idMedico; set => _idMedico = value; }
        public string IdPaciente { get => _idPaciente; set => _idPaciente = value; }
        public Consulta(int sala, string tipoCons, string dtHr, 
            string tipoEx, string receita, string idMed, string idPac)
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
