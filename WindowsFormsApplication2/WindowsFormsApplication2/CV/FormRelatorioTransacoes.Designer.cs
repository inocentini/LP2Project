namespace HouseManager
{
    partial class FormRelatorioTransacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioTransacoes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpReferencia = new System.Windows.Forms.DateTimePicker();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lbContas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtpReferencia);
            this.panel1.Controls.Add(this.lbReferencia);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGerar);
            this.panel1.Controls.Add(this.lbContas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 148);
            this.panel1.TabIndex = 24;
            // 
            // dtpReferencia
            // 
            this.dtpReferencia.CustomFormat = "MMM/yyyy";
            this.dtpReferencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReferencia.Location = new System.Drawing.Point(108, 60);
            this.dtpReferencia.Name = "dtpReferencia";
            this.dtpReferencia.ShowUpDown = true;
            this.dtpReferencia.Size = new System.Drawing.Size(112, 20);
            this.dtpReferencia.TabIndex = 25;
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(40, 64);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(62, 13);
            this.lbReferencia.TabIndex = 24;
            this.lbReferencia.Text = "Referência:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Location = new System.Drawing.Point(154, 113);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 26);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerar.Location = new System.Drawing.Point(36, 113);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(73, 26);
            this.btnGerar.TabIndex = 20;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lbContas
            // 
            this.lbContas.AutoSize = true;
            this.lbContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContas.Location = new System.Drawing.Point(70, 5);
            this.lbContas.Name = "lbContas";
            this.lbContas.Size = new System.Drawing.Size(125, 25);
            this.lbContas.TabIndex = 13;
            this.lbContas.Text = "Transações";
            // 
            // FormRelatorioTransacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 172);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatorioTransacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório - Transações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRelatorioTransacoes_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lbContas;
        private System.Windows.Forms.DateTimePicker dtpReferencia;
        private System.Windows.Forms.Label lbReferencia;
    }
}