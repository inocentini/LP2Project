namespace HouseManager
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaAdministrativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasQueAdministroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusPagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meuPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarInformaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mudarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.controleToolStripMenuItem,
            this.meuPerfilToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.áreaAdministrativaToolStripMenuItem,
            this.deslogarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            resources.ApplyResources(this.sistemaToolStripMenuItem, "sistemaToolStripMenuItem");
            // 
            // áreaAdministrativaToolStripMenuItem
            // 
            this.áreaAdministrativaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.contasToolStripMenuItem});
            resources.ApplyResources(this.áreaAdministrativaToolStripMenuItem, "áreaAdministrativaToolStripMenuItem");
            this.áreaAdministrativaToolStripMenuItem.Image = global::HouseManager.Properties.Resources.man_with_tie;
            this.áreaAdministrativaToolStripMenuItem.Name = "áreaAdministrativaToolStripMenuItem";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Image = global::HouseManager.Properties.Resources.multiple_users_silhouette;
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            resources.ApplyResources(this.pessoasToolStripMenuItem, "pessoasToolStripMenuItem");
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasToolStripMenuItem1,
            this.pagamentosToolStripMenuItem1,
            this.estoqueToolStripMenuItem1,
            this.transaçõesToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Image = global::HouseManager.Properties.Resources.progress_report;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            resources.ApplyResources(this.relatóriosToolStripMenuItem, "relatóriosToolStripMenuItem");
            // 
            // contasToolStripMenuItem1
            // 
            this.contasToolStripMenuItem1.Image = global::HouseManager.Properties.Resources.newspaper;
            this.contasToolStripMenuItem1.Name = "contasToolStripMenuItem1";
            resources.ApplyResources(this.contasToolStripMenuItem1, "contasToolStripMenuItem1");
            this.contasToolStripMenuItem1.Click += new System.EventHandler(this.contasToolStripMenuItem1_Click);
            // 
            // pagamentosToolStripMenuItem1
            // 
            this.pagamentosToolStripMenuItem1.Image = global::HouseManager.Properties.Resources.coin;
            this.pagamentosToolStripMenuItem1.Name = "pagamentosToolStripMenuItem1";
            resources.ApplyResources(this.pagamentosToolStripMenuItem1, "pagamentosToolStripMenuItem1");
            this.pagamentosToolStripMenuItem1.Click += new System.EventHandler(this.pagamentosToolStripMenuItem1_Click);
            // 
            // estoqueToolStripMenuItem1
            // 
            this.estoqueToolStripMenuItem1.Image = global::HouseManager.Properties.Resources.shopping_bag;
            this.estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            resources.ApplyResources(this.estoqueToolStripMenuItem1, "estoqueToolStripMenuItem1");
            this.estoqueToolStripMenuItem1.Click += new System.EventHandler(this.estoqueToolStripMenuItem1_Click);
            // 
            // transaçõesToolStripMenuItem
            // 
            this.transaçõesToolStripMenuItem.Image = global::HouseManager.Properties.Resources.cart;
            this.transaçõesToolStripMenuItem.Name = "transaçõesToolStripMenuItem";
            resources.ApplyResources(this.transaçõesToolStripMenuItem, "transaçõesToolStripMenuItem");
            this.transaçõesToolStripMenuItem.Click += new System.EventHandler(this.transaçõesToolStripMenuItem_Click);
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.Image = global::HouseManager.Properties.Resources.newspaper;
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            resources.ApplyResources(this.contasToolStripMenuItem, "contasToolStripMenuItem");
            this.contasToolStripMenuItem.Click += new System.EventHandler(this.contasToolStripMenuItem_Click);
            // 
            // deslogarToolStripMenuItem
            // 
            this.deslogarToolStripMenuItem.Image = global::HouseManager.Properties.Resources.logout__1_;
            this.deslogarToolStripMenuItem.Name = "deslogarToolStripMenuItem";
            resources.ApplyResources(this.deslogarToolStripMenuItem, "deslogarToolStripMenuItem");
            this.deslogarToolStripMenuItem.Click += new System.EventHandler(this.deslogarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::HouseManager.Properties.Resources.icon;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // controleToolStripMenuItem
            // 
            this.controleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.pagamentosToolStripMenuItem});
            this.controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            resources.ApplyResources(this.controleToolStripMenuItem, "controleToolStripMenuItem");
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Image = global::HouseManager.Properties.Resources.cart;
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            resources.ApplyResources(this.estoqueToolStripMenuItem, "estoqueToolStripMenuItem");
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasQueAdministroToolStripMenuItem,
            this.meusPagamentosToolStripMenuItem});
            this.pagamentosToolStripMenuItem.Image = global::HouseManager.Properties.Resources.coin;
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            resources.ApplyResources(this.pagamentosToolStripMenuItem, "pagamentosToolStripMenuItem");
            // 
            // contasQueAdministroToolStripMenuItem
            // 
            this.contasQueAdministroToolStripMenuItem.Image = global::HouseManager.Properties.Resources.newspaper;
            this.contasQueAdministroToolStripMenuItem.Name = "contasQueAdministroToolStripMenuItem";
            resources.ApplyResources(this.contasQueAdministroToolStripMenuItem, "contasQueAdministroToolStripMenuItem");
            this.contasQueAdministroToolStripMenuItem.Click += new System.EventHandler(this.contasQueAdministroToolStripMenuItem_Click);
            // 
            // meusPagamentosToolStripMenuItem
            // 
            this.meusPagamentosToolStripMenuItem.Image = global::HouseManager.Properties.Resources.coin;
            this.meusPagamentosToolStripMenuItem.Name = "meusPagamentosToolStripMenuItem";
            resources.ApplyResources(this.meusPagamentosToolStripMenuItem, "meusPagamentosToolStripMenuItem");
            this.meusPagamentosToolStripMenuItem.Click += new System.EventHandler(this.meusPagamentosToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            resources.ApplyResources(this.cadastroToolStripMenuItem, "cadastroToolStripMenuItem");
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Image = global::HouseManager.Properties.Resources.shopping_bag;
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            resources.ApplyResources(this.produtoToolStripMenuItem, "produtoToolStripMenuItem");
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // meuPerfilToolStripMenuItem
            // 
            this.meuPerfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarInformaçõesToolStripMenuItem,
            this.mudarSenhaToolStripMenuItem});
            this.meuPerfilToolStripMenuItem.Name = "meuPerfilToolStripMenuItem";
            resources.ApplyResources(this.meuPerfilToolStripMenuItem, "meuPerfilToolStripMenuItem");
            // 
            // alterarInformaçõesToolStripMenuItem
            // 
            this.alterarInformaçõesToolStripMenuItem.Image = global::HouseManager.Properties.Resources.avatar;
            this.alterarInformaçõesToolStripMenuItem.Name = "alterarInformaçõesToolStripMenuItem";
            resources.ApplyResources(this.alterarInformaçõesToolStripMenuItem, "alterarInformaçõesToolStripMenuItem");
            this.alterarInformaçõesToolStripMenuItem.Click += new System.EventHandler(this.alterarInformaçõesToolStripMenuItem_Click);
            // 
            // mudarSenhaToolStripMenuItem
            // 
            this.mudarSenhaToolStripMenuItem.Image = global::HouseManager.Properties.Resources.padlock;
            this.mudarSenhaToolStripMenuItem.Name = "mudarSenhaToolStripMenuItem";
            resources.ApplyResources(this.mudarSenhaToolStripMenuItem, "mudarSenhaToolStripMenuItem");
            this.mudarSenhaToolStripMenuItem.Click += new System.EventHandler(this.mudarSenhaToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HouseManager.Properties.Resources.arte720;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.FormPrincipal_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaAdministrativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meuPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarInformaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mudarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasQueAdministroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusPagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transaçõesToolStripMenuItem;
    }
}