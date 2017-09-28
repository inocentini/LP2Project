namespace WindowsFormsApplication2
{
    partial class wCadastro
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
            this.labNome = new System.Windows.Forms.Label();
            this.labCPF = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Location = new System.Drawing.Point(43, 63);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(38, 13);
            this.labNome.TabIndex = 0;
            this.labNome.Text = "Nome:";
            // 
            // labCPF
            // 
            this.labCPF.AutoSize = true;
            this.labCPF.Location = new System.Drawing.Point(51, 38);
            this.labCPF.Name = "labCPF";
            this.labCPF.Size = new System.Drawing.Size(30, 13);
            this.labCPF.TabIndex = 1;
            this.labCPF.Text = "CPF:";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(46, 88);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(35, 13);
            this.labEmail.TabIndex = 2;
            this.labEmail.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(290, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(93, 31);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(145, 20);
            this.txtCPF.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(93, 155);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 36);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(230, 155);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // labTelefone
            // 
            this.labTelefone.AutoSize = true;
            this.labTelefone.Location = new System.Drawing.Point(29, 114);
            this.labTelefone.Name = "labTelefone";
            this.labTelefone.Size = new System.Drawing.Size(52, 13);
            this.labTelefone.TabIndex = 8;
            this.labTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(93, 107);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(108, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // wCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 214);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.labTelefone);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labEmail);
            this.Controls.Add(this.labCPF);
            this.Controls.Add(this.labNome);
            this.Name = "wCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.wCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label labCPF;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
    }
}

