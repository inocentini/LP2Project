namespace HouseManager
{
    partial class FormRelatorioContaPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorioContaPrint));
            this.crvConta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RelatorioConta1 = new HouseManager.RelatorioConta();
            this.SuspendLayout();
            // 
            // crvConta
            // 
            this.crvConta.ActiveViewIndex = 0;
            this.crvConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvConta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvConta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvConta.Location = new System.Drawing.Point(0, 0);
            this.crvConta.Name = "crvConta";
            this.crvConta.ReportSource = this.RelatorioConta1;
            this.crvConta.Size = new System.Drawing.Size(284, 262);
            this.crvConta.TabIndex = 0;
            this.crvConta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormRelatorioContaPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.crvConta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRelatorioContaPrint";
            this.Text = "FormRelatorioContaPrint";
            this.Load += new System.EventHandler(this.FormRelatorioContaPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvConta;
        private RelatorioConta RelatorioConta1;
    }
}