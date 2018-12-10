using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaEngIII
{
    public class Anamnese
    {
        private string _doencas;
        private string _drogas;
        private string _cirurgias;
        private string _medicamentos;
        private string _alergias;
        private string _tipoSanguineo;
        private int _fkPacienteId;
        private int _pkAnamneseId;
        public string Doencas { get => _doencas; set => _doencas = value; }
        public string Drogas { get => _drogas; set => _drogas = value; }
        public string Cirurgias { get => _cirurgias; set => _cirurgias = value; }
        public string Medicamentos { get => _medicamentos; set => _medicamentos = value; }
        public string Alergias { get => _alergias; set => _alergias = value; }
        public string TipoSanguineo { get => _tipoSanguineo; set => _tipoSanguineo = value; }
        public int fk_PacienteId { get => _fkPacienteId; set => _fkPacienteId = value; }
        public int pk_AnamneseId { get => _pkAnamneseId; set => _pkAnamneseId = value; }
        public Anamnese(string doenca, string drogas, string cirurgias, string medicamentos, string alergias,
            string tipoSangue, int idPac)
        {
            this.Doencas = doenca;
            this.Drogas = drogas;
            this.Cirurgias = cirurgias;
            this.Medicamentos = medicamentos;
            this.Alergias = alergias;
            this.TipoSanguineo = tipoSangue;
            this.fk_PacienteId = idPac;
        }
    }
}
