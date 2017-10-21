namespace HouseManager
{
    partial class FormCadastraConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastraConta));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labDetalhes = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.labNome = new System.Windows.Forms.Label();
            this.txtDetalhes = new System.Windows.Forms.MaskedTextBox();
            this.labValor = new System.Windows.Forms.Label();
            this.labVencimento = new System.Windows.Forms.Label();
            this.labResponsavel = new System.Windows.Forms.Label();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.panCadastro = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.NumericUpDown();
            this.txtVencimento = new System.Windows.Forms.TextBox();
            this.labReais = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.btnResponsavel = new System.Windows.Forms.Button();
            this.panCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(237, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.Location = new System.Drawing.Point(93, 160);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 36);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labDetalhes
            // 
            this.labDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDetalhes.AutoSize = true;
            this.labDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labDetalhes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labDetalhes.Location = new System.Drawing.Point(40, 43);
            this.labDetalhes.Name = "labDetalhes";
            this.labDetalhes.Size = new System.Drawing.Size(52, 13);
            this.labDetalhes.TabIndex = 14;
            this.labDetalhes.Text = "Detalhes:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(98, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(94, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // labNome
            // 
            this.labNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labNome.AutoSize = true;
            this.labNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labNome.Location = new System.Drawing.Point(54, 17);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(38, 13);
            this.labNome.TabIndex = 13;
            this.labNome.Text = "Nome:";
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalhes.Location = new System.Drawing.Point(98, 39);
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(229, 20);
            this.txtDetalhes.TabIndex = 2;
            this.txtDetalhes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // labValor
            // 
            this.labValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labValor.AutoSize = true;
            this.labValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labValor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labValor.Location = new System.Drawing.Point(40, 70);
            this.labValor.Name = "labValor";
            this.labValor.Size = new System.Drawing.Size(34, 13);
            this.labValor.TabIndex = 15;
            this.labValor.Text = "Valor:";
            // 
            // labVencimento
            // 
            this.labVencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labVencimento.AutoSize = true;
            this.labVencimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labVencimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labVencimento.Location = new System.Drawing.Point(26, 95);
            this.labVencimento.Name = "labVencimento";
            this.labVencimento.Size = new System.Drawing.Size(66, 13);
            this.labVencimento.TabIndex = 18;
            this.labVencimento.Text = "Vencimento:";
            // 
            // labResponsavel
            // 
            this.labResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labResponsavel.AutoSize = true;
            this.labResponsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labResponsavel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labResponsavel.Location = new System.Drawing.Point(20, 122);
            this.labResponsavel.Name = "labResponsavel";
            this.labResponsavel.Size = new System.Drawing.Size(72, 13);
            this.labResponsavel.TabIndex = 22;
            this.labResponsavel.Text = "Responsável:";
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimento.Location = new System.Drawing.Point(98, 91);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(122, 20);
            this.dtpVencimento.TabIndex = 4;
            // 
            // panCadastro
            // 
            this.panCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCadastro.Controls.Add(this.txtValor);
            this.panCadastro.Controls.Add(this.txtVencimento);
            this.panCadastro.Controls.Add(this.labReais);
            this.panCadastro.Controls.Add(this.txtResponsavel);
            this.panCadastro.Controls.Add(this.btnResponsavel);
            this.panCadastro.Controls.Add(this.txtNome);
            this.panCadastro.Controls.Add(this.btnCancelar);
            this.panCadastro.Controls.Add(this.btnSalvar);
            this.panCadastro.Controls.Add(this.labVencimento);
            this.panCadastro.Controls.Add(this.dtpVencimento);
            this.panCadastro.Controls.Add(this.labValor);
            this.panCadastro.Controls.Add(this.txtDetalhes);
            this.panCadastro.Controls.Add(this.labResponsavel);
            this.panCadastro.Controls.Add(this.labNome);
            this.panCadastro.Controls.Add(this.labDetalhes);
            this.panCadastro.Location = new System.Drawing.Point(1, 1);
            this.panCadastro.Name = "panCadastro";
            this.panCadastro.Size = new System.Drawing.Size(366, 207);
            this.panCadastro.TabIndex = 27;
            // 
            // txtValor
            // 
            this.txtValor.DecimalPlaces = 2;
            this.txtValor.Location = new System.Drawing.Point(98, 66);
            this.txtValor.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // txtVencimento
            // 
            this.txtVencimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVencimento.Location = new System.Drawing.Point(98, 91);
            this.txtVencimento.Name = "txtVencimento";
            this.txtVencimento.ReadOnly = true;
            this.txtVencimento.Size = new System.Drawing.Size(122, 20);
            this.txtVencimento.TabIndex = 31;
            this.txtVencimento.TabStop = false;
            this.txtVencimento.Visible = false;
            // 
            // labReais
            // 
            this.labReais.AutoSize = true;
            this.labReais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labReais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labReais.Location = new System.Drawing.Point(77, 68);
            this.labReais.Name = "labReais";
            this.labReais.Size = new System.Drawing.Size(21, 13);
            this.labReais.TabIndex = 30;
            this.labReais.Text = "R$";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponsavel.Location = new System.Drawing.Point(98, 118);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.ReadOnly = true;
            this.txtResponsavel.Size = new System.Drawing.Size(147, 20);
            this.txtResponsavel.TabIndex = 8;
            this.txtResponsavel.TabStop = false;
            // 
            // btnResponsavel
            // 
            this.btnResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResponsavel.Location = new System.Drawing.Point(252, 117);
            this.btnResponsavel.Name = "btnResponsavel";
            this.btnResponsavel.Size = new System.Drawing.Size(75, 23);
            this.btnResponsavel.TabIndex = 5;
            this.btnResponsavel.Text = "Buscar";
            this.btnResponsavel.UseVisualStyleBackColor = true;
            this.btnResponsavel.Click += new System.EventHandler(this.btnResponsavel_Click);
            // 
            // FormCadastraConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(369, 209);
            this.Controls.Add(this.panCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 248);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(385, 248);
            this.Name = "FormCadastraConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de conta";
            this.panCadastro.ResumeLayout(false);
            this.panCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labDetalhes;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.MaskedTextBox txtDetalhes;
        private System.Windows.Forms.Label labValor;
        private System.Windows.Forms.Label labVencimento;
        private System.Windows.Forms.Label labResponsavel;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.Panel panCadastro;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Button btnResponsavel;
        private System.Windows.Forms.Label labReais;
        private System.Windows.Forms.TextBox txtVencimento;
        private System.Windows.Forms.NumericUpDown txtValor;
    }
}