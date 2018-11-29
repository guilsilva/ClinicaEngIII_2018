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
        FRM_login frmLogin = new FRM_login(true);
        private void BTLogout_Click(object sender, EventArgs e)
        {
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
            FRM_Medico frmMed = new FRM_Medico();
            frmMed.Show();
            this.Hide();
        }

        private void BTAnamnese_Click(object sender, EventArgs e)
        {
            FRM_Anamnese frmAnam = new FRM_Anamnese();
            frmAnam.Show();
        }
    }
}
