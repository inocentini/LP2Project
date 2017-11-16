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
            this.labTitulo = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labData = new System.Windows.Forms.Label();
            this.labValor = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.NumericUpDown();
            this.labReais = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.labFiltrarProduto = new System.Windows.Forms.Label();
            this.labQuantidade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCadastro
            // 
            this.panCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCadastro.Controls.Add(this.labTitulo);
            this.panCadastro.Controls.Add(this.dgvProdutos);
            this.panCadastro.Controls.Add(this.btnCancelar);
            this.panCadastro.Controls.Add(this.btnSalvar);
            this.panCadastro.Controls.Add(this.panel1);
            this.panCadastro.Controls.Add(this.panel2);
            this.panCadastro.Location = new System.Drawing.Point(12, 12);
            this.panCadastro.Name = "panCadastro";
            this.panCadastro.Size = new System.Drawing.Size(423, 528);
            this.panCadastro.TabIndex = 28;
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(91, 2);
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
            this.colId,
            this.colProduto,
            this.colQuantidade});
            this.dgvProdutos.Location = new System.Drawing.Point(22, 211);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(382, 272);
            this.dgvProdutos.TabIndex = 3;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.labData);
            this.panel2.Controls.Add(this.labValor);
            this.panel2.Controls.Add(this.dtpData);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.labReais);
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Location = new System.Drawing.Point(74, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 78);
            this.panel2.TabIndex = 1;
            // 
            // labData
            // 
            this.labData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labData.AutoSize = true;
            this.labData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labData.Location = new System.Drawing.Point(31, 12);
            this.labData.Name = "labData";
            this.labData.Size = new System.Drawing.Size(33, 13);
            this.labData.TabIndex = 18;
            this.labData.Text = "Data:";
            // 
            // labValor
            // 
            this.labValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labValor.AutoSize = true;
            this.labValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labValor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labValor.Location = new System.Drawing.Point(3, 42);
            this.labValor.Name = "labValor";
            this.labValor.Size = new System.Drawing.Size(34, 13);
            this.labValor.TabIndex = 15;
            this.labValor.Text = "Valor:";
            // 
            // dtpData
            // 
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(70, 9);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(169, 20);
            this.dtpData.TabIndex = 1;
            this.dtpData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpData_KeyDown);
            // 
            // txtValor
            // 
            this.txtValor.DecimalPlaces = 2;
            this.txtValor.Location = new System.Drawing.Point(70, 40);
            this.txtValor.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(170, 20);
            this.txtValor.TabIndex = 2;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpData_KeyDown);
            // 
            // labReais
            // 
            this.labReais.AutoSize = true;
            this.labReais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labReais.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labReais.Location = new System.Drawing.Point(43, 42);
            this.labReais.Name = "labReais";
            this.labReais.Size = new System.Drawing.Size(21, 13);
            this.labReais.TabIndex = 30;
            this.labReais.Text = "R$";
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtData.Location = new System.Drawing.Point(70, 9);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(169, 20);
            this.txtData.TabIndex = 31;
            this.txtData.TabStop = false;
            this.txtData.Visible = false;
            // 
            // colQuantidade
            // 
            this.colQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuantidade.FillWeight = 40F;
            this.colQuantidade.HeaderText = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            // 
            // colProduto
            // 
            this.colProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProduto.HeaderText = "Produto";
            this.colProduto.Name = "colProduto";
            this.colProduto.ReadOnly = true;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colId.FillWeight = 20F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(0, 22);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(299, 20);
            this.txtNomeProduto.TabIndex = 1;
            this.txtNomeProduto.TextChanged += new System.EventHandler(this.txtNomeProduto_TextChanged);
            this.txtNomeProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeProduto_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 20);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(304, 51);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 20);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DecimalPlaces = 2;
            this.txtQuantidade.Location = new System.Drawing.Point(304, 22);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(75, 20);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeProduto_KeyDown);
            // 
            // labFiltrarProduto
            // 
            this.labFiltrarProduto.AutoSize = true;
            this.labFiltrarProduto.Location = new System.Drawing.Point(3, 5);
            this.labFiltrarProduto.Name = "labFiltrarProduto";
            this.labFiltrarProduto.Size = new System.Drawing.Size(75, 13);
            this.labFiltrarProduto.TabIndex = 43;
            this.labFiltrarProduto.Text = "Filtrar Produto:";
            // 
            // labQuantidade
            // 
            this.labQuantidade.AutoSize = true;
            this.labQuantidade.Location = new System.Drawing.Point(304, 6);
            this.labQuantidade.Name = "labQuantidade";
            this.labQuantidade.Size = new System.Drawing.Size(65, 13);
            this.labQuantidade.TabIndex = 44;
            this.labQuantidade.Text = "Quantidade:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labQuantidade);
            this.panel1.Controls.Add(this.labFiltrarProduto);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtNomeProduto);
            this.panel1.Location = new System.Drawing.Point(22, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 84);
            this.panel1.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCadastro;
        private System.Windows.Forms.NumericUpDown txtValor;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label labReais;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label labValor;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labQuantidade;
        private System.Windows.Forms.Label labFiltrarProduto;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNomeProduto;
    }
}