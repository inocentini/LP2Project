namespace WindowsFormsApplication2
{
    partial class FormCadastraLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastraLogin));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbNovoLogin = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.txtUser = new System.Windows.Forms.MaskedTextBox();
            this.labSenha = new System.Windows.Forms.Label();
            this.labUser = new System.Windows.Forms.Label();
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
            this.gbNovoLogin.Controls.Add(this.txtSenha);
            this.gbNovoLogin.Controls.Add(this.txtUser);
            this.gbNovoLogin.Controls.Add(this.labSenha);
            this.gbNovoLogin.Controls.Add(this.labUser);
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
            this.gbNovoLogin.Location = new System.Drawing.Point(7, 12);
            this.gbNovoLogin.Name = "gbNovoLogin";
            this.gbNovoLogin.Size = new System.Drawing.Size(367, 254);
            this.gbNovoLogin.TabIndex = 39;
            this.gbNovoLogin.TabStop = false;
            this.gbNovoLogin.Text = "Novo Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(74, 170);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(139, 20);
            this.txtSenha.TabIndex = 38;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPF_KeyDown);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(74, 140);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(139, 20);
            this.txtUser.TabIndex = 37;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPF_KeyDown);
            // 
            // labSenha
            // 
            this.labSenha.AutoSize = true;
            this.labSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.labSenha.Location = new System.Drawing.Point(29, 172);
            this.labSenha.Name = "labSenha";
            this.labSenha.Size = new System.Drawing.Size(41, 13);
            this.labSenha.TabIndex = 36;
            this.labSenha.Text = "Senha:";
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labUser.ForeColor = System.Drawing.SystemColors.Control;
            this.labUser.Location = new System.Drawing.Point(24, 143);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(46, 13);
            this.labUser.TabIndex = 35;
            this.labUser.Text = "Usuário:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(74, 20);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(85, 20);
            this.txtCPF.TabIndex = 31;
            this.txtCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPF_KeyDown);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(74, 110);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 34;
            this.txtTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPF_KeyDown);
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
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPF_KeyDown);
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
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPF_KeyDown);
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
            this.btnCancelar.Location = new System.Drawing.Point(195, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 36);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(74, 210);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 36);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FormCadastraLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(383, 278);
            this.Controls.Add(this.gbNovoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(399, 317);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(399, 317);
            this.Name = "FormCadastraLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo usuário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastraLogin_FormClosing);
            this.gbNovoLogin.ResumeLayout(false);
            this.gbNovoLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.MaskedTextBox txtUser;
        private System.Windows.Forms.Label labSenha;
        private System.Windows.Forms.Label labUser;
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