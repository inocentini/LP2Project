namespace HouseManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.dtpReferencia = new System.Windows.Forms.DateTimePicker();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbContas
            // 
            this.lbContas.AutoSize = true;
            this.lbContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContas.Location = new System.Drawing.Point(94, 4);
            this.lbContas.Name = "lbContas";
            this.lbContas.Size = new System.Drawing.Size(80, 25);
            this.lbContas.TabIndex = 13;
            this.lbContas.Text = "Contas";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGerar);
            this.panel1.Controls.Add(this.dtpReferencia);
            this.panel1.Controls.Add(this.lbReferencia);
            this.panel1.Controls.Add(this.lbContas);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 152);
            this.panel1.TabIndex = 22;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(140, 112);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 26);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(40, 112);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(73, 26);
            this.btnGerar.TabIndex = 24;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // dtpReferencia
            // 
            this.dtpReferencia.CustomFormat = "MMM/yyyy";
            this.dtpReferencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReferencia.Location = new System.Drawing.Point(106, 58);
            this.dtpReferencia.Name = "dtpReferencia";
            this.dtpReferencia.ShowUpDown = true;
            this.dtpReferencia.Size = new System.Drawing.Size(112, 20);
            this.dtpReferencia.TabIndex = 23;
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(38, 62);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(62, 13);
            this.lbReferencia.TabIndex = 22;
            this.lbReferencia.Text = "Referência:";
            // 
            // FormRelatorioContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 176);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(297, 215);
            this.MinimumSize = new System.Drawing.Size(297, 215);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpReferencia;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGerar;
    }
}