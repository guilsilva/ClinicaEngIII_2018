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
    public partial class FRM_Secretaria : Form
    {
        ManipulacoesTelas mt = new ManipulacoesTelas();
        Secretaria secretaria;
        FRM_ConsultaSecretaria frmConsSec;
        bool update = false;
        public FRM_Secretaria()
        {
            InitializeComponent();
            PBEditar.Visible = false;
        }

        public FRM_Secretaria(string nome, string ramal, string hrTrab, double salario, string end, string sexo,
            int idade, string tel, string cpf)
        {
            InitializeComponent();
            TBRamal.Text = ramal;
            TBHrTrabalho.Text = hrTrab;
            TBSalario.Text = salario.ToString();
            TBNome.Text = nome;
            TBCPF.Text = cpf;
            TBEndereco.Text = end;
            TBIdade.Text = idade.ToString();
            TBSexo.Text = sexo;
            TBTelefone.Text = tel;
            PBEditar.Visible = true;
            PBConfirmar.Visible = false;
        }

        private void FRM_Secretaria_Load(object sender, EventArgs e)
        {
            PBCancelar.Visible = false;
        }

        private void PBPesquisar_Click(object sender, EventArgs e)
        {
            if (TBCPF.Text == String.Empty || TBNome.Text == String.Empty)
            {
                MessageBox.Show("Campos obrigatórios para pesquisa não informados!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmConsSec = new FRM_ConsultaSecretaria(TBNome.Text.ToString(), TBCPF.Text.ToString());
                frmConsSec.Show();
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

        private void PBLimpar_Click(object sender, EventArgs e)
        {
            mt.limparTextBoxes(this.Controls);
        }
        private void PBCancelar_Click(object sender, EventArgs e)
        {
            mt.AlterarEdicaoTextBoxes(this.Controls, false);
            PBConfirmar.Visible = false;
            PBCancelar.Visible = false;
            PBEditar.Visible = true;
            TBCPF.Enabled = true;
            TBNome.Enabled = true;
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
                    TBNome.Enabled = true;
                    TBCPF.Enabled = true;
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
                    secretaria = new Secretaria(double.Parse(TBSalario.Text.ToString()), TBRamal.Text.ToString(),
                        TBHrTrabalho.Text.ToString(), TBNome.Text.ToString(), TBCPF.Text.ToString(),
                        TBEndereco.Text.ToString(), int.Parse(TBIdade.Text.ToString()), TBSexo.Text.ToString(),
                        TBTelefone.Text.ToString());
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
        private void PBVoltar_Click(object sender, EventArgs e)
        {
            FRM_MenuPrincipal frmMenu = new FRM_MenuPrincipal();
            frmMenu.Show();
            this.Close();
        }
    }
}

