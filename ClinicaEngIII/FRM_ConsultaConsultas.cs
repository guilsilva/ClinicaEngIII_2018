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
    public partial class FRM_ConsultaConsultas : Form
    {
        FRM_Consulta frmCons;
        public FRM_ConsultaConsultas()
        {
            InitializeComponent();
        }
        public FRM_ConsultaConsultas(string nomeMedico, string nomePaciente)
        {
            InitializeComponent();
            string nomeMed = nomeMedico;
            string nomePac = nomePaciente;
        }
        private void PBVoltar_Click(object sender, EventArgs e)
        {
            frmCons = new FRM_Consulta();
            frmCons.Show();
            this.Close();
        }

        private void FRM_ConsultaConsultas_Load(object sender, EventArgs e)
        {
            //Carrega dados 
        }

        private void DGV_ConsultaConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCons = new FRM_Consulta(DGV_ConsultaConsultas.CurrentRow.Cells[0].Value.ToString(),
                DGV_ConsultaConsultas.CurrentRow.Cells[1].Value.ToString(),
                DGV_ConsultaConsultas.CurrentRow.Cells[2].Value.ToString(),
                DGV_ConsultaConsultas.CurrentRow.Cells[3].Value.ToString(),
                DGV_ConsultaConsultas.CurrentRow.Cells[4].Value.ToString(),
                DGV_ConsultaConsultas.CurrentRow.Cells[5].Value.ToString(),
                DGV_ConsultaConsultas.CurrentRow.Cells[6].Value.ToString());
            frmCons.Show();
            this.Close();
        }
    }
}
