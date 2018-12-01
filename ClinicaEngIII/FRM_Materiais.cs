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
    public partial class FRM_Materiais : Form
    {
        FRM_MenuPrincipal frmMenu;
        ManipulacoesTelas mt;
        public FRM_Materiais()
        {
            InitializeComponent();
        }

        public FRM_Materiais(string nome, string validade, int quantidade, string tipoMaterial, string descMaterial)
        {
            InitializeComponent();
            TBNome.Text = nome;
            TBValidade.Text = validade;
            TBQuantidade.Text = quantidade.ToString();
            TBTipoMaterial.Text = tipoMaterial;
            TBDescMaterial.Text = descMaterial;
        }

        private void PBVoltar_Click(object sender, EventArgs e)
        {
            frmMenu = new FRM_MenuPrincipal();
            frmMenu.Show();
            this.Close();
        }

        private void PBLimpar_Click(object sender, EventArgs e)
        {
            mt.limparTextBoxes(Controls);
        }

        private void FRM_Materiais_Load(object sender, EventArgs e)
        {
            PBEditar.Visible = false;
        }

        private void PBEditar_Click(object sender, EventArgs e)
        {

        }

        private void PBPesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
