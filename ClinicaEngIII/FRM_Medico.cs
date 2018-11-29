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
    public partial class FRM_Medico : Form
    {
        ManipulacoesTelas mt = new ManipulacoesTelas();
        public FRM_Medico()
        {
            InitializeComponent();
        }

        private void FRM_Medico_Load(object sender, EventArgs e)
        {
            PBEditar.Visible = false;
            PBConfirmar.Visible = false;
            PBCancelar.Visible = false;
        }

        private void PBPesquisar_Click(object sender, EventArgs e)
        {
            PBEditar.Visible = true;
        }

        private void PBEditar_Click(object sender, EventArgs e)
        {
            PBConfirmar.Visible = true;
            PBCancelar.Visible = true;
            PBEditar.Visible = false;
            mt.AlterarEdicaoTextBoxes(this.Controls, true);
        }

        private void PBLimpar_Click(object sender, EventArgs e)
        {
            mt.limparTextBoxes(this.Controls);
        }

        

        private void PBCancelar_Click(object sender, EventArgs e)
        {
            normalizarTelaMedico();
        }

        private void PBConfirmar_Click(object sender, EventArgs e)
        {
            normalizarTelaMedico();
        }

        private void normalizarTelaMedico()
        {
            PBConfirmar.Visible = false;
            PBCancelar.Visible = false;
            PBEditar.Visible = true;
            mt.AlterarEdicaoTextBoxes(this.Controls, false);
            TBNome.Enabled = true;
            TBCRM.Enabled = true;
        }

        private void PBVoltar_Click(object sender, EventArgs e)
        {
            FRM_MenuPrincipal frmMenu = new FRM_MenuPrincipal();
            frmMenu.Show();
            this.Close();
        }
    }
}
