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
    public partial class FRM_ConsultaExame : Form
    {
        FRM_Exame frmEx;
        string NomePac, NomeMed;
        public FRM_ConsultaExame()
        {
            InitializeComponent();
        }

        public FRM_ConsultaExame(string nomeMed, string nomePac)
        {
            InitializeComponent();
            this.NomeMed = nomeMed;
            this.NomePac = nomePac;
        }

        private void FRM_ConsultaExame_Load(object sender, EventArgs e)
        {
            //Consulta com os parametros
        }

        private void DGV_ConsultaExame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEx = new FRM_Exame(DGV_ConsultaExame.CurrentRow.Cells[0].Value.ToString(),
                DGV_ConsultaExame.CurrentRow.Cells[1].Value.ToString(),
                DGV_ConsultaExame.CurrentRow.Cells[2].Value.ToString(),
                DGV_ConsultaExame.CurrentRow.Cells[3].Value.ToString());
            frmEx.Show();
            this.Close();
                             
        }

        private void PBVoltar_Click(object sender, EventArgs e)
        {
            frmEx = new FRM_Exame();
            frmEx.Show();
            this.Close();
        }
    }
}
