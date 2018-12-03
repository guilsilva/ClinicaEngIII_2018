using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaEngIII
{
    public partial class FRM_ConsultaSecretaria : Form
    {
        FRM_Secretaria frmSec;
        string Nome, CPF;
        public FRM_ConsultaSecretaria()
        {
            InitializeComponent();
        }

        private void PBVoltar_Click(object sender, EventArgs e)
        {
            frmSec = new FRM_Secretaria();
            frmSec.Show();
            this.Close();
        }

        private void DGV_ConsultaSecretaria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSec = new FRM_Secretaria(DGV_ConsultaSecretaria.CurrentRow.Cells[0].Value.ToString(),
                DGV_ConsultaSecretaria.CurrentRow.Cells[1].Value.ToString(),
                DGV_ConsultaSecretaria.CurrentRow.Cells[2].Value.ToString(),
                double.Parse(DGV_ConsultaSecretaria.CurrentRow.Cells[3].Value.ToString()),
                DGV_ConsultaSecretaria.CurrentRow.Cells[4].Value.ToString(),
                DGV_ConsultaSecretaria.CurrentRow.Cells[5].Value.ToString(),
                int.Parse(DGV_ConsultaSecretaria.CurrentRow.Cells[6].Value.ToString()),
                DGV_ConsultaSecretaria.CurrentRow.Cells[7].Value.ToString(),
                DGV_ConsultaSecretaria.CurrentRow.Cells[8].Value.ToString());
            frmSec.Show();
            this.Close();
        }

        public FRM_ConsultaSecretaria(string nome, string cpf)
        {
            InitializeComponent();
            this.Nome = nome;
            this.CPF = cpf;
        }


    }
}
