namespace WindowsFormsApplication2
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbLoad = new System.Windows.Forms.Label();
            this.lbVersão = new System.Windows.Forms.Label();
            this.pbFullLoad = new System.Windows.Forms.PictureBox();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.tmLoad = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbFullLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbTitulo.Location = new System.Drawing.Point(115, -4);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(440, 41);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Gerenciador de Residências";
            this.lbTitulo.Click += new System.EventHandler(this.lbTitulo_Click);
            // 
            // lbLoad
            // 
            this.lbLoad.AutoSize = true;
            this.lbLoad.BackColor = System.Drawing.Color.Transparent;
            this.lbLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoad.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbLoad.Location = new System.Drawing.Point(13, 154);
            this.lbLoad.Name = "lbLoad";
            this.lbLoad.Size = new System.Drawing.Size(138, 24);
            this.lbLoad.TabIndex = 1;
            this.lbLoad.Text = "Carregando...";
            // 
            // lbVersão
            // 
            this.lbVersão.AutoSize = true;
            this.lbVersão.BackColor = System.Drawing.Color.Transparent;
            this.lbVersão.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbVersão.Location = new System.Drawing.Point(500, 37);
            this.lbVersão.Name = "lbVersão";
            this.lbVersão.Size = new System.Drawing.Size(67, 13);
            this.lbVersão.TabIndex = 2;
            this.lbVersão.Text = "Versão 1.0.0";
            // 
            // pbFullLoad
            // 
            this.pbFullLoad.BackColor = System.Drawing.Color.Transparent;
            this.pbFullLoad.Location = new System.Drawing.Point(157, 154);
            this.pbFullLoad.Name = "pbFullLoad";
            this.pbFullLoad.Size = new System.Drawing.Size(410, 24);
            this.pbFullLoad.TabIndex = 3;
            this.pbFullLoad.TabStop = false;
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pbLoading.Location = new System.Drawing.Point(157, 154);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(38, 24);
            this.pbLoading.TabIndex = 4;
            this.pbLoading.TabStop = false;
            // 
            // tmLoad
            // 
            this.tmLoad.Tick += new System.EventHandler(this.tmLoad_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.rsz_24b3b3f4d6839c2029c06ead11153598;
            this.ClientSize = new System.Drawing.Size(684, 342);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.pbFullLoad);
            this.Controls.Add(this.lbVersão);
            this.Controls.Add(this.lbLoad);
            this.Controls.Add(this.lbTitulo);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFullLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbLoad;
        private System.Windows.Forms.Label lbVersão;
        private System.Windows.Forms.PictureBox pbFullLoad;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Timer tmLoad;
    }
}