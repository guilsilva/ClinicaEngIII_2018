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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }
        private void Load_Load(object sender, EventArgs e)
        {
            using (FRM_login frmLogin = new FRM_login(false))
            {
                frmLogin.ShowDialog();
                // Aqui considerei que se o login for efetuado com sucesso, o DialogResult será OK
                if (frmLogin.DialogResult != DialogResult.OK)
                {
                    Application.Exit();
                }
                else
                {
                    FRM_MenuPrincipal frmMenu = new FRM_MenuPrincipal();
                    frmMenu.Show();
                }
            }
        }
    }
}
