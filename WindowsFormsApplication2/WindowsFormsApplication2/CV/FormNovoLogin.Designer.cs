namespace WindowsFormsApplication2
{
    partial class FormNovoLogin
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbNovoLogin = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.txtUser = new System.Windows.Forms.MaskedTextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.labCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.labNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.labTelefone = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbNovoLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNovoLogin
            // 
            this.gbNovoLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNovoLogin.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.O7MF5N0;
            this.gbNovoLogin.Controls.Add(this.maskedTextBox2);
            this.gbNovoLogin.Controls.Add(this.txtUser);
            this.gbNovoLogin.Controls.Add(this.lbSenha);
            this.gbNovoLogin.Controls.Add(this.lbUser);
            this.gbNovoLogin.Controls.Add(this.txtCPF);
            this.gbNovoLogin.Controls.Add(this.txtTelefone);
            this.gbNovoLogin.Controls.Add(this.labCPF);
            this.gbNovoLogin.Controls.Add(this.txtEmail);
            this.gbNovoLogin.Controls.Add(this.labNome);
            this.gbNovoLogin.Controls.Add(this.txtNome);
            this.gbNovoLogin.Controls.Add(this.labEmail);
            this.gbNovoLogin.Controls.Add(this.labTelefone);
            this.gbNovoLogin.Controls.Add(this.btnCancelar);
            this.gbNovoLogin.Controls.Add(this.btnSalvar);
            this.gbNovoLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.gbNovoLogin.Location = new System.Drawing.Point(4, 12);
            this.gbNovoLogin.Name = "gbNovoLogin";
            this.gbNovoLogin.Size = new System.Drawing.Size(355, 289);
            this.gbNovoLogin.TabIndex = 39;
            this.gbNovoLogin.TabStop = false;
            this.gbNovoLogin.Text = "Novo Usuário";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(74, 170);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PasswordChar = '•';
            this.maskedTextBox2.Size = new System.Drawing.Size(139, 20);
            this.maskedTextBox2.TabIndex = 38;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(74, 140);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(139, 20);
            this.txtUser.TabIndex = 37;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbSenha.Location = new System.Drawing.Point(29, 172);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 36;
            this.lbSenha.Text = "Senha:";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUser.Location = new System.Drawing.Point(24, 143);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(46, 13);
            this.lbUser.TabIndex = 35;
            this.lbUser.Text = "Usuário:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(74, 20);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(85, 20);
            this.txtCPF.TabIndex = 31;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(74, 110);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 34;
            // 
            // labCPF
            // 
            this.labCPF.AutoSize = true;
            this.labCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labCPF.ForeColor = System.Drawing.SystemColors.Control;
            this.labCPF.Location = new System.Drawing.Point(40, 27);
            this.labCPF.Name = "labCPF";
            this.labCPF.Size = new System.Drawing.Size(30, 13);
            this.labCPF.TabIndex = 28;
            this.labCPF.Text = "CPF:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 33;
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labNome.ForeColor = System.Drawing.SystemColors.Control;
            this.labNome.Location = new System.Drawing.Point(32, 56);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(38, 13);
            this.labNome.TabIndex = 27;
            this.labNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 20);
            this.txtNome.TabIndex = 32;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.labEmail.Location = new System.Drawing.Point(35, 85);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(35, 13);
            this.labEmail.TabIndex = 29;
            this.labEmail.Text = "Email:";
            // 
            // labTelefone
            // 
            this.labTelefone.AutoSize = true;
            this.labTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labTelefone.ForeColor = System.Drawing.SystemColors.Control;
            this.labTelefone.Location = new System.Drawing.Point(18, 114);
            this.labTelefone.Name = "labTelefone";
            this.labTelefone.Size = new System.Drawing.Size(52, 13);
            this.labTelefone.TabIndex = 30;
            this.labTelefone.Text = "Telefone:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(195, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(74, 228);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 36);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormNovoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(60)))), ((int)(((byte)(59)))));
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.O7MF5N0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(371, 314);
            this.Controls.Add(this.gbNovoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 380);
            this.MinimizeBox = false;
            this.Name = "FormNovoLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNovoLogin";
            this.gbNovoLogin.ResumeLayout(false);
            this.gbNovoLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox txtUser;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label labCPF;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labTelefone;
        private System.Windows.Forms.GroupBox gbNovoLogin;
    }
}