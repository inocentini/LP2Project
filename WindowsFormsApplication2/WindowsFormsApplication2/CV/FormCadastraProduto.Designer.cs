﻿namespace HouseManager
{
    partial class FormCadastraProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastraProduto));
            this.panCadastro = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labQuantidade = new System.Windows.Forms.Label();
            this.txtDetalhes = new System.Windows.Forms.MaskedTextBox();
            this.labNome = new System.Windows.Forms.Label();
            this.labDetalhes = new System.Windows.Forms.Label();
            this.panCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panCadastro
            // 
            this.panCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCadastro.Controls.Add(this.txtQuantidade);
            this.panCadastro.Controls.Add(this.txtNome);
            this.panCadastro.Controls.Add(this.btnCancelar);
            this.panCadastro.Controls.Add(this.btnSalvar);
            this.panCadastro.Controls.Add(this.labQuantidade);
            this.panCadastro.Controls.Add(this.txtDetalhes);
            this.panCadastro.Controls.Add(this.labNome);
            this.panCadastro.Controls.Add(this.labDetalhes);
            this.panCadastro.Location = new System.Drawing.Point(1, 2);
            this.panCadastro.Name = "panCadastro";
            this.panCadastro.Size = new System.Drawing.Size(309, 159);
            this.panCadastro.TabIndex = 28;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DecimalPlaces = 2;
            this.txtQuantidade.Location = new System.Drawing.Point(98, 69);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(120, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(98, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(141, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(146, 112);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.Location = new System.Drawing.Point(35, 112);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 36);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labQuantidade
            // 
            this.labQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labQuantidade.AutoSize = true;
            this.labQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labQuantidade.ForeColor = System.Drawing.Color.Black;
            this.labQuantidade.Location = new System.Drawing.Point(27, 73);
            this.labQuantidade.Name = "labQuantidade";
            this.labQuantidade.Size = new System.Drawing.Size(65, 13);
            this.labQuantidade.TabIndex = 15;
            this.labQuantidade.Text = "Quantidade:";
            // 
            // txtDetalhes
            // 
            this.txtDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalhes.Location = new System.Drawing.Point(98, 41);
            this.txtDetalhes.Name = "txtDetalhes";
            this.txtDetalhes.Size = new System.Drawing.Size(191, 20);
            this.txtDetalhes.TabIndex = 2;
            this.txtDetalhes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // labNome
            // 
            this.labNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labNome.AutoSize = true;
            this.labNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labNome.ForeColor = System.Drawing.Color.Black;
            this.labNome.Location = new System.Drawing.Point(54, 17);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(38, 13);
            this.labNome.TabIndex = 13;
            this.labNome.Text = "Nome:";
            // 
            // labDetalhes
            // 
            this.labDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDetalhes.AutoSize = true;
            this.labDetalhes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labDetalhes.ForeColor = System.Drawing.Color.Black;
            this.labDetalhes.Location = new System.Drawing.Point(40, 45);
            this.labDetalhes.Name = "labDetalhes";
            this.labDetalhes.Size = new System.Drawing.Size(52, 13);
            this.labDetalhes.TabIndex = 14;
            this.labDetalhes.Text = "Detalhes:";
            // 
            // FormCadastraProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 160);
            this.Controls.Add(this.panCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(329, 199);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(329, 199);
            this.Name = "FormCadastraProduto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panCadastro.ResumeLayout(false);
            this.panCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCadastro;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labQuantidade;
        private System.Windows.Forms.MaskedTextBox txtDetalhes;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label labDetalhes;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
    }
}