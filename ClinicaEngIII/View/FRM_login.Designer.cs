namespace ClinicaEngIII
{
    partial class FRM_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_login));
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.LabelSenha = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBSenha = new System.Windows.Forms.TextBox();
            this.BTEntrar = new System.Windows.Forms.Button();
            this.BTSair = new System.Windows.Forms.Button();
            this.LabelNomeClinica = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EsqueceSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(14, 97);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(127, 17);
            this.LabelUsuario.TabIndex = 0;
            this.LabelUsuario.Text = "Nome do Usúario*:";
            // 
            // LabelSenha
            // 
            this.LabelSenha.AutoSize = true;
            this.LabelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSenha.Location = new System.Drawing.Point(14, 139);
            this.LabelSenha.Name = "LabelSenha";
            this.LabelSenha.Size = new System.Drawing.Size(128, 17);
            this.LabelSenha.TabIndex = 0;
            this.LabelSenha.Text = "Senha de Acesso*:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(147, 94);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(170, 20);
            this.TBUsuario.TabIndex = 1;
            // 
            // TBSenha
            // 
            this.TBSenha.Location = new System.Drawing.Point(147, 136);
            this.TBSenha.Name = "TBSenha";
            this.TBSenha.PasswordChar = '*';
            this.TBSenha.Size = new System.Drawing.Size(170, 20);
            this.TBSenha.TabIndex = 2;
            // 
            // BTEntrar
            // 
            this.BTEntrar.Location = new System.Drawing.Point(142, 191);
            this.BTEntrar.Name = "BTEntrar";
            this.BTEntrar.Size = new System.Drawing.Size(75, 23);
            this.BTEntrar.TabIndex = 3;
            this.BTEntrar.Text = "Entrar";
            this.BTEntrar.UseVisualStyleBackColor = true;
            this.BTEntrar.Click += new System.EventHandler(this.BTEntrar_Click);
            // 
            // BTSair
            // 
            this.BTSair.Location = new System.Drawing.Point(237, 191);
            this.BTSair.Name = "BTSair";
            this.BTSair.Size = new System.Drawing.Size(75, 23);
            this.BTSair.TabIndex = 4;
            this.BTSair.Text = "Sair";
            this.BTSair.UseVisualStyleBackColor = true;
            this.BTSair.Click += new System.EventHandler(this.BTSair_Click);
            // 
            // LabelNomeClinica
            // 
            this.LabelNomeClinica.AutoSize = true;
            this.LabelNomeClinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeClinica.Location = new System.Drawing.Point(12, 31);
            this.LabelNomeClinica.Name = "LabelNomeClinica";
            this.LabelNomeClinica.Size = new System.Drawing.Size(219, 26);
            this.LabelNomeClinica.TabIndex = 5;
            this.LabelNomeClinica.Text = "Clínica Engenharia III";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // EsqueceSenha
            // 
            this.EsqueceSenha.AutoSize = true;
            this.EsqueceSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsqueceSenha.Location = new System.Drawing.Point(139, 161);
            this.EsqueceSenha.Name = "EsqueceSenha";
            this.EsqueceSenha.Size = new System.Drawing.Size(103, 13);
            this.EsqueceSenha.TabIndex = 7;
            this.EsqueceSenha.Text = "Esqueceu a Senha?";
            this.EsqueceSenha.Click += new System.EventHandler(this.EsqueceSenha_Click);
            // 
            // FRM_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(331, 235);
            this.Controls.Add(this.EsqueceSenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelNomeClinica);
            this.Controls.Add(this.BTSair);
            this.Controls.Add(this.BTEntrar);
            this.Controls.Add(this.TBSenha);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.LabelSenha);
            this.Controls.Add(this.LabelUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FRM_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUsuario;
        private System.Windows.Forms.Label LabelSenha;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBSenha;
        private System.Windows.Forms.Button BTEntrar;
        private System.Windows.Forms.Button BTSair;
        private System.Windows.Forms.Label LabelNomeClinica;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EsqueceSenha;
    }
}

