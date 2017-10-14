namespace WindowsFormsApplication2
{
    partial class FormListaTransacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaTransacoes));
            this.dgvComprasEVendas = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.labFiltrar = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.bntDetalhes = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.cbbTransacao = new System.Windows.Forms.ComboBox();
            this.labFiltrarCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComprasEVendas
            // 
            this.dgvComprasEVendas.AllowUserToAddRows = false;
            this.dgvComprasEVendas.AllowUserToDeleteRows = false;
            this.dgvComprasEVendas.AllowUserToResizeRows = false;
            this.dgvComprasEVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComprasEVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasEVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colData,
            this.colProds,
            this.colValor,
            this.colCompra});
            this.dgvComprasEVendas.Location = new System.Drawing.Point(0, 78);
            this.dgvComprasEVendas.Name = "dgvComprasEVendas";
            this.dgvComprasEVendas.RowHeadersVisible = false;
            this.dgvComprasEVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprasEVendas.Size = new System.Drawing.Size(856, 254);
            this.dgvComprasEVendas.TabIndex = 2;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.FillWeight = 30F;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            // 
            // colData
            // 
            this.colData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            // 
            // colProds
            // 
            this.colProds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProds.FillWeight = 150F;
            this.colProds.HeaderText = "Produto(s)";
            this.colProds.Name = "colProds";
            // 
            // colValor
            // 
            this.colValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValor.FillWeight = 60F;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            // 
            // colCompra
            // 
            this.colCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCompra.FillWeight = 60F;
            this.colCompra.HeaderText = "Tipo da transação";
            this.colCompra.Name = "colCompra";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.Location = new System.Drawing.Point(103, 7);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(745, 20);
            this.txtFiltrar.TabIndex = 3;
            this.txtFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrar_KeyUp);
            // 
            // labFiltrar
            // 
            this.labFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFiltrar.AutoSize = true;
            this.labFiltrar.Location = new System.Drawing.Point(5, 11);
            this.labFiltrar.Name = "labFiltrar";
            this.labFiltrar.Size = new System.Drawing.Size(92, 13);
            this.labFiltrar.TabIndex = 4;
            this.labFiltrar.Text = "Filtrar por produto:";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemover.Location = new System.Drawing.Point(504, 357);
            this.btnRemover.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // bntDetalhes
            // 
            this.bntDetalhes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntDetalhes.Location = new System.Drawing.Point(423, 357);
            this.bntDetalhes.MaximumSize = new System.Drawing.Size(75, 23);
            this.bntDetalhes.Name = "bntDetalhes";
            this.bntDetalhes.Size = new System.Drawing.Size(75, 23);
            this.bntDetalhes.TabIndex = 9;
            this.bntDetalhes.Text = "Detalhes";
            this.bntDetalhes.UseVisualStyleBackColor = true;
            this.bntDetalhes.Click += new System.EventHandler(this.bntDetalhes_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntEditar.Location = new System.Drawing.Point(342, 357);
            this.bntEditar.MaximumSize = new System.Drawing.Size(75, 23);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(75, 23);
            this.bntEditar.TabIndex = 8;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntAdd.Location = new System.Drawing.Point(261, 357);
            this.bntAdd.MaximumSize = new System.Drawing.Size(75, 23);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 7;
            this.bntAdd.Text = "Adicionar";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // cbbTransacao
            // 
            this.cbbTransacao.FormattingEnabled = true;
            this.cbbTransacao.Items.AddRange(new object[] {
            "Mostrar tudo",
            "Compra",
            "Uso"});
            this.cbbTransacao.Location = new System.Drawing.Point(727, 42);
            this.cbbTransacao.Name = "cbbTransacao";
            this.cbbTransacao.Size = new System.Drawing.Size(121, 21);
            this.cbbTransacao.TabIndex = 11;
            this.cbbTransacao.SelectedIndexChanged += new System.EventHandler(this.cbbTransacao_SelectedIndexChanged);
            // 
            // labFiltrarCompra
            // 
            this.labFiltrarCompra.AutoSize = true;
            this.labFiltrarCompra.BackColor = System.Drawing.SystemColors.Control;
            this.labFiltrarCompra.Location = new System.Drawing.Point(618, 46);
            this.labFiltrarCompra.Name = "labFiltrarCompra";
            this.labFiltrarCompra.Size = new System.Drawing.Size(103, 13);
            this.labFiltrarCompra.TabIndex = 12;
            this.labFiltrarCompra.Text = "Filtrar por transação:";
            // 
            // FormListaTransacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 392);
            this.Controls.Add(this.labFiltrarCompra);
            this.Controls.Add(this.cbbTransacao);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.bntDetalhes);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.labFiltrar);
            this.Controls.Add(this.dgvComprasEVendas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaTransacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEstoque_FormClosing);
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComprasEVendas;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label labFiltrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button bntDetalhes;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.ComboBox cbbTransacao;
        private System.Windows.Forms.Label labFiltrarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompra;
    }
}