﻿using System;
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
    public partial class FRM_Consulta : Form
    {
        ManipulacoesTelas mt = new ManipulacoesTelas();
        bool update = false;
        FRM_ConsultaConsultas frmConsCons;

        public FRM_Consulta()
        {
            InitializeComponent();
        }

        public FRM_Consulta(string nomePac, string nomeMed, string sala, string tipoCons, string dtHr, 
            string tipoExame, string receita)
        {
            InitializeComponent();
            TBNomeMedico.Text = nomeMed;
            TBNomePaciente.Text = nomePac;
            TBSala.Text = sala;
            TBReceita.Text = receita;
            TBTipoConsulta.Text = tipoCons;
            TBDataHora.Text = dtHr;
            TBTipoExame.Text = tipoExame;
        }
        private void PBLimpar_Click(object sender, EventArgs e)
        {
            mt.limparTextBoxes(Controls);
        }
        private void FRM_Consulta_Load(object sender, EventArgs e)
        {
            //PBEditar.Visible = false;
            PBCancelar.Visible = false;
        }
        private void PBEditar_Click(object sender, EventArgs e)
        {
            PBEditar.Visible = false;
            PBCancelar.Visible = true;
            mt.AlterarEdicaoTextBoxes(Controls, true);
            update = true;
        }
        private void PBConfirmar_Click(object sender, EventArgs e)
        {
            Consulta cons = new Consulta(int.Parse(TBSala.Text.ToString()), TBTipoConsulta.Text.ToString(), TBDataHora.Text.ToString(),
                TBTipoExame.Text.ToString(), TBReceita.Text.ToString(), TBNomeMedico.Text.ToString(), TBNomePaciente.Text.ToString());
            //Salva os dados no banco
            if (update && mt.VerificaTextBoxesPreenchidas(Controls))
            {
                MessageBox.Show("Dados alterados com sucesso", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else if(!update && mt.VerificaTextBoxesPreenchidas(Controls))
            {
                MessageBox.Show("Dados alterados com sucesso", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dados obrigatórios não foram preenchidos!", "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void PBCancelar_Click(object sender, EventArgs e)
        {
            PBCancelar.Visible = false;
            PBEditar.Visible = true;
            mt.AlterarEdicaoTextBoxes(Controls, false);
        }

        private void PBPesquisar_Click(object sender, EventArgs e)
        {
            if (TBNomeMedico.Text == String.Empty || TBNomePaciente.Text == String.Empty)
            {
                MessageBox.Show("Campos obrigatórios para pesquisa não informados!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmConsCons = 
                    new FRM_ConsultaConsultas(TBNomeMedico.Text.ToString(), TBNomePaciente.Text.ToString());
                frmConsCons.Show();
                this.Close();
            }
        }
    }
}