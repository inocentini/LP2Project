namespace WindowsFormsApplication2
{
    partial class FormRelatorioContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioContas));
            this.lbContas = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpReferencia = new System.Windows.Forms.DateTimePicker();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbTipoConta = new System.Windows.Forms.Label();
            this.rbtnContasPagas = new System.Windows.Forms.RadioButton();
            this.rbtnContaAberta = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbContas
            // 
            this.lbContas.AutoSize = true;
            this.lbContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContas.Location = new System.Drawing.Point(87, 12);
            this.lbContas.Name = "lbContas";
            this.lbContas.Size = new System.Drawing.Size(80, 25);
            this.lbContas.TabIndex = 13;
            this.lbContas.Text = "Contas";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(157, 206);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(89, 46);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(13, 206);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 46);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Bucar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dtpReferencia
            // 
            this.dtpReferencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReferencia.Location = new System.Drawing.Point(103, 144);
            this.dtpReferencia.Name = "dtpReferencia";
            this.dtpReferencia.Size = new System.Drawing.Size(112, 20);
            this.dtpReferencia.TabIndex = 17;
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(35, 150);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(62, 13);
            this.lbReferencia.TabIndex = 15;
            this.lbReferencia.Text = "Referência:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbContas);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.rbtnContasPagas);
            this.panel1.Controls.Add(this.rbtnContaAberta);
            this.panel1.Controls.Add(this.dtpReferencia);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lbReferencia);
            this.panel1.Controls.Add(this.lbTipoConta);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 267);
            this.panel1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // lbTipoConta
            // 
            this.lbTipoConta.AutoSize = true;
            this.lbTipoConta.Location = new System.Drawing.Point(20, 116);
            this.lbTipoConta.Name = "lbTipoConta";
            this.lbTipoConta.Size = new System.Drawing.Size(76, 13);
            this.lbTipoConta.TabIndex = 14;
            this.lbTipoConta.Text = "Tipo de conta:";
            // 
            // rbtnContasPagas
            // 
            this.rbtnContasPagas.AutoSize = true;
            this.rbtnContasPagas.Location = new System.Drawing.Point(149, 62);
            this.rbtnContasPagas.Name = "rbtnContasPagas";
            this.rbtnContasPagas.Size = new System.Drawing.Size(90, 17);
            this.rbtnContasPagas.TabIndex = 19;
            this.rbtnContasPagas.TabStop = true;
            this.rbtnContasPagas.Text = "Contas pagas";
            this.rbtnContasPagas.UseVisualStyleBackColor = true;
            // 
            // rbtnContaAberta
            // 
            this.rbtnContaAberta.AutoSize = true;
            this.rbtnContaAberta.Location = new System.Drawing.Point(26, 62);
            this.rbtnContaAberta.Name = "rbtnContaAberta";
            this.rbtnContaAberta.Size = new System.Drawing.Size(97, 17);
            this.rbtnContaAberta.TabIndex = 18;
            this.rbtnContaAberta.TabStop = true;
            this.rbtnContaAberta.Text = "Contas a pagar";
            this.rbtnContaAberta.UseVisualStyleBackColor = true;
            // 
            // FormRelatorioContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 291);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(298, 330);
            this.MinimumSize = new System.Drawing.Size(298, 330);
            this.Name = "FormRelatorioContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório - Contas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRelatorioContas_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbContas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpReferencia;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnContasPagas;
        private System.Windows.Forms.RadioButton rbtnContaAberta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbTipoConta;
    }
}