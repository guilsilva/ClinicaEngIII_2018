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
    public partial class FRM_TrocaSenha : Form
    {
        FRM_login frmLogin = new FRM_login();
        public FRM_TrocaSenha()
        {
            InitializeComponent();
        }

        public FRM_TrocaSenha(Login login)
        {
            InitializeComponent();
            TBUsuario.Text = login.Nome;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_TrocaSenha_Load(object sender, EventArgs e)
        {
            
        }

        private void PBConfirmar_Click(object sender, EventArgs e)
        {
            if (TBSenha.Text.Equals(TBConfirmaSenha.Text))
            {
                MessageBox.Show("Senha alterada com Sucesso!");
                frmLogin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("As senhas não são iguais! Tente Novamente");
            }
        }

        private void PBCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FRM_login frmLogin = new FRM_login(true);
            frmLogin.Show();
        }
    }
}
