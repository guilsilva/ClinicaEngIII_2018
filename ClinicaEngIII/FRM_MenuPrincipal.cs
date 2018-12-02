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
    public partial class FRM_MenuPrincipal : Form
    {
        public FRM_MenuPrincipal()
        {
            InitializeComponent();   
        }
        FRM_login frmLogin;
        FRM_Paciente frmPac;
        FRM_Medico frmMed;
        FRM_Anamnese frmAnam;
        FRM_Materiais frmMeteriais;
        FRM_Consulta frmConsulta;
        FRM_Exame frmExame;
        FRM_Secretaria frmSec;
        private void BTLogout_Click(object sender, EventArgs e)
        {
            frmLogin = new FRM_login(true);
            frmLogin.Show();
            this.Close();
        }

        private void FRM_MenuPrincipal_Load(object sender, EventArgs e)
        {
            new Load().Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTMedico_Click(object sender, EventArgs e)
        {
            frmMed = new FRM_Medico();
            frmMed.Show();
            this.Close();
        }

        private void BTAnamnese_Click(object sender, EventArgs e)
        {
            frmAnam = new FRM_Anamnese();
            frmAnam.Show();
            this.Close();
        }

        private void BTPaciente_Click(object sender, EventArgs e)
        {
            frmPac = new FRM_Paciente();
            frmPac.Show();
            this.Close();
        }

        private void BTMateriais_Click(object sender, EventArgs e)
        {
            frmMeteriais = new FRM_Materiais();
            frmMeteriais.Show();
            this.Close();
        }

        private void BTConsulta_Click(object sender, EventArgs e)
        {
            frmConsulta = new FRM_Consulta();
            frmConsulta.Show();
            this.Close();
        }

        private void BTSecretaria_Click(object sender, EventArgs e)
        {
            frmSec = new FRM_Secretaria();
            frmSec.Show();
            this.Close();
        }

        private void BTExame_Click(object sender, EventArgs e)
        {
            frmExame = new FRM_Exame();
            frmExame.Show();
            this.Close();
        }
    }
}
