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
    public partial class FRM_Anamnese : Form
    {
        ManipulacoesTelas mt = new ManipulacoesTelas();
        public FRM_Anamnese()
        {
            InitializeComponent();
        }

        private void FRM_Anamnese_Load(object sender, EventArgs e)
        {
            this.Height = 175;
        }

        private void PBLimpar_Click(object sender, EventArgs e)
        {
            mt.limparTextBoxes(Controls);
        }

        private void PBPesquisar_Click(object sender, EventArgs e)
        {
            //Se o usuário pesquisado Existir
            if (true)
            {
                //Se existir dados cai no IF
                if (false)
                {
                    var returno = MessageBox.Show
                        ("Anamnese já preenchida para este Paciente! \n Deseja consultar os dados?",
                        "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (returno == DialogResult.Yes)
                    {
                        this.Height = 554;
                        //usuario poderá vizualizar as informações e/ou editalas
                    }
                    else
                    {
                        mt.limparTextBoxes(Controls);
                    }
                }
                else
                {
                    this.Height = 554;
                }
            }
            else
            {
                var retorno = 
                    MessageBox.Show("Paciente não cadastrado no Sistema! \n Deseja Cadastrar este Paciente?", 
                    "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(retorno == DialogResult.Yes)
                {
                    //FRM_Paciente frmPac = new FRM_Paciente();
                    //frmPac.Show();
                }
            }
        }

        private void CBDrogasSim_CheckedChanged(object sender, EventArgs e)
        {
            if (CBDrogasSim.Checked)
            {
                TBDescDrogas.Enabled = true;
            }
        }
    }
}
