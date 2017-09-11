namespace WindowsFormsApplication2
{
    partial class Login
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
            this.labUser = new System.Windows.Forms.Label();
            this.labSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Location = new System.Drawing.Point(52, 68);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(32, 13);
            this.labUser.TabIndex = 0;
            this.labUser.Text = "User:";
            // 
            // labSenha
            // 
            this.labSenha.AutoSize = true;
            this.labSenha.Location = new System.Drawing.Point(52, 102);
            this.labSenha.Name = "labSenha";
            this.labSenha.Size = new System.Drawing.Size(41, 13);
            this.labSenha.TabIndex = 1;
            this.labSenha.Text = "Senha:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(55, 151);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(73, 46);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(164, 151);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 46);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(93, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // labLogin
            // 
            this.labLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labLogin.Location = new System.Drawing.Point(109, 18);
            this.labLogin.Name = "labLogin";
            this.labLogin.Size = new System.Drawing.Size(86, 37);
            this.labLogin.TabIndex = 6;
            this.labLogin.Text = "Login";
            this.labLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.labSenha);
            this.Controls.Add(this.labUser);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labLogin;
    }
}