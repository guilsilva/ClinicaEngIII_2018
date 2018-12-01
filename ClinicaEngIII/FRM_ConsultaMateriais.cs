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
    public partial class FRM_ConsultaMateriais : Form
    {
        FRM_MenuPrincipal frmMenu = new FRM_MenuPrincipal();
        FRM_Materiais frmMateriais;
        public FRM_ConsultaMateriais()
        {
            InitializeComponent();
        }

        public FRM_ConsultaMateriais(string nome)
        {
            InitializeComponent();
            string Nome = nome;
        }

        private void PBVoltar_Click(object sender, EventArgs e)
        {
            frmMenu.Show();
            this.Close();
        }

        private void DGV_ConsultaMateriais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMateriais = new FRM_Materiais(DGV_ConsultaMateriais.CurrentRow.Cells[0].Value.ToString(),
                DGV_ConsultaMateriais.CurrentRow.Cells[1].Value.ToString(),
                int.Parse(DGV_ConsultaMateriais.CurrentRow.Cells[2].Value.ToString()),
                DGV_ConsultaMateriais.CurrentRow.Cells[3].Value.ToString(),
                DGV_ConsultaMateriais.CurrentRow.Cells[4].Value.ToString());
            frmMateriais.Show();
            this.Close();
        }

        private void FRM_ConsultaMateriais_Load(object sender, EventArgs e)
        {
            /*Realizar um select na base buscando material 
             recebido por parametro no construtor(linha 25)*/
        }
    }
}
