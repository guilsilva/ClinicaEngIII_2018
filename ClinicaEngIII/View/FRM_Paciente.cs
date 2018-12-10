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
    public partial class FRM_Paciente : Form
    {
        PacienteRepository repository = new PacienteRepository();
        public FRM_Paciente()
        {
            InitializeComponent();
            PBEditar.Visible = false;
            PBCancelar.Visible = false;
        }
        bool update = false;
        public FRM_Paciente(string CPF, string nome, int idade, string sexo, string tel, string end)
        {
            InitializeComponent();
            TBCPF.Text = CPF;
            TBEndereco.Text = end;
            TBIdade.Text = idade.ToString();
            TBNome.Text = nome;
            TBSexo.Text = sexo;
            TBTelefone.Text = tel;
            PBEditar.Visible = true;
            PBConfirmar.Visible = false;
            PBCancelar.Visible = false;
        }
        FRM_MenuPrincipal frmMenu;
        FRM_Anamnese frmAnam;
        FRM_ConsultaPaciente frmConsPac;
        ManipulacoesTelas mt = new ManipulacoesTelas();
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PBVoltar_Click(object sender, EventArgs e)
        {
            frmMenu = new FRM_MenuPrincipal();
            frmMenu.Show();
            this.Close();
        }

        private void PBConfirmar_Click(object sender, EventArgs e)
        {
            var resultado = DialogResult;
            Paciente pac = new Paciente(TBNome.Text.ToString(), TBCPF.Text.ToString(), TBEndereco.Text.ToString(), 
                int.Parse(TBIdade.Text.ToString()), TBSexo.Text.ToString(), TBTelefone.Text.ToString());
            string retornoRepository;
            if (update && mt.VerificaTextBoxesPreenchidas(Controls))
            {
                retornoRepository = repository.UpdatePaciente(pac);
                MessageBox.Show("Dados alterados com " + retornoRepository, "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                mt.limparTextBoxes(Controls);
                mt.AlterarEdicaoTextBoxes(Controls, false);
                TBNome.Enabled = true;
                TBCPF.Enabled = true;
            }
            else if(!update && mt.VerificaTextBoxesPreenchidas(Controls))
            {
                retornoRepository = repository.PersistMedico(pac);
                resultado = MessageBox.Show("Cadastro Realizado \n " + retornoRepository + "\nDeseja cadastrar uma Anamnese?", 
                    "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                mt.AlterarEdicaoTextBoxes(Controls, false);
                mt.limparTextBoxes(Controls);
                TBNome.Enabled = true;
                TBCPF.Enabled = true;
            }
            else
            {
                MessageBox.Show("Dados obrigatórios não foram preenchidos!", "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            if (resultado == DialogResult.Yes)
            {
                frmAnam = new FRM_Anamnese(TBNome.Text.ToString(), TBCPF.Text.ToString());
                mt.limparTextBoxes(Controls);
                frmAnam.Show();
                this.Close();
            }
        }

        private void PBPesquisar_Click(object sender, EventArgs e)
        {
            repository.SelectPaciente(TBCPF.Text.ToString(), TBNome.Text.ToString());
            //Se o usuário pesquisado Existir
            if (true)
            {
                frmConsPac = new FRM_ConsultaPaciente();
                frmConsPac.Show();
                this.Close();
            }
            //Se o usuário não existir
            else 
            {
                var retorno =
                    MessageBox.Show("Paciente não cadastrado no Sistema! \n Deseja Cadastrar este Paciente?",
                    "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (retorno == DialogResult.No)
                {
                    mt.limparTextBoxes(Controls);
                }
            }
        }

        private void PBLimpar_Click(object sender, EventArgs e)
        {
            mt.limparTextBoxes(Controls);
        }

        private void PBEditar_Click(object sender, EventArgs e)
        {
            PBEditar.Visible = false;
            PBCancelar.Visible = true;
            PBConfirmar.Visible = true;
            mt.AlterarEdicaoTextBoxes(Controls, true);
            update = true;
        }

        private void FRM_Paciente_Load(object sender, EventArgs e)
        {

        }
    }
}
