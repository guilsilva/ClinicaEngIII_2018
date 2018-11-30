namespace ClinicaEngIII
{
    partial class FRM_ConsultaAnamnese
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ConsultaAnamnese));
            this.DGV_ConsultaAnamnese = new System.Windows.Forms.DataGridView();
            this.PBVoltar = new System.Windows.Forms.PictureBox();
            this.NomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ConsultaAnamnese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_ConsultaAnamnese
            // 
            this.DGV_ConsultaAnamnese.AllowUserToOrderColumns = true;
            this.DGV_ConsultaAnamnese.BackgroundColor = System.Drawing.Color.White;
            this.DGV_ConsultaAnamnese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_ConsultaAnamnese.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ConsultaAnamnese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ConsultaAnamnese.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomePaciente,
            this.CPF_Paciente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ConsultaAnamnese.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_ConsultaAnamnese.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_ConsultaAnamnese.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.DGV_ConsultaAnamnese.Location = new System.Drawing.Point(12, 64);
            this.DGV_ConsultaAnamnese.Name = "DGV_ConsultaAnamnese";
            this.DGV_ConsultaAnamnese.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ConsultaAnamnese.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ConsultaAnamnese.Size = new System.Drawing.Size(776, 305);
            this.DGV_ConsultaAnamnese.TabIndex = 0;
            this.DGV_ConsultaAnamnese.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ConsultaAnamnese_CellContentClick);
            // 
            // PBVoltar
            // 
            this.PBVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBVoltar.BackgroundImage")));
            this.PBVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBVoltar.Location = new System.Drawing.Point(758, 395);
            this.PBVoltar.Name = "PBVoltar";
            this.PBVoltar.Size = new System.Drawing.Size(30, 30);
            this.PBVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBVoltar.TabIndex = 42;
            this.PBVoltar.TabStop = false;
            this.PBVoltar.Click += new System.EventHandler(this.PBVoltar_Click);
            // 
            // NomePaciente
            // 
            this.NomePaciente.Frozen = true;
            this.NomePaciente.HeaderText = "Nome do Paciente";
            this.NomePaciente.Name = "NomePaciente";
            this.NomePaciente.ReadOnly = true;
            // 
            // CPF_Paciente
            // 
            this.CPF_Paciente.Frozen = true;
            this.CPF_Paciente.HeaderText = "CPF do Paciente";
            this.CPF_Paciente.Name = "CPF_Paciente";
            this.CPF_Paciente.ReadOnly = true;
            // 
            // FRM_ConsultaAnamnese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PBVoltar);
            this.Controls.Add(this.DGV_ConsultaAnamnese);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_ConsultaAnamnese";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Anamnese";
            this.Load += new System.EventHandler(this.FRM_ConsultaAnamnese_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ConsultaAnamnese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBVoltar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_ConsultaAnamnese;
        private System.Windows.Forms.PictureBox PBVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_Paciente;
    }
}