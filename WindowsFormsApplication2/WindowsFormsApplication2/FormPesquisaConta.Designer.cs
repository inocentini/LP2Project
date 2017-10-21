namespace WindowsFormsApplication2
{
    partial class FormPesquisaConta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.labFiltrar = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.labPessoas = new System.Windows.Forms.Label();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFiltrar);
            this.panel1.Controls.Add(this.labFiltrar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.labPessoas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 423);
            this.panel1.TabIndex = 1;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.Location = new System.Drawing.Point(46, 12);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(424, 20);
            this.txtFiltrar.TabIndex = 1;
            // 
            // labFiltrar
            // 
            this.labFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFiltrar.AutoSize = true;
            this.labFiltrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labFiltrar.Location = new System.Drawing.Point(5, 15);
            this.labFiltrar.Name = "labFiltrar";
            this.labFiltrar.Size = new System.Drawing.Size(35, 13);
            this.labFiltrar.TabIndex = 12;
            this.labFiltrar.Text = "Filtrar:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(314, 356);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 43);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(69, 356);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(88, 43);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // labPessoas
            // 
            this.labPessoas.AutoSize = true;
            this.labPessoas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labPessoas.Location = new System.Drawing.Point(3, 50);
            this.labPessoas.Name = "labPessoas";
            this.labPessoas.Size = new System.Drawing.Size(50, 13);
            this.labPessoas.TabIndex = 11;
            this.labPessoas.Text = "Pessoas:";
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.AllowUserToResizeRows = false;
            this.dgvContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colValor,
            this.colVencimento,
            this.colResponsavel});
            this.dgvContas.Location = new System.Drawing.Point(20, 78);
            this.dgvContas.MultiSelect = false;
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.RowHeadersVisible = false;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(462, 275);
            this.dgvContas.TabIndex = 13;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colID.FillWeight = 30F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValor.FillWeight = 80F;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colVencimento
            // 
            this.colVencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVencimento.FillWeight = 60F;
            this.colVencimento.HeaderText = "Vencimento";
            this.colVencimento.Name = "colVencimento";
            this.colVencimento.ReadOnly = true;
            // 
            // colResponsavel
            // 
            this.colResponsavel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colResponsavel.HeaderText = "Responsável";
            this.colResponsavel.Name = "colResponsavel";
            this.colResponsavel.ReadOnly = true;
            // 
            // FormPesquisaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 446);
            this.Controls.Add(this.dgvContas);
            this.Controls.Add(this.panel1);
            this.Name = "FormPesquisaConta";
            this.Text = "FormPesquisaConta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label labFiltrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label labPessoas;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResponsavel;
    }
}