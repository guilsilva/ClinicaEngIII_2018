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
    public partial class FRM_Exame : Form
    {
        FRM_ConsultaExame frmConsEx;
        ManipulacoesTelas mt = new ManipulacoesTelas();
        FRM_MenuPrincipal frmMenu;
        bool update = false;
        public FRM_Exame()
        {
            InitializeComponent();
            PBEditar.Visible = false;
        }
        public FRM_Exame(string nomeMed, string nomePac, string tipo, string hrDt)
        {
            InitializeComponent();
            TBNomeMedico.Text = nomeMed;
            TBNomePaciente.Text = nomePac;
            TBTipoExame.Text = tipo;
            TBDtHr.Text = hrDt;
            PBEditar.Visible = true;
            PBConfirmar.Visible = false;
        }

        private void FRM_Exame_Load(object sender, EventArgs e)
        {
            PBCancelar.Visible = false;
        }

        private void PBLimpar_Click(object sender, EventArgs e)
        {
            mt.limparTextBoxes(Controls);
        }

        private void PBPesquisar_Click(object sender, EventArgs e)
        {
            if (TBNomePaciente.Text == String.Empty || TBNomeMedico.Text == String.Empty)
            {
                MessageBox.Show("Campos obrigatórios para pesquisa não informados!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmConsEx = new FRM_ConsultaExame(TBNomeMedico.Text.ToString(), TBNomePaciente.Text.ToString());
                frmConsEx.Show();
                this.Close();
            }
        }

        private void PBEditar_Click(object sender, EventArgs e)
        {
            PBConfirmar.Visible = true;
            PBCancelar.Visible = true;
            PBEditar.Visible = false;
            mt.AlterarEdicaoTextBoxes(this.Controls, true);
        }

        private void PBCancelar_Click(object sender, EventArgs e)
        {
            mt.AlterarEdicaoTextBoxes(this.Controls, false);
            PBConfirmar.Visible = false;
            PBCancelar.Visible = false;
            PBEditar.Visible = true;
            TBNomePaciente.Enabled = true;
            TBNomeMedico.Enabled = true;
        }

        private void PBVoltar_Click(object sender, EventArgs e)
        {
            frmMenu = new FRM_MenuPrincipal();
            frmMenu.Show();
            this.Close();
        }

        private void PBConfirmar_Click(object sender, EventArgs e)
        {
            //Salva os dados no banco
            if (update)
            {
                //Update no registro que ja esta selecionado
                if (mt.VerificaTextBoxesPreenchidas(Controls))
                {
                    mt.limparTextBoxes(Controls);
                    MessageBox.Show("Cadastro Realizado com Sucesso!", "Cadastro", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    mt.AlterarEdicaoTextBoxes(Controls, false);
                    TBNomePaciente.Enabled = true;
                    TBNomeMedico.Enabled = true;
                    PBCancelar.Visible = false;
                }
                else
                {
                    MessageBox.Show("Dados obrigatórios não foram preenchidos!", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                //Create no registro inserido
                if (mt.VerificaTextBoxesPreenchidas(Controls))
                {
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
}
