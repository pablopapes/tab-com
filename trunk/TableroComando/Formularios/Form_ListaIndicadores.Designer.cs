namespace TableroComando.Formularios
{
    partial class Form_ListaIndicadores
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
            this.IndicadoresDataGrid = new System.Windows.Forms.DataGridView();
            this.BorrarBtn = new System.Windows.Forms.Button();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IndicadoresDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IndicadoresDataGrid
            // 
            this.IndicadoresDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.IndicadoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IndicadoresDataGrid.Location = new System.Drawing.Point(12, 63);
            this.IndicadoresDataGrid.Name = "IndicadoresDataGrid";
            this.IndicadoresDataGrid.RowHeadersVisible = false;
            this.IndicadoresDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IndicadoresDataGrid.Size = new System.Drawing.Size(529, 540);
            this.IndicadoresDataGrid.TabIndex = 0;
            this.IndicadoresDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IndicadoresDataGrid_CellDoubleClick);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarBtn.Image = global::TableroComando.Properties.Resources.Delete;
            this.BorrarBtn.Location = new System.Drawing.Point(547, 317);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(156, 48);
            this.BorrarBtn.TabIndex = 18;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorrarBtn.UseVisualStyleBackColor = true;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.Image = global::TableroComando.Properties.Resources.Button_Add;
            this.AgregarBtn.Location = new System.Drawing.Point(547, 250);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(156, 48);
            this.AgregarBtn.TabIndex = 17;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(486, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar";
            // 
            // Form_ListaIndicadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BorrarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.IndicadoresDataGrid);
            this.Name = "Form_ListaIndicadores";
            this.Text = "Form_ListaIndicadores";
            this.Load += new System.EventHandler(this.Form_ListaIndicadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IndicadoresDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IndicadoresDataGrid;
        private System.Windows.Forms.Button BorrarBtn;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}