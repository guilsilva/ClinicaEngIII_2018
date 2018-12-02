namespace ClinicaEngIII
{
    partial class FRM_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_MenuPrincipal));
            this.BTMedico = new System.Windows.Forms.Button();
            this.BTPaciente = new System.Windows.Forms.Button();
            this.BTSecretaria = new System.Windows.Forms.Button();
            this.BTAnamnese = new System.Windows.Forms.Button();
            this.BTConsulta = new System.Windows.Forms.Button();
            this.BTExame = new System.Windows.Forms.Button();
            this.BTMateriais = new System.Windows.Forms.Button();
            this.BTLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTMedico
            // 
            this.BTMedico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTMedico.BackgroundImage")));
            this.BTMedico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTMedico.Location = new System.Drawing.Point(66, 60);
            this.BTMedico.Name = "BTMedico";
            this.BTMedico.Size = new System.Drawing.Size(115, 115);
            this.BTMedico.TabIndex = 0;
            this.BTMedico.UseVisualStyleBackColor = true;
            this.BTMedico.Click += new System.EventHandler(this.BTMedico_Click);
            // 
            // BTPaciente
            // 
            this.BTPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTPaciente.BackgroundImage")));
            this.BTPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTPaciente.Location = new System.Drawing.Point(233, 60);
            this.BTPaciente.Name = "BTPaciente";
            this.BTPaciente.Size = new System.Drawing.Size(115, 115);
            this.BTPaciente.TabIndex = 1;
            this.BTPaciente.UseVisualStyleBackColor = true;
            this.BTPaciente.Click += new System.EventHandler(this.BTPaciente_Click);
            // 
            // BTSecretaria
            // 
            this.BTSecretaria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTSecretaria.BackgroundImage")));
            this.BTSecretaria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTSecretaria.Location = new System.Drawing.Point(387, 60);
            this.BTSecretaria.Name = "BTSecretaria";
            this.BTSecretaria.Size = new System.Drawing.Size(115, 115);
            this.BTSecretaria.TabIndex = 2;
            this.BTSecretaria.UseVisualStyleBackColor = true;
            this.BTSecretaria.Click += new System.EventHandler(this.BTSecretaria_Click);
            // 
            // BTAnamnese
            // 
            this.BTAnamnese.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTAnamnese.BackgroundImage")));
            this.BTAnamnese.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTAnamnese.Location = new System.Drawing.Point(387, 208);
            this.BTAnamnese.Name = "BTAnamnese";
            this.BTAnamnese.Size = new System.Drawing.Size(115, 115);
            this.BTAnamnese.TabIndex = 3;
            this.BTAnamnese.UseVisualStyleBackColor = true;
            this.BTAnamnese.Click += new System.EventHandler(this.BTAnamnese_Click);
            // 
            // BTConsulta
            // 
            this.BTConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTConsulta.BackgroundImage")));
            this.BTConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTConsulta.Location = new System.Drawing.Point(547, 60);
            this.BTConsulta.Name = "BTConsulta";
            this.BTConsulta.Size = new System.Drawing.Size(115, 115);
            this.BTConsulta.TabIndex = 4;
            this.BTConsulta.UseVisualStyleBackColor = true;
            this.BTConsulta.Click += new System.EventHandler(this.BTConsulta_Click);
            // 
            // BTExame
            // 
            this.BTExame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTExame.BackgroundImage")));
            this.BTExame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTExame.Location = new System.Drawing.Point(66, 208);
            this.BTExame.Name = "BTExame";
            this.BTExame.Size = new System.Drawing.Size(115, 115);
            this.BTExame.TabIndex = 5;
            this.BTExame.UseVisualStyleBackColor = true;
            this.BTExame.Click += new System.EventHandler(this.BTExame_Click);
            // 
            // BTMateriais
            // 
            this.BTMateriais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTMateriais.BackgroundImage")));
            this.BTMateriais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTMateriais.Location = new System.Drawing.Point(233, 208);
            this.BTMateriais.Name = "BTMateriais";
            this.BTMateriais.Size = new System.Drawing.Size(115, 115);
            this.BTMateriais.TabIndex = 6;
            this.BTMateriais.UseVisualStyleBackColor = false;
            this.BTMateriais.Click += new System.EventHandler(this.BTMateriais_Click);
            // 
            // BTLogout
            // 
            this.BTLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTLogout.BackgroundImage")));
            this.BTLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTLogout.Location = new System.Drawing.Point(547, 208);
            this.BTLogout.Name = "BTLogout";
            this.BTLogout.Size = new System.Drawing.Size(115, 115);
            this.BTLogout.TabIndex = 9;
            this.BTLogout.UseVisualStyleBackColor = true;
            this.BTLogout.Click += new System.EventHandler(this.BTLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(620, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FRM_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTLogout);
            this.Controls.Add(this.BTMateriais);
            this.Controls.Add(this.BTExame);
            this.Controls.Add(this.BTConsulta);
            this.Controls.Add(this.BTAnamnese);
            this.Controls.Add(this.BTSecretaria);
            this.Controls.Add(this.BTPaciente);
            this.Controls.Add(this.BTMedico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FRM_MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTMedico;
        private System.Windows.Forms.Button BTPaciente;
        private System.Windows.Forms.Button BTSecretaria;
        private System.Windows.Forms.Button BTAnamnese;
        private System.Windows.Forms.Button BTConsulta;
        private System.Windows.Forms.Button BTExame;
        private System.Windows.Forms.Button BTMateriais;
        private System.Windows.Forms.Button BTLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}