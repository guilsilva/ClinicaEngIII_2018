namespace ClinicaEngIII
{
    partial class FRM_TrocaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_TrocaSenha));
            this.TBSenha = new System.Windows.Forms.TextBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.TBConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PBConfirmar = new System.Windows.Forms.PictureBox();
            this.PBCancelar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBConfirmar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // TBSenha
            // 
            this.TBSenha.Location = new System.Drawing.Point(239, 82);
            this.TBSenha.Name = "TBSenha";
            this.TBSenha.Size = new System.Drawing.Size(170, 20);
            this.TBSenha.TabIndex = 6;
            // 
            // TBUsuario
            // 
            this.TBUsuario.BackColor = System.Drawing.Color.White;
            this.TBUsuario.Enabled = false;
            this.TBUsuario.Location = new System.Drawing.Point(239, 41);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(170, 20);
            this.TBUsuario.TabIndex = 5;
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSenha.Location = new System.Drawing.Point(45, 83);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(160, 17);
            this.LabelSenha.TabIndex = 3;
            this.LabelSenha.Text = "Nova Senha de Acesso:";
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(45, 44);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(122, 17);
            this.LabelUsuario.TabIndex = 4;
            this.LabelUsuario.Text = "Nome do Usúario:";
            // 
            // TBConfirmaSenha
            // 
            this.TBConfirmaSenha.Location = new System.Drawing.Point(239, 122);
            this.TBConfirmaSenha.Name = "TBConfirmaSenha";
            this.TBConfirmaSenha.Size = new System.Drawing.Size(170, 20);
            this.TBConfirmaSenha.TabIndex = 8;
            this.TBConfirmaSenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Confirmar Senha de Acesso:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PBConfirmar
            // 
            this.PBConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("PBConfirmar.Image")));
            this.PBConfirmar.Location = new System.Drawing.Point(368, 148);
            this.PBConfirmar.Name = "PBConfirmar";
            this.PBConfirmar.Size = new System.Drawing.Size(30, 30);
            this.PBConfirmar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBConfirmar.TabIndex = 9;
            this.PBConfirmar.TabStop = false;
            this.PBConfirmar.Click += new System.EventHandler(this.PBConfirmar_Click);
            // 
            // PBCancelar
            // 
            this.PBCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBCancelar.BackgroundImage")));
            this.PBCancelar.Image = ((System.Drawing.Image)(resources.GetObject("PBCancelar.Image")));
            this.PBCancelar.Location = new System.Drawing.Point(332, 148);
            this.PBCancelar.Name = "PBCancelar";
            this.PBCancelar.Size = new System.Drawing.Size(30, 30);
            this.PBCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBCancelar.TabIndex = 10;
            this.PBCancelar.TabStop = false;
            this.PBCancelar.Click += new System.EventHandler(this.PBCancelar_Click);
            // 
            // FRM_TrocaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(438, 212);
            this.Controls.Add(this.PBCancelar);
            this.Controls.Add(this.PBConfirmar);
            this.Controls.Add(this.TBConfirmaSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBSenha);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.LabelUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_TrocaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Troca de Senha";
            this.Load += new System.EventHandler(this.FRM_TrocaSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBConfirmar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBSenha;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.TextBox TBConfirmaSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBConfirmar;
        private System.Windows.Forms.PictureBox PBCancelar;
    }
}