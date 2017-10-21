namespace WindowsFormsApplication2
{
    partial class FormRelatorioPagamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioPagamentos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbContas = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpReferencia = new System.Windows.Forms.DateTimePicker();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lbContas);
            this.panel1.Controls.Add(this.dtpReferencia);
            this.panel1.Controls.Add(this.lbReferencia);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 173);
            this.panel1.TabIndex = 23;
            // 
            // lbContas
            // 
            this.lbContas.AutoSize = true;
            this.lbContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContas.Location = new System.Drawing.Point(66, 16);
            this.lbContas.Name = "lbContas";
            this.lbContas.Size = new System.Drawing.Size(132, 25);
            this.lbContas.TabIndex = 13;
            this.lbContas.Text = "Pagamentos";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(156, 131);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(73, 26);
            this.btnVoltar.TabIndex = 21;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(27, 131);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 26);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Bucar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dtpReferencia
            // 
            this.dtpReferencia.CustomFormat = "MMM/yyyy";
            this.dtpReferencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReferencia.Location = new System.Drawing.Point(106, 87);
            this.dtpReferencia.Name = "dtpReferencia";
            this.dtpReferencia.ShowUpDown = true;
            this.dtpReferencia.Size = new System.Drawing.Size(112, 20);
            this.dtpReferencia.TabIndex = 17;
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(38, 91);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(62, 13);
            this.lbReferencia.TabIndex = 15;
            this.lbReferencia.Text = "Referência:";
            // 
            // FormRelatorioPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 197);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(298, 330);
            this.Name = "FormRelatorioPagamentos";
            this.Text = "Relatório - Pagamentos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbContas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpReferencia;
        private System.Windows.Forms.Label lbReferencia;
    }
}