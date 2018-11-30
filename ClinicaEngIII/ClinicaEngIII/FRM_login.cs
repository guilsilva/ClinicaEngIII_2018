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
    public partial class FRM_login : Form
    {
        public FRM_login()
        {
            InitializeComponent();
        }

        public FRM_login(bool acessos)
        {
            InitializeComponent();
            this.acesso = acessos;
        }

        public bool acesso { get; set; }

        private void BTSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTEntrar_Click(object sender, EventArgs e)
        {
            if (TBUsuario.Text == String.Empty || TBSenha.Text == String.Empty)
            {
                MessageBox.Show("Campo obrigatório não preenchido!");
            }
            //provisório para testes. admin admin
            if (TBUsuario.Text.Equals("admin") && TBSenha.Text.Equals("admin")){
                if (!acesso)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    FRM_MenuPrincipal frmMenu = new FRM_MenuPrincipal();
                    frmMenu.Show();
                }
                this.Close();
            }
            else{
                MessageBox.Show("Usúario ou Senha inválida! Tente Novamente");
            }
        }

        private void EsqueceSenha_Click(object sender, EventArgs e)
        {
            if(TBUsuario.Text == String.Empty)
            {
                MessageBox.Show("Campo obrigatório não preenchido!");
            }
            else
            {
                Login log = new Login();
                log.Nome = TBUsuario.Text;
                FRM_TrocaSenha frmts = new FRM_TrocaSenha(log);
                frmts.Show();
            }
        }

        private void FRM_login_Load(object sender, EventArgs e)
        {

        }
    }
}
