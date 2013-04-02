namespace TableroComando.Formularios
{
    partial class Form_AccionesCorrectivas
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
            this.AccionesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AccionesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AccionesDataGrid
            // 
            this.AccionesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccionesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AccionesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccionesDataGrid.Location = new System.Drawing.Point(12, 12);
            this.AccionesDataGrid.Name = "AccionesDataGrid";
            this.AccionesDataGrid.Size = new System.Drawing.Size(492, 396);
            this.AccionesDataGrid.TabIndex = 0;
            // 
            // Form_AccionesCorrectivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 440);
            this.Controls.Add(this.AccionesDataGrid);
            this.Name = "Form_AccionesCorrectivas";
            this.Text = "Form_AccionesCorrectivas";
            this.Load += new System.EventHandler(this.Form_AccionesCorrectivas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccionesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AccionesDataGrid;
    }
}