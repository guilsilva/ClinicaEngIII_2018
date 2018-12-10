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
    public partial class FRM_Medico : Form
    {
        MedicoRepository repository = new MedicoRepository();
        ManipulacoesTelas mt = new ManipulacoesTelas();
        Medico medico;
        FRM_ConsultaMedico frmConsMed;
        bool update = false;
        public FRM_Medico()
        {
            InitializeComponent();
            PBEditar.Visible = false;
        }

        public FRM_Medico(string nome, string crm, string area, double salario, string end, string sexo,
            int idade, string tel, string cpf)
        {
            InitializeComponent();
            TBCRM.Text = crm;
            TBArea.Text = area;
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

        private void FRM_Medico_Load(object sender, EventArgs e)
        {
            PBCancelar.Visible = false;
        }

        private void PBPesquisar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                frmConsMed = new FRM_ConsultaMedico(TBNome.Text.ToString(), TBCRM.Text.ToString());
                frmConsMed.Show();
                this.Close();
            }
            //Se o usuário não existir
            else
            {
                var retorno =
                    MessageBox.Show("Médico não cadastrado no Sistema! \n Deseja Cadastrar este Médico?",
                    "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (retorno == DialogResult.No)
                {
                    mt.limparTextBoxes(Controls);
                }
            }
        }

        private void PBEditar_Click(object sender, EventArgs e)
        {
            PBConfirmar.Visible = true;
            PBCancelar.Visible = true;
            PBEditar.Visible = false;
            mt.AlterarEdicaoTextBoxes(this.Controls, true);
            update = true;
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
            TBCRM.Enabled = true;
            TBNome.Enabled = true;
        }

        private void PBConfirmar_Click(object sender, EventArgs e)
        {
            medico = 
                new Medico(TBCRM.Text.ToString(), TBArea.Text.ToString(), double.Parse(TBSalario.Text.ToString()),
                TBNome.Text.ToString(), TBCPF.Text.ToString(), TBEndereco.Text.ToString(), 
                int.Parse(TBIdade.Text.ToString()), TBSexo.Text.ToString(), TBTelefone.Text.ToString());   
            if (update && mt.VerificaTextBoxesPreenchidas(Controls))
            {
                repository.UpdateMedico(medico);
                mt.limparTextBoxes(Controls);
                MessageBox.Show("Cadastro Realizado com Sucesso!", "Cadastro", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                mt.AlterarEdicaoTextBoxes(Controls, false);
                TBNome.Enabled = true;
                TBCRM.Enabled = true;
                PBCancelar.Visible = false;
            }
            else if(!update && mt.VerificaTextBoxesPreenchidas(Controls))
            {
                repository.PersistMedico(medico);
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
        private void PBVoltar_Click(object sender, EventArgs e)
        {
            FRM_MenuPrincipal frmMenu = new FRM_MenuPrincipal();
            frmMenu.Show();
            this.Close();
        }
    }
}
