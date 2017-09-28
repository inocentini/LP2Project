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
            this.lbTitulo.Font = new System.Drawing.Font("Liberation Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTitulo.Location = new System.Drawing.Point(123, 18);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(239, 36);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "House Manager";
            this.lbTitulo.Click += new System.EventHandler(this.lbTitulo_Click);
            // 
            // lbVersão
            // 
            this.lbVersão.AutoSize = true;
            this.lbVersão.BackColor = System.Drawing.Color.Transparent;
            this.lbVersão.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbVersão.Location = new System.Drawing.Point(295, 71);
            this.lbVersão.Name = "lbVersão";
            this.lbVersão.Size = new System.Drawing.Size(67, 13);
            this.lbVersão.TabIndex = 2;
            this.lbVersão.Text = "Versão 1.0.0";
            // 
            // pbFullLoad
            // 
            this.pbFullLoad.BackColor = System.Drawing.Color.Transparent;
            this.pbFullLoad.Location = new System.Drawing.Point(40, 413);
            this.pbFullLoad.Name = "pbFullLoad";
            this.pbFullLoad.Size = new System.Drawing.Size(410, 10);
            this.pbFullLoad.TabIndex = 3;
            this.pbFullLoad.TabStop = false;
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pbLoading.Location = new System.Drawing.Point(40, 413);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(38, 10);
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
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.rsz_black_cubes_3_wallpaper_640x960;
            this.ClientSize = new System.Drawing.Size(485, 588);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.pbFullLoad);
            this.Controls.Add(this.lbVersão);
            this.Controls.Add(this.lbTitulo);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFullLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbVersão;
        private System.Windows.Forms.PictureBox pbFullLoad;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Timer tmLoad;
    }
}