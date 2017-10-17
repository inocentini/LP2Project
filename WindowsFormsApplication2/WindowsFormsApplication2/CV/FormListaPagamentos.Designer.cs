namespace WindowsFormsApplication2
{
    partial class FormListaPagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaPagamentos));
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpbContas = new System.Windows.Forms.GroupBox();
            this.gpbPagamentos = new System.Windows.Forms.GroupBox();
            this.txtFiltrarContas = new System.Windows.Forms.TextBox();
            this.labFiltrar = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltrarPagamentos = new System.Windows.Forms.TextBox();
            this.labFiltrarPagamento = new System.Windows.Forms.Label();
            this.cbbTransacao = new System.Windows.Forms.ComboBox();
            this.labFiltrarSituacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbContas.SuspendLayout();
            this.gpbPagamentos.SuspendLayout();
            this.SuspendLayout();
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
            this.colDetalhes,
            this.colValor,
            this.colVencimento});
            this.dgvContas.Location = new System.Drawing.Point(0, 61);
            this.dgvContas.MultiSelect = false;
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.RowHeadersVisible = false;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(718, 228);
            this.dgvContas.TabIndex = 3;
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
            // colDetalhes
            // 
            this.colDetalhes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDetalhes.FillWeight = 150F;
            this.colDetalhes.HeaderText = "Detalhes";
            this.colDetalhes.Name = "colDetalhes";
            this.colDetalhes.ReadOnly = true;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.colSituacao});
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(718, 235);
            this.dataGridView1.TabIndex = 4;
            // 
            // gpbContas
            // 
            this.gpbContas.Controls.Add(this.txtFiltrarContas);
            this.gpbContas.Controls.Add(this.labFiltrar);
            this.gpbContas.Controls.Add(this.dgvContas);
            this.gpbContas.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbContas.Location = new System.Drawing.Point(0, 0);
            this.gpbContas.Name = "gpbContas";
            this.gpbContas.Size = new System.Drawing.Size(718, 296);
            this.gpbContas.TabIndex = 5;
            this.gpbContas.TabStop = false;
            this.gpbContas.Text = "Contas que você é responsável";
            // 
            // gpbPagamentos
            // 
            this.gpbPagamentos.Controls.Add(this.cbbTransacao);
            this.gpbPagamentos.Controls.Add(this.txtFiltrarPagamentos);
            this.gpbPagamentos.Controls.Add(this.labFiltrarSituacao);
            this.gpbPagamentos.Controls.Add(this.labFiltrarPagamento);
            this.gpbPagamentos.Controls.Add(this.dataGridView1);
            this.gpbPagamentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpbPagamentos.Location = new System.Drawing.Point(0, 303);
            this.gpbPagamentos.Name = "gpbPagamentos";
            this.gpbPagamentos.Size = new System.Drawing.Size(718, 328);
            this.gpbPagamentos.TabIndex = 6;
            this.gpbPagamentos.TabStop = false;
            this.gpbPagamentos.Text = "Seus pagamentos";
            // 
            // txtFiltrarContas
            // 
            this.txtFiltrarContas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrarContas.Location = new System.Drawing.Point(43, 26);
            this.txtFiltrarContas.Name = "txtFiltrarContas";
            this.txtFiltrarContas.Size = new System.Drawing.Size(672, 20);
            this.txtFiltrarContas.TabIndex = 10;
            // 
            // labFiltrar
            // 
            this.labFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFiltrar.AutoSize = true;
            this.labFiltrar.Location = new System.Drawing.Point(2, 29);
            this.labFiltrar.Name = "labFiltrar";
            this.labFiltrar.Size = new System.Drawing.Size(35, 13);
            this.labFiltrar.TabIndex = 11;
            this.labFiltrar.Text = "Filtrar:";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome da conta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.FillWeight = 80F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor a pagar";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.FillWeight = 60F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Vencimento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // colSituacao
            // 
            this.colSituacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSituacao.FillWeight = 40F;
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            // 
            // txtFiltrarPagamentos
            // 
            this.txtFiltrarPagamentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrarPagamentos.Location = new System.Drawing.Point(135, 19);
            this.txtFiltrarPagamentos.Name = "txtFiltrarPagamentos";
            this.txtFiltrarPagamentos.Size = new System.Drawing.Size(580, 20);
            this.txtFiltrarPagamentos.TabIndex = 12;
            // 
            // labFiltrarPagamento
            // 
            this.labFiltrarPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFiltrarPagamento.AutoSize = true;
            this.labFiltrarPagamento.Location = new System.Drawing.Point(2, 22);
            this.labFiltrarPagamento.Name = "labFiltrarPagamento";
            this.labFiltrarPagamento.Size = new System.Drawing.Size(127, 13);
            this.labFiltrarPagamento.TabIndex = 13;
            this.labFiltrarPagamento.Text = "Filtrar por nome da conta:";
            // 
            // cbbTransacao
            // 
            this.cbbTransacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTransacao.FormattingEnabled = true;
            this.cbbTransacao.Items.AddRange(new object[] {
            "Mostrar tudo",
            "Pagos",
            "Não pagos"});
            this.cbbTransacao.Location = new System.Drawing.Point(594, 52);
            this.cbbTransacao.Name = "cbbTransacao";
            this.cbbTransacao.Size = new System.Drawing.Size(121, 21);
            this.cbbTransacao.TabIndex = 14;
            // 
            // labFiltrarSituacao
            // 
            this.labFiltrarSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFiltrarSituacao.AutoSize = true;
            this.labFiltrarSituacao.Location = new System.Drawing.Point(492, 55);
            this.labFiltrarSituacao.Name = "labFiltrarSituacao";
            this.labFiltrarSituacao.Size = new System.Drawing.Size(96, 13);
            this.labFiltrarSituacao.TabIndex = 13;
            this.labFiltrarSituacao.Text = "Filtrar por situação:";
            // 
            // FormListaPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 631);
            this.Controls.Add(this.gpbContas);
            this.Controls.Add(this.gpbPagamentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaPagamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbContas.ResumeLayout(false);
            this.gpbContas.PerformLayout();
            this.gpbPagamentos.ResumeLayout(false);
            this.gpbPagamentos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVencimento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpbContas;
        private System.Windows.Forms.GroupBox gpbPagamentos;
        private System.Windows.Forms.TextBox txtFiltrarContas;
        private System.Windows.Forms.Label labFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
        private System.Windows.Forms.TextBox txtFiltrarPagamentos;
        private System.Windows.Forms.Label labFiltrarPagamento;
        private System.Windows.Forms.ComboBox cbbTransacao;
        private System.Windows.Forms.Label labFiltrarSituacao;
    }
}