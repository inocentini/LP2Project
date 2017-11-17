namespace HouseManager
{
    partial class FormCadastraTransacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastraTransacao));
            this.panCadastro = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.labQuantidade = new System.Windows.Forms.Label();
            this.labProduto = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panCadastro
            // 
            this.panCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCadastro.Controls.Add(this.btnAdicionar);
            this.panCadastro.Controls.Add(this.txtQuantidade);
            this.panCadastro.Controls.Add(this.txtProduto);
            this.panCadastro.Controls.Add(this.labQuantidade);
            this.panCadastro.Controls.Add(this.labProduto);
            this.panCadastro.Controls.Add(this.labTitulo);
            this.panCadastro.Controls.Add(this.dgvProdutos);
            this.panCadastro.Controls.Add(this.btnCancelar);
            this.panCadastro.Controls.Add(this.btnSalvar);
            this.panCadastro.Location = new System.Drawing.Point(12, 12);
            this.panCadastro.Name = "panCadastro";
            this.panCadastro.Size = new System.Drawing.Size(423, 528);
            this.panCadastro.TabIndex = 28;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(330, 80);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 44;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DecimalPlaces = 2;
            this.txtQuantidade.Location = new System.Drawing.Point(316, 51);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(89, 20);
            this.txtQuantidade.TabIndex = 43;
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeProduto_KeyDown);
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(73, 51);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(147, 20);
            this.txtProduto.TabIndex = 42;
            this.txtProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeProduto_KeyDown);
            // 
            // labQuantidade
            // 
            this.labQuantidade.AutoSize = true;
            this.labQuantidade.Location = new System.Drawing.Point(245, 54);
            this.labQuantidade.Name = "labQuantidade";
            this.labQuantidade.Size = new System.Drawing.Size(65, 13);
            this.labQuantidade.TabIndex = 41;
            this.labQuantidade.Text = "Quantidade:";
            // 
            // labProduto
            // 
            this.labProduto.AutoSize = true;
            this.labProduto.Location = new System.Drawing.Point(20, 54);
            this.labProduto.Name = "labProduto";
            this.labProduto.Size = new System.Drawing.Size(47, 13);
            this.labProduto.TabIndex = 40;
            this.labProduto.Text = "Produto:";
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(105, 1);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(206, 25);
            this.labTitulo.TabIndex = 39;
            this.labTitulo.Text = "Cadastro de compra";
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
            this.colProduto,
            this.colQuantidade,
            this.colRemover});
            this.dgvProdutos.Location = new System.Drawing.Point(23, 114);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(382, 366);
            this.dgvProdutos.TabIndex = 3;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(248, 489);
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
            this.btnSalvar.Location = new System.Drawing.Point(120, 489);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 36);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // colProduto
            // 
            this.colProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            // 
            // colQuantidade
            // 
            this.colQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuantidade.FillWeight = 40F;
            this.colQuantidade.HeaderText = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            // 
            // colRemover
            // 
            this.colRemover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemover.FillWeight = 30F;
            this.colRemover.HeaderText = "";
            this.colRemover.Name = "colRemover";
            this.colRemover.ReadOnly = true;
            // 
            // FormCadastraTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 552);
            this.Controls.Add(this.panCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(463, 591);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(463, 591);
            this.Name = "FormCadastraTransacao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de transação";
            this.panCadastro.ResumeLayout(false);
            this.panCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCadastro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label labQuantidade;
        private System.Windows.Forms.Label labProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewButtonColumn colRemover;
    }
}