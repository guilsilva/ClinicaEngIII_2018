namespace ClinicaEngIII
{
    partial class FRM_ConsultaExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ConsultaExame));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PBVoltar = new System.Windows.Forms.PictureBox();
            this.DGV_ConsultaAnamnese = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PBVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ConsultaAnamnese)).BeginInit();
            this.SuspendLayout();
            // 
            // PBVoltar
            // 
            this.PBVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBVoltar.BackgroundImage")));
            this.PBVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBVoltar.Location = new System.Drawing.Point(254, 236);
            this.PBVoltar.Name = "PBVoltar";
            this.PBVoltar.Size = new System.Drawing.Size(30, 30);
            this.PBVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBVoltar.TabIndex = 44;
            this.PBVoltar.TabStop = false;
            // 
            // DGV_ConsultaAnamnese
            // 
            this.DGV_ConsultaAnamnese.AllowUserToOrderColumns = true;
            this.DGV_ConsultaAnamnese.BackgroundColor = System.Drawing.Color.White;
            this.DGV_ConsultaAnamnese.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_ConsultaAnamnese.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ConsultaAnamnese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ConsultaAnamnese.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_ConsultaAnamnese.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_ConsultaAnamnese.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.DGV_ConsultaAnamnese.Location = new System.Drawing.Point(40, 41);
            this.DGV_ConsultaAnamnese.Name = "DGV_ConsultaAnamnese";
            this.DGV_ConsultaAnamnese.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV_ConsultaAnamnese.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ConsultaAnamnese.Size = new System.Drawing.Size(244, 189);
            this.DGV_ConsultaAnamnese.TabIndex = 43;
            // 
            // FRM_ConsultaExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(325, 288);
            this.Controls.Add(this.PBVoltar);
            this.Controls.Add(this.DGV_ConsultaAnamnese);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_ConsultaExame";
            this.Text = "Consulta Exame";
            ((System.ComponentModel.ISupportInitialize)(this.PBVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ConsultaAnamnese)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBVoltar;
        private System.Windows.Forms.DataGridView DGV_ConsultaAnamnese;
    }
}