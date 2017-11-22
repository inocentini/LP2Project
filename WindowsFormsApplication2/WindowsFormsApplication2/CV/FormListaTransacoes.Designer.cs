namespace HouseManager
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
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.labFiltrar = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.bntDetalhes = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labTransacoes = new System.Windows.Forms.Label();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEVendas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.colValor});
            this.dgvComprasEVendas.Location = new System.Drawing.Point(0, 26);
            this.dgvComprasEVendas.Name = "dgvComprasEVendas";
            this.dgvComprasEVendas.ReadOnly = true;
            this.dgvComprasEVendas.RowHeadersVisible = false;
            this.dgvComprasEVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprasEVendas.Size = new System.Drawing.Size(850, 276);
            this.dgvComprasEVendas.TabIndex = 3;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.Location = new System.Drawing.Point(101, 8);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(739, 20);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrar_KeyUp);
            // 
            // labFiltrar
            // 
            this.labFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFiltrar.AutoSize = true;
            this.labFiltrar.Location = new System.Drawing.Point(3, 12);
            this.labFiltrar.Name = "labFiltrar";
            this.labFiltrar.Size = new System.Drawing.Size(92, 13);
            this.labFiltrar.TabIndex = 4;
            this.labFiltrar.Text = "Filtrar por produto:";
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemover.Location = new System.Drawing.Point(496, 15);
            this.btnRemover.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // bntDetalhes
            // 
            this.bntDetalhes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntDetalhes.Location = new System.Drawing.Point(415, 15);
            this.bntDetalhes.MaximumSize = new System.Drawing.Size(75, 23);
            this.bntDetalhes.Name = "bntDetalhes";
            this.bntDetalhes.Size = new System.Drawing.Size(75, 23);
            this.bntDetalhes.TabIndex = 6;
            this.bntDetalhes.Text = "Detalhes";
            this.bntDetalhes.UseVisualStyleBackColor = true;
            this.bntDetalhes.Click += new System.EventHandler(this.bntDetalhes_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntEditar.Location = new System.Drawing.Point(334, 15);
            this.bntEditar.MaximumSize = new System.Drawing.Size(75, 23);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(75, 23);
            this.bntEditar.TabIndex = 5;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntAdd.Location = new System.Drawing.Point(253, 15);
            this.bntAdd.MaximumSize = new System.Drawing.Size(75, 23);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 4;
            this.bntAdd.Text = "Adicionar";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labFiltrar);
            this.panel1.Controls.Add(this.txtFiltrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 71);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemover);
            this.panel2.Controls.Add(this.bntAdd);
            this.panel2.Controls.Add(this.bntDetalhes);
            this.panel2.Controls.Add(this.bntEditar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 55);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labTransacoes);
            this.panel3.Controls.Add(this.dgvComprasEVendas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 305);
            this.panel3.TabIndex = 15;
            // 
            // labTransacoes
            // 
            this.labTransacoes.AutoSize = true;
            this.labTransacoes.Location = new System.Drawing.Point(3, 5);
            this.labTransacoes.Name = "labTransacoes";
            this.labTransacoes.Size = new System.Drawing.Size(66, 13);
            this.labTransacoes.TabIndex = 4;
            this.labTransacoes.Text = "Transações:";
            // 
            // colValor
            // 
            this.colValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValor.FillWeight = 60F;
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colProds
            // 
            this.colProds.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProds.FillWeight = 150F;
            this.colProds.HeaderText = "Produto(s)";
            this.colProds.Name = "colProds";
            this.colProds.ReadOnly = true;
            // 
            // colData
            // 
            this.colData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colData.HeaderText = "Data";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.FillWeight = 30F;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // FormListaTransacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 431);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(643, 440);
            this.Name = "FormListaTransacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEstoque_FormClosing);
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasEVendas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComprasEVendas;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label labFiltrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button bntDetalhes;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labTransacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProds;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
    }
}