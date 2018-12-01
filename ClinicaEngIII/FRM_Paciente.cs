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
    public partial class FRM_Paciente : Form
    {
        public FRM_Paciente()
        {
            InitializeComponent();
        }

        public FRM_Paciente(string nome, string CPF, int idade, string sexo, string tel, string end)
        {
            InitializeComponent();
            TBCPF.Text = CPF;
            TBEndereco.Text = end;
            TBIdade.Text = idade.ToString();
            TBNome.Text = nome;
            TBSexo.Text = sexo;
            TBTelefone.Text = tel;
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
            //Insere no Banco
            var resultado = MessageBox.Show("Cadastro Realizado com Sucesso! Deseja cadastrar uma Anamnese?", "Cadastro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(resultado == DialogResult.Yes)
            {
                frmAnam = new FRM_Anamnese(TBNome.Text.ToString(), TBCPF.Text.ToString());
                frmAnam.Show();
                this.Close();
            }
            else
            {
                mt.limparTextBoxes(Controls);
            }
        }

        private void PBPesquisar_Click(object sender, EventArgs e)
        {
            //Se o usuário pesquisado Existir
            if (true)
            {
                //Se existir mais de um registro
                if (true)
                {
                    frmConsPac = new FRM_ConsultaPaciente();
                    frmConsPac.Show();
                }
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

        }
    }
}
