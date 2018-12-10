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
    public partial class FRM_Anamnese : Form
    {
        ManipulacoesTelas mt = new ManipulacoesTelas();
        AnamneseRepository repository = new AnamneseRepository();
        PacienteRepository repoPac = new PacienteRepository();
        FRM_MenuPrincipal frmMenu;
        string Nome, CPF;
        int idPac;
        bool update = false;
        Anamnese anamnese;
        public FRM_Anamnese()
        {
            InitializeComponent();
        }

        public FRM_Anamnese(string nome, string cpf)
        {
            InitializeComponent();
            this.Nome = nome;
            this.CPF = cpf;
        }

        private void FRM_Anamnese_Load(object sender, EventArgs e)
        {
            this.Height = 174;
            PBEditar.Visible = false;
            TBCPFPaciente.Text = CPF;
            TBNomePaciente.Text = Nome;
        }

        private void PBLimpar_Click(object sender, EventArgs e)
        {
            mt.limparTextBoxes(Controls);
        }

        private void PBPesquisar_Click(object sender, EventArgs e)
        {
            int pk_pac = repoPac.SelectPKPaciente(TBNomePaciente.Text.ToString(), TBCPFPaciente.Text.ToString());
            //Se o usuário pesquisado Existir
            if (pk_pac != 0)
            {
                repository.SelectAnamnese(TBNomePaciente.Text.ToString(), TBCPFPaciente.Text.ToString());
                this.Height = 554;
                PBEditar.Visible = false;
                
            }
            //Se o usuário não existir
            else
            {
                var retorno = 
                    MessageBox.Show("Paciente não cadastrado no Sistema! \n Deseja Cadastrar este Paciente?", 
                    "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(retorno == DialogResult.Yes)
                {
                    FRM_Paciente frmPac = new FRM_Paciente();
                    frmPac.Show();
                    this.Close();
                }
            }            
        }

        private void CBDrogasSim_CheckedChanged(object sender, EventArgs e)
        {
            if (CBDrogasSim.Checked)
            {
                TBDescDrogas.Enabled = true;
                TBDescDrogas.Text = String.Empty;
                CBDrogasNao.Checked = false;
            }
            else
            {
                TBDescDrogas.Enabled = false;
                TBDescDrogas.Text = "Quais?";
            }
        }

        private void CBAlergiasSim_CheckedChanged(object sender, EventArgs e)
        {
            if (CBAlergiasSim.Checked)
            {
                TBDescAlergia.Enabled = true;
                TBDescAlergia.Text = String.Empty;
                CBAlergiaNao.Checked = false;
            }
            else
            {
                TBDescAlergia.Enabled = false;
                TBDescAlergia.Text = "Quais?";
            }
        }

        private void CBCirurgiaSim_CheckedChanged(object sender, EventArgs e)
        {
            if (CBCirurgiaSim.Checked)
            {
                TBDescCirurgia.Enabled = true;
                TBDescCirurgia.Text = String.Empty;
                CBCirurgiaNao.Checked = false;
            }
            else
            {
                TBDescCirurgia.Enabled = false;
                TBDescCirurgia.Text = "Quais?";
            }
        }

        private void CBMedicamentoSim_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMedicamentoSim.Checked)
            {
                TBDescMedicamento.Enabled = true;
                TBDescMedicamento.Text = String.Empty;
                CBMedicamentoNao.Checked = false;
            }
            else
            {
                TBDescMedicamento.Enabled = false;
                TBDescMedicamento.Text = "Quais?";
            }
        }

        private void CBDoencaSim_CheckedChanged(object sender, EventArgs e)
        {
            if (CBDoencaSim.Checked)
            {
                TBDescDoenca.Enabled = true;
                TBDescDoenca.Text = String.Empty;
                CBDoencaNao.Checked = false;
            }
            else
            {
                TBDescDoenca.Enabled = false;
                TBDescDoenca.Text = "Quais?";
            }
        }

        private void CBGravidaSim_CheckedChanged(object sender, EventArgs e)
        {
            if (CBGravidaSim.Checked)
            {
                TBQntdSemanas.Enabled = true;
                TBQntdSemanas.Text = String.Empty;
                CBGravidaNao.Checked = false;
            }
            else
            {
                TBQntdSemanas.Enabled = false;
                TBQntdSemanas.Text = "Quais?";
            }
        }

        private void CBDrogasNao_CheckedChanged(object sender, EventArgs e)
        {
            if (CBDrogasNao.Checked)
            {
                CBDrogasSim.Checked = false;
            }
        }

        private void CBAlergiaNao_CheckedChanged(object sender, EventArgs e)
        {
            if (CBAlergiaNao.Checked)
            {
                CBAlergiasSim.Checked = false;
            }
        }

        private void CBCirurgiaNao_CheckedChanged(object sender, EventArgs e)
        {
            if (CBCirurgiaNao.Checked)
            {
                CBCirurgiaSim.Checked = false;
            }
        }

        private void CBMedicamentoNao_CheckedChanged(object sender, EventArgs e)
        {
            if (CBMedicamentoNao.Checked)
            {
                CBMedicamentoSim.Checked = false;
            }
        }

        private void CBDoencaNao_CheckedChanged(object sender, EventArgs e)
        {
            if (CBDoencaNao.Checked)
            {
                CBDoencaSim.Checked = false;
            }
        }

        private void CBGravidaNao_CheckedChanged(object sender, EventArgs e)
        {
            if (CBGravidaNao.Checked)
            {
                CBGravidaSim.Checked = false;
            }
        }
        
        private void PBVoltar_Click(object sender, EventArgs e)
        {
            frmMenu = new FRM_MenuPrincipal();
            frmMenu.Show();
            this.Close();
        }

        private void PBConfirmar_Click(object sender, EventArgs e)
        {
            if((CBDrogasSim.Checked && TBDescDrogas.Text == String.Empty) ||
                (CBAlergiasSim.Checked && TBDescAlergia.Text == String.Empty) ||
                (CBMedicamentoSim.Checked && TBDescMedicamento.Text == String.Empty) ||
                (CBGravidaSim.Checked && TBQntdSemanas.Text == String.Empty) || 
                (CBCirurgiaSim.Checked && TBDescCirurgia.Text == String.Empty) ||
                (CBDoencaSim.Checked && TBDescDoenca.Text == String.Empty) || 
                TBNomePaciente.Text == String.Empty || TBCPFPaciente.Text == String.Empty ||
                TBTipoSanguineo.Text == String.Empty) 
            {
                var resultado = MessageBox.Show("Dados obrigatórios não foram preenchidos!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                anamnese = new Anamnese(TBDescDoenca.Text.ToString(), TBDescDrogas.Text.ToString(),
                TBDescCirurgia.Text.ToString(), TBDescMedicamento.Text.ToString(),
                TBDescAlergia.Text.ToString(), TBTipoSanguineo.Text.ToString(), 1);
                if (update)
                {
                    repository.UpdateAnamnese(anamnese);
                    MessageBox.Show("Dados cadastrados com sucesso!", "Cadastro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    mt.limparTextBoxes(Controls);
                    this.Height = 174;
                }
                else
                {
                    MessageBox.Show(repository.PersistAnamnese(anamnese));
                    MessageBox.Show("Dados cadastrados com sucesso!", "Cadastro", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                PBEditar.Visible = false;
                PBCancelar.Visible = false;
            }
        }

        private void PBEditar_Click(object sender, EventArgs e)
        {
            PBEditar.Visible = false;
            PBCancelar.Visible = true;
            PBConfirmar.Visible = true;
            TBTipoSanguineo.Enabled = true;
            mt.bloquearCheckBoxes(Controls, true);
            update = true;
        }
    }
}
