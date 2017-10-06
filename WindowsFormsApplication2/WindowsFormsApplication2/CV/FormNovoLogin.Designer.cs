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
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labCPF = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.labNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.labEmail = new System.Windows.Forms.Label();
            this.labTelefone = new System.Windows.Forms.Label();
            this.lbNovoLogin = new System.Windows.Forms.Label();
            this.pnDados = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.pnDados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.Location = new System.Drawing.Point(66, 4);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(119, 20);
            this.txtCPF.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(141, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.Location = new System.Drawing.Point(66, 97);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(119, 20);
            this.txtTelefone.TabIndex = 22;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(20, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 36);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labCPF
            // 
            this.labCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labCPF.AutoSize = true;
            this.labCPF.Location = new System.Drawing.Point(32, 11);
            this.labCPF.Name = "labCPF";
            this.labCPF.Size = new System.Drawing.Size(30, 13);
            this.labCPF.TabIndex = 14;
            this.labCPF.Text = "CPF:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(66, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // labNome
            // 
            this.labNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labNome.AutoSize = true;
            this.labNome.Location = new System.Drawing.Point(24, 35);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(38, 13);
            this.labNome.TabIndex = 13;
            this.labNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(66, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 20);
            this.txtNome.TabIndex = 20;
            // 
            // labEmail
            // 
            this.labEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(27, 69);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(35, 13);
            this.labEmail.TabIndex = 15;
            this.labEmail.Text = "Email:";
            // 
            // labTelefone
            // 
            this.labTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labTelefone.AutoSize = true;
            this.labTelefone.Location = new System.Drawing.Point(10, 97);
            this.labTelefone.Name = "labTelefone";
            this.labTelefone.Size = new System.Drawing.Size(52, 13);
            this.labTelefone.TabIndex = 18;
            this.labTelefone.Text = "Telefone:";
            // 
            // lbNovoLogin
            // 
            this.lbNovoLogin.AutoSize = true;
            this.lbNovoLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNovoLogin.Location = new System.Drawing.Point(18, 7);
            this.lbNovoLogin.Name = "lbNovoLogin";
            this.lbNovoLogin.Size = new System.Drawing.Size(151, 31);
            this.lbNovoLogin.TabIndex = 23;
            this.lbNovoLogin.Text = "Novo Login";
            // 
            // pnDados
            // 
            this.pnDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnDados.Controls.Add(this.maskedTextBox2);
            this.pnDados.Controls.Add(this.txtUser);
            this.pnDados.Controls.Add(this.lbSenha);
            this.pnDados.Controls.Add(this.lbUser);
            this.pnDados.Controls.Add(this.txtCPF);
            this.pnDados.Controls.Add(this.txtTelefone);
            this.pnDados.Controls.Add(this.labCPF);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.labNome);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.labEmail);
            this.pnDados.Controls.Add(this.labTelefone);
            this.pnDados.Location = new System.Drawing.Point(17, 61);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(336, 200);
            this.pnDados.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(61, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 42);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lbNovoLogin);
            this.panel2.Location = new System.Drawing.Point(96, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 47);
            this.panel2.TabIndex = 26;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(16, 132);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(46, 13);
            this.lbUser.TabIndex = 23;
            this.lbUser.Text = "Usuário:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(21, 160);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 24;
            this.lbSenha.Text = "Senha:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(68, 129);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 25;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(66, 155);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PasswordChar = '•';
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 26;
            // 
            // FormNovoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnDados);
            this.Name = "FormNovoLogin";
            this.Text = "FormNovoLogin";
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labCPF;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labTelefone;
        private System.Windows.Forms.Label lbNovoLogin;
        private System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.MaskedTextBox txtUser;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
    }
}