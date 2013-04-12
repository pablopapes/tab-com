namespace TableroComando.Formularios
{
    partial class Form_MonitoreoArbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MonitoreoArbol));
            this.treeListView1 = new BrightIdeasSoftware.TreeListView();
            this.Nombre = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.UltMed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Unidad = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FechaUltMed = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeListView1
            // 
            this.treeListView1.AllColumns.Add(this.Nombre);
            this.treeListView1.AllColumns.Add(this.UltMed);
            this.treeListView1.AllColumns.Add(this.Unidad);
            this.treeListView1.AllColumns.Add(this.FechaUltMed);
            this.treeListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.UltMed,
            this.Unidad,
            this.FechaUltMed});
            this.treeListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeListView1.FullRowSelect = true;
            this.treeListView1.Location = new System.Drawing.Point(12, 12);
            this.treeListView1.Name = "treeListView1";
            this.treeListView1.OwnerDraw = true;
            this.treeListView1.ShowGroups = false;
            this.treeListView1.Size = new System.Drawing.Size(905, 489);
            this.treeListView1.SmallImageList = this.imageList1;
            this.treeListView1.TabIndex = 0;
            this.treeListView1.UseCompatibleStateImageBehavior = false;
            this.treeListView1.View = System.Windows.Forms.View.Details;
            this.treeListView1.VirtualMode = true;
            this.treeListView1.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.treeListView1_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.AspectName = "Nombre";
            this.Nombre.CellPadding = null;
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 550;
            // 
            // UltMed
            // 
            this.UltMed.AspectName = "UltimaMed";
            this.UltMed.CellPadding = null;
            this.UltMed.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UltMed.Text = "Valor Ultima Medición";
            this.UltMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UltMed.Width = 177;
            // 
            // Unidad
            // 
            this.Unidad.AspectName = "Unidad";
            this.Unidad.CellPadding = null;
            this.Unidad.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Unidad.Text = "Unidad";
            this.Unidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Unidad.Width = 97;
            // 
            // FechaUltMed
            // 
            this.FechaUltMed.AspectName = "FechaUltMed";
            this.FechaUltMed.CellPadding = null;
            this.FechaUltMed.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FechaUltMed.Text = "Fecha Ultima Medición";
            this.FechaUltMed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FechaUltMed.Width = 178;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Red");
            this.imageList1.Images.SetKeyName(1, "Green");
            this.imageList1.Images.SetKeyName(2, "Yellow");
            this.imageList1.Images.SetKeyName(3, "White");
            // 
            // Form_MonitoreoArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 513);
            this.Controls.Add(this.treeListView1);
            this.Name = "Form_MonitoreoArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Form_MonitoreoArbol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.TreeListView treeListView1;
        private BrightIdeasSoftware.OLVColumn Nombre;
        private System.Windows.Forms.ImageList imageList1;
        private BrightIdeasSoftware.OLVColumn UltMed;
        private BrightIdeasSoftware.OLVColumn FechaUltMed;
        private BrightIdeasSoftware.OLVColumn Unidad;

    }
}