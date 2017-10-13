namespace WindowsFormsApplication2
{
    partial class FormListaProdutos
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.bntDetalhes = new System.Windows.Forms.Button();
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.labProdutos = new System.Windows.Forms.Label();
            this.labFiltrar = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetalhes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRemover.Location = new System.Drawing.Point(442, 242);
            this.btnRemover.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // bntDetalhes
            // 
            this.bntDetalhes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntDetalhes.Location = new System.Drawing.Point(361, 242);
            this.bntDetalhes.MaximumSize = new System.Drawing.Size(75, 23);
            this.bntDetalhes.Name = "bntDetalhes";
            this.bntDetalhes.Size = new System.Drawing.Size(75, 23);
            this.bntDetalhes.TabIndex = 5;
            this.bntDetalhes.Text = "Detalhes";
            this.bntDetalhes.UseVisualStyleBackColor = true;
            this.bntDetalhes.Click += new System.EventHandler(this.bntDetalhes_Click);
            // 
            // bntEditar
            // 
            this.bntEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntEditar.Location = new System.Drawing.Point(280, 242);
            this.bntEditar.MaximumSize = new System.Drawing.Size(75, 23);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(75, 23);
            this.bntEditar.TabIndex = 4;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntAdd.Location = new System.Drawing.Point(199, 242);
            this.bntAdd.MaximumSize = new System.Drawing.Size(75, 23);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 3;
            this.bntAdd.Text = "Adicionar";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrar.Location = new System.Drawing.Point(64, 9);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(659, 20);
            this.txtFiltrar.TabIndex = 1;
            this.txtFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltrar_KeyUp);
            // 
            // labProdutos
            // 
            this.labProdutos.AutoSize = true;
            this.labProdutos.Location = new System.Drawing.Point(9, 50);
            this.labProdutos.Name = "labProdutos";
            this.labProdutos.Size = new System.Drawing.Size(52, 13);
            this.labProdutos.TabIndex = 18;
            this.labProdutos.Text = "Produtos:";
            // 
            // labFiltrar
            // 
            this.labFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFiltrar.AutoSize = true;
            this.labFiltrar.Location = new System.Drawing.Point(23, 12);
            this.labFiltrar.Name = "labFiltrar";
            this.labFiltrar.Size = new System.Drawing.Size(35, 13);
            this.labFiltrar.TabIndex = 17;
            this.labFiltrar.Text = "Filtrar:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colDetalhes,
            this.colValor});
            this.dgvProdutos.Location = new System.Drawing.Point(-3, 69);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(736, 150);
            this.dgvProdutos.TabIndex = 2;
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
            this.colValor.HeaderText = "Quantidade";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // FormListaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 286);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.bntDetalhes);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.labProdutos);
            this.Controls.Add(this.labFiltrar);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FormListaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListaProdutos_FormClosing);
            this.Load += new System.EventHandler(this.FromListaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button bntDetalhes;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label labProdutos;
        private System.Windows.Forms.Label labFiltrar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
    }
}