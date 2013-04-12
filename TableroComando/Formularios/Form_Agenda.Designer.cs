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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Agenda));
            this.IndicadoresDataGrid = new System.Windows.Forms.DataGridView();
            this.ValorTxt = new System.Windows.Forms.TextBox();
            this.FechaMedicionDtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CamposMedicionGroup = new System.Windows.Forms.GroupBox();
            this.DetalleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IndicadoresDataGrid)).BeginInit();
            this.CamposMedicionGroup.SuspendLayout();
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
            this.IndicadoresDataGrid.RowHeadersVisible = false;
            this.IndicadoresDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IndicadoresDataGrid.Size = new System.Drawing.Size(443, 438);
            this.IndicadoresDataGrid.TabIndex = 0;
            this.IndicadoresDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IndicadoresDataGrid_CellClick);
            // 
            // ValorTxt
            // 
            this.ValorTxt.Location = new System.Drawing.Point(107, 81);
            this.ValorTxt.Name = "ValorTxt";
            this.ValorTxt.Size = new System.Drawing.Size(100, 20);
            this.ValorTxt.TabIndex = 1;
            this.ValorTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FechaMedicionDtp
            // 
            this.FechaMedicionDtp.Location = new System.Drawing.Point(107, 41);
            this.FechaMedicionDtp.Name = "FechaMedicionDtp";
            this.FechaMedicionDtp.Size = new System.Drawing.Size(200, 20);
            this.FechaMedicionDtp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de Medición";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor Medido";
            // 
            // CamposMedicionGroup
            // 
            this.CamposMedicionGroup.Controls.Add(this.DetalleTxt);
            this.CamposMedicionGroup.Controls.Add(this.label3);
            this.CamposMedicionGroup.Controls.Add(this.AgregarBtn);
            this.CamposMedicionGroup.Controls.Add(this.FechaMedicionDtp);
            this.CamposMedicionGroup.Controls.Add(this.label2);
            this.CamposMedicionGroup.Controls.Add(this.ValorTxt);
            this.CamposMedicionGroup.Controls.Add(this.label1);
            this.CamposMedicionGroup.Location = new System.Drawing.Point(461, 57);
            this.CamposMedicionGroup.Name = "CamposMedicionGroup";
            this.CamposMedicionGroup.Size = new System.Drawing.Size(327, 348);
            this.CamposMedicionGroup.TabIndex = 6;
            this.CamposMedicionGroup.TabStop = false;
            this.CamposMedicionGroup.Text = "Datos de la medición";
            // 
            // DetalleTxt
            // 
            this.DetalleTxt.Location = new System.Drawing.Point(107, 123);
            this.DetalleTxt.Multiline = true;
            this.DetalleTxt.Name = "DetalleTxt";
            this.DetalleTxt.Size = new System.Drawing.Size(200, 138);
            this.DetalleTxt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Detalle";
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.Image = global::TableroComando.Properties.Resources.Button_Add;
            this.AgregarBtn.Location = new System.Drawing.Point(81, 285);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(156, 48);
            this.AgregarBtn.TabIndex = 18;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // Form_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 462);
            this.Controls.Add(this.CamposMedicionGroup);
            this.Controls.Add(this.IndicadoresDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Carga";
            this.Load += new System.EventHandler(this.Form_Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IndicadoresDataGrid)).EndInit();
            this.CamposMedicionGroup.ResumeLayout(false);
            this.CamposMedicionGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IndicadoresDataGrid;
        private System.Windows.Forms.TextBox ValorTxt;
        private System.Windows.Forms.DateTimePicker FechaMedicionDtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox CamposMedicionGroup;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.TextBox DetalleTxt;
        private System.Windows.Forms.Label label3;
    }
}