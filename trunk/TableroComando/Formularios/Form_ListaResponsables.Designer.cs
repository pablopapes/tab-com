namespace TableroComando.Formularios
{
    partial class Form_ListaResponsables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ListaResponsables));
            this.ResponsablesDataGrid = new System.Windows.Forms.DataGridView();
            this.BorrarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResponsablesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ResponsablesDataGrid
            // 
            this.ResponsablesDataGrid.AllowUserToAddRows = false;
            this.ResponsablesDataGrid.AllowUserToDeleteRows = false;
            this.ResponsablesDataGrid.AllowUserToResizeColumns = false;
            this.ResponsablesDataGrid.AllowUserToResizeRows = false;
            this.ResponsablesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ResponsablesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResponsablesDataGrid.Location = new System.Drawing.Point(12, 12);
            this.ResponsablesDataGrid.Name = "ResponsablesDataGrid";
            this.ResponsablesDataGrid.ReadOnly = true;
            this.ResponsablesDataGrid.RowHeadersVisible = false;
            this.ResponsablesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ResponsablesDataGrid.Size = new System.Drawing.Size(594, 518);
            this.ResponsablesDataGrid.TabIndex = 0;
            this.ResponsablesDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResponsablesDataGrid_CellDoubleClick);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarBtn.Image = global::TableroComando.Properties.Resources.Delete;
            this.BorrarBtn.Location = new System.Drawing.Point(612, 281);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(156, 48);
            this.BorrarBtn.TabIndex = 15;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorrarBtn.UseVisualStyleBackColor = true;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.Image = global::TableroComando.Properties.Resources.Button_Add;
            this.AgregarBtn.Location = new System.Drawing.Point(612, 213);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(156, 48);
            this.AgregarBtn.TabIndex = 14;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // Form_ListaResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 542);
            this.Controls.Add(this.BorrarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.ResponsablesDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ListaResponsables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Responsables";
            this.Load += new System.EventHandler(this.Form_ListaResponsables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResponsablesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResponsablesDataGrid;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button BorrarBtn;
    }
}