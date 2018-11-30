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
    public partial class FRM_ConsultaAnamnese : Form
    {
        FRM_Anamnese frmAnam;
        public FRM_ConsultaAnamnese()
        {
            InitializeComponent();
        }

        private void DGV_ConsultaAnamnese_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAnam = new FRM_Anamnese(DGV_ConsultaAnamnese.CurrentRow.Cells[0].Value.ToString(), DGV_ConsultaAnamnese.CurrentRow.Cells[1].Value.ToString());
            frmAnam.Show();
            this.Close();
        }

        private void PBVoltar_Click(object sender, EventArgs e)
        {
            frmAnam = new FRM_Anamnese();
            frmAnam.Show();
            this.Close();
        }

        private void FRM_ConsultaAnamnese_Load(object sender, EventArgs e)
        {
            //DGV_ConsultaAnamnese.Rows.Insert(0, "ola", "Tudo bem");
        }
    }
}
