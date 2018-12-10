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
    public partial class FRM_ConsultaPaciente : Form
    {
        string Nome, CPF;
        PacienteRepository repository = new PacienteRepository();
        public FRM_ConsultaPaciente()
        {
            InitializeComponent();
        }
        public FRM_ConsultaPaciente(string nome, string cpf)
        {
            InitializeComponent();
            this.Nome = nome;
            this.CPF = cpf;
        }
        FRM_Paciente frmPac;
        private void PBVoltar_Click(object sender, EventArgs e)
        {
            frmPac = new FRM_Paciente();
            frmPac.Show();
            this.Close();
        }

        private void FRM_ConsultaPaciente_Load(object sender, EventArgs e)
        {
            repository.SelectPaciente(CPF, Nome);
            DGV_ConsultaPaciente.Rows[0].Cells[0].Value = repository._nome;
            DGV_ConsultaPaciente.Rows[0].Cells[1].Value = repository._cpf;
            DGV_ConsultaPaciente.Rows[0].Cells[2].Value = repository._idade;
            DGV_ConsultaPaciente.Rows[0].Cells[3].Value = repository._sexo;
            DGV_ConsultaPaciente.Rows[0].Cells[4].Value = repository._telefone;
            DGV_ConsultaPaciente.Rows[0].Cells[5].Value = repository._endereco;
            //Realizar a consulta por CPF e Nome do Paciente! linhas 22 e 23
        }

        private void DGV_ConsultaPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPac = new FRM_Paciente(DGV_ConsultaPaciente.CurrentRow.Cells[0].Value.ToString(), 
                DGV_ConsultaPaciente.CurrentRow.Cells[1].Value.ToString(),
                int.Parse(DGV_ConsultaPaciente.CurrentRow.Cells[2].Value.ToString()),
                DGV_ConsultaPaciente.CurrentRow.Cells[3].Value.ToString(),
                DGV_ConsultaPaciente.CurrentRow.Cells[4].Value.ToString(),
                DGV_ConsultaPaciente.CurrentRow.Cells[5].Value.ToString());
            frmPac.Show();
            this.Close();
        }
    }
}
