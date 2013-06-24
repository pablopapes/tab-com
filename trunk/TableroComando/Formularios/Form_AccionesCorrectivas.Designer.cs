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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AccionesCorrectivas));
            this.AccionesDataGrid = new System.Windows.Forms.DataGridView();
            this.GuardarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccionesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AccionesDataGrid
            // 
            this.AccionesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccionesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AccionesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccionesDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.AccionesDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AccionesDataGrid.Location = new System.Drawing.Point(12, 12);
            this.AccionesDataGrid.Name = "AccionesDataGrid";
            this.AccionesDataGrid.RowHeadersVisible = false;
            this.AccionesDataGrid.Size = new System.Drawing.Size(1020, 396);
            this.AccionesDataGrid.TabIndex = 0;
            this.AccionesDataGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.AccionesDataGrid_CellFormatting);
            this.AccionesDataGrid.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.AccionesDataGrid_CellParsing);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Image = global::TableroComando.Properties.Resources.Button_Check;
            this.GuardarBtn.Location = new System.Drawing.Point(459, 423);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(127, 43);
            this.GuardarBtn.TabIndex = 1;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // Form_AccionesCorrectivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 476);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.AccionesDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AccionesCorrectivas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acciones Correctivas";
            this.Load += new System.EventHandler(this.Form_AccionesCorrectivas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccionesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AccionesDataGrid;
        private System.Windows.Forms.Button GuardarBtn;
    }
}