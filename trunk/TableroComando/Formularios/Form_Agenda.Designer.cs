namespace TableroComando.Formularios
{
    partial class Form_Agenda
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
            ((System.ComponentModel.ISupportInitialize)(this.IndicadoresDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IndicadoresDataGrid
            // 
            this.IndicadoresDataGrid.AllowUserToAddRows = false;
            this.IndicadoresDataGrid.AllowUserToDeleteRows = false;
            this.IndicadoresDataGrid.AllowUserToResizeColumns = false;
            this.IndicadoresDataGrid.AllowUserToResizeRows = false;
            this.IndicadoresDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.IndicadoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IndicadoresDataGrid.Location = new System.Drawing.Point(12, 12);
            this.IndicadoresDataGrid.Name = "IndicadoresDataGrid";
            this.IndicadoresDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IndicadoresDataGrid.Size = new System.Drawing.Size(383, 438);
            this.IndicadoresDataGrid.TabIndex = 0;
            this.IndicadoresDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IndicadoresDataGrid_CellContentClick);
            // 
            // Form_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 462);
            this.Controls.Add(this.IndicadoresDataGrid);
            this.Name = "Form_Agenda";
            this.Text = "Form_Agenda";
            this.Load += new System.EventHandler(this.Form_Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IndicadoresDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IndicadoresDataGrid;
    }
}