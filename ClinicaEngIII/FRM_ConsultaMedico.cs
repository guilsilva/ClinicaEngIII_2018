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
    public partial class FRM_ConsultaMedico : Form
    {
        FRM_Medico frmMed;
        string Nome, CRM;
        public FRM_ConsultaMedico()
        {
            InitializeComponent();
        }

        public FRM_ConsultaMedico(string nome, string crm)
        {
            InitializeComponent();
            this.Nome = nome;
            this.CRM = crm;
        }

        private void PBVoltar_Click(object sender, EventArgs e)
        {
            frmMed = new FRM_Medico();
            frmMed.Show();
            this.Close();
        }

        private void DGV_ConsultaMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMed = new FRM_Medico(DGV_ConsultaMedico.CurrentRow.Cells[0].Value.ToString(),
                DGV_ConsultaMedico.CurrentRow.Cells[1].Value.ToString(),
                DGV_ConsultaMedico.CurrentRow.Cells[2].Value.ToString(),
                double.Parse(DGV_ConsultaMedico.CurrentRow.Cells[3].Value.ToString()),
                DGV_ConsultaMedico.CurrentRow.Cells[4].Value.ToString(),
                DGV_ConsultaMedico.CurrentRow.Cells[5].Value.ToString(),
                int.Parse(DGV_ConsultaMedico.CurrentRow.Cells[6].Value.ToString()),
                DGV_ConsultaMedico.CurrentRow.Cells[7].Value.ToString(),
                DGV_ConsultaMedico.CurrentRow.Cells[8].Value.ToString());
            frmMed.Show();
            this.Close();
        }

        private void FRM_ConsultaMedico_Load(object sender, EventArgs e)
        {
            DGV_ConsultaMedico.Rows[0].Cells[0].Value = Nome;
            DGV_ConsultaMedico.Rows[0].Cells[1].Value = CRM;
            for(int i = 2; i < 9; i++)
            {
                DGV_ConsultaMedico.Rows[0].Cells[i].Value = "0";
            }
            //Consultar com os parametros de entrada Nome e CRM, passados por parametro
        }
    }
}
