namespace HouseManager
{
    partial class FormTeste
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
            this.crvTeste = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.RelatorioTeste1 = new HouseManager.RelatorioTeste();
            this.SuspendLayout();
            // 
            // crvTeste
            // 
            this.crvTeste.ActiveViewIndex = 0;
            this.crvTeste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTeste.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvTeste.Location = new System.Drawing.Point(0, 0);
            this.crvTeste.Name = "crvTeste";
            this.crvTeste.ReportSource = this.RelatorioTeste1;
            this.crvTeste.Size = new System.Drawing.Size(284, 262);
            this.crvTeste.TabIndex = 0;
            this.crvTeste.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FormTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.crvTeste);
            this.Name = "FormTeste";
            this.Text = "FormTeste";
            this.Load += new System.EventHandler(this.FormTeste_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvTeste;
        private RelatorioTeste RelatorioTeste1;
    }
}