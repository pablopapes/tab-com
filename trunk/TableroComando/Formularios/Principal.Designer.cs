namespace TableroComando
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.MSPrincipal = new System.Windows.Forms.MenuStrip();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosDeLaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarLosValoresDeLaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUnObjetivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarObjetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapaEstratégicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMapaEstratégicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indicadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarIndicadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSPrincipal
            // 
            this.MSPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.objetivosToolStripMenuItem,
            this.mapaEstratégicoToolStripMenuItem,
            this.indicadoresToolStripMenuItem});
            this.MSPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MSPrincipal.Name = "MSPrincipal";
            this.MSPrincipal.Size = new System.Drawing.Size(805, 24);
            this.MSPrincipal.TabIndex = 1;
            this.MSPrincipal.Text = "menuStrip1";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarDatosDeLaEmpresaToolStripMenuItem,
            this.modificarLosValoresDeLaEmpresaToolStripMenuItem});
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // modificarDatosDeLaEmpresaToolStripMenuItem
            // 
            this.modificarDatosDeLaEmpresaToolStripMenuItem.Name = "modificarDatosDeLaEmpresaToolStripMenuItem";
            this.modificarDatosDeLaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.modificarDatosDeLaEmpresaToolStripMenuItem.Text = "Modificar datos de la empresa";
            this.modificarDatosDeLaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosDeLaEmpresaToolStripMenuItem_Click);
            // 
            // modificarLosValoresDeLaEmpresaToolStripMenuItem
            // 
            this.modificarLosValoresDeLaEmpresaToolStripMenuItem.Name = "modificarLosValoresDeLaEmpresaToolStripMenuItem";
            this.modificarLosValoresDeLaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.modificarLosValoresDeLaEmpresaToolStripMenuItem.Text = "Modificar los valores de la empresa";
            this.modificarLosValoresDeLaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.modificarLosValoresDeLaEmpresaToolStripMenuItem_Click);
            // 
            // objetivosToolStripMenuItem
            // 
            this.objetivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUnObjetivoToolStripMenuItem,
            this.modificarObjetivosToolStripMenuItem});
            this.objetivosToolStripMenuItem.Name = "objetivosToolStripMenuItem";
            this.objetivosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.objetivosToolStripMenuItem.Text = "Objetivos";
            // 
            // agregarUnObjetivoToolStripMenuItem
            // 
            this.agregarUnObjetivoToolStripMenuItem.Name = "agregarUnObjetivoToolStripMenuItem";
            this.agregarUnObjetivoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.agregarUnObjetivoToolStripMenuItem.Text = "Agregar un objetivo";
            this.agregarUnObjetivoToolStripMenuItem.Click += new System.EventHandler(this.agregarUnObjetivoToolStripMenuItem_Click);
            // 
            // modificarObjetivosToolStripMenuItem
            // 
            this.modificarObjetivosToolStripMenuItem.Name = "modificarObjetivosToolStripMenuItem";
            this.modificarObjetivosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.modificarObjetivosToolStripMenuItem.Text = "Modificar objetivos";
            this.modificarObjetivosToolStripMenuItem.Click += new System.EventHandler(this.modificarObjetivosToolStripMenuItem_Click);
            // 
            // mapaEstratégicoToolStripMenuItem
            // 
            this.mapaEstratégicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMapaEstratégicoToolStripMenuItem});
            this.mapaEstratégicoToolStripMenuItem.Name = "mapaEstratégicoToolStripMenuItem";
            this.mapaEstratégicoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.mapaEstratégicoToolStripMenuItem.Text = "Mapa Estratégico";
            // 
            // verMapaEstratégicoToolStripMenuItem
            // 
            this.verMapaEstratégicoToolStripMenuItem.Name = "verMapaEstratégicoToolStripMenuItem";
            this.verMapaEstratégicoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.verMapaEstratégicoToolStripMenuItem.Text = "Ver mapa estratégico";
            this.verMapaEstratégicoToolStripMenuItem.Click += new System.EventHandler(this.verMapaEstratégicoToolStripMenuItem_Click);
            // 
            // indicadoresToolStripMenuItem
            // 
            this.indicadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarIndicadoresToolStripMenuItem,
            this.monitoreoToolStripMenuItem});
            this.indicadoresToolStripMenuItem.Name = "indicadoresToolStripMenuItem";
            this.indicadoresToolStripMenuItem.Size = new System.Drawing.Size(184, 20);
            this.indicadoresToolStripMenuItem.Text = "Tabla de Factores e Indicadores";
            // 
            // agregarIndicadoresToolStripMenuItem
            // 
            this.agregarIndicadoresToolStripMenuItem.Name = "agregarIndicadoresToolStripMenuItem";
            this.agregarIndicadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarIndicadoresToolStripMenuItem.Text = "Agregar indicadores";
            this.agregarIndicadoresToolStripMenuItem.Click += new System.EventHandler(this.agregarIndicadoresToolStripMenuItem_Click);
            // 
            // monitoreoToolStripMenuItem
            // 
            this.monitoreoToolStripMenuItem.Name = "monitoreoToolStripMenuItem";
            this.monitoreoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monitoreoToolStripMenuItem.Text = "Monitoreo";
            this.monitoreoToolStripMenuItem.Click += new System.EventHandler(this.monitoreoToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TableroComando.Properties.Resources.wall;
            this.ClientSize = new System.Drawing.Size(805, 421);
            this.Controls.Add(this.MSPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MSPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software para Indicadores de gestión - INTI - FLEXIT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MSPrincipal.ResumeLayout(false);
            this.MSPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSPrincipal;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosDeLaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarLosValoresDeLaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapaEstratégicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMapaEstratégicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUnObjetivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarObjetivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indicadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarIndicadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoreoToolStripMenuItem;
    }
}

