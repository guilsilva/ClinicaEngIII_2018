using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaEngIII.Repository;

namespace ClinicaEngIII
{
    public partial class FRM_Materiais : Form
    {
        FRM_MenuPrincipal frmMenu;
        FRM_ConsultaMateriais frmConsMat;
        ManipulacoesTelas mt = new ManipulacoesTelas();
        MateriaisRepository repository = new MateriaisRepository();
        bool update = false;
        public FRM_Materiais()
        {
            InitializeComponent();
        }
        public FRM_Materiais(string nome, string validade, string tipoMaterial, int quantidade, string descMaterial)
        {
            InitializeComponent();
            TBNome.Text = nome;
            TBValidade.Text = validade;
            TBQuantidade.Text = quantidade.ToString();
            TBTipoMaterial.Text = tipoMaterial;
            TBDescMaterial.Text = descMaterial;
            PBEditar.Visible = true;
            PBConfirmar.Visible = false;
            mt.AlterarEdicaoTextBoxes(Controls, false);
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
            PBCancelar.Visible = false;
        }
        private void PBEditar_Click(object sender, EventArgs e)
        {
            PBEditar.Visible = false;
            PBCancelar.Visible = true;
            mt.AlterarEdicaoTextBoxes(Controls, true);
            update = true;
        }
        private void PBPesquisar_Click(object sender, EventArgs e)
        {
            frmConsMat = new FRM_ConsultaMateriais(TBNome.Text.ToString());
            frmConsMat.Show();
            this.Close();    
        }

        private void PBCancelar_Click(object sender, EventArgs e)
        {
            PBCancelar.Visible = false;
            PBEditar.Visible = true;
            mt.AlterarEdicaoTextBoxes(Controls, false);
        }
        private void PBConfirmar_Click(object sender, EventArgs e)
        {
            Materiais materiais = new Materiais(TBNome.Text.ToString(), TBValidade.Text.ToString(), 
                int.Parse(TBQuantidade.Text.ToString()), TBDescMaterial.Text.ToString(), TBTipoMaterial.Text.ToString());
            //Salva os dados no banco
            if (update && mt.VerificaTextBoxesPreenchidas(Controls))
            {
                repository.UpdateMateriais(materiais);
                mt.limparTextBoxes(Controls);
                MessageBox.Show("Cadastro Realizado com Sucesso!", "Cadastro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (!update && mt.VerificaTextBoxesPreenchidas(Controls))
            {
                repository.PersistMateriais(materiais);
                mt.limparTextBoxes(Controls);
                MessageBox.Show("Cadastro Realizado com Sucesso!", "Cadastro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dados obrigatórios não foram preenchidos!", "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}