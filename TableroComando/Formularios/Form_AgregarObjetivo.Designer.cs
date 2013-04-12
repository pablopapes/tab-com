namespace TableroComando.Formularios
{
    partial class Form_AgregarObjetivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AgregarObjetivo));
            this.label1 = new System.Windows.Forms.Label();
            this.TXTTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RTBDescripcion = new System.Windows.Forms.RichTextBox();
            this.LBLDepende = new System.Windows.Forms.Label();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CBPerspectiva = new System.Windows.Forms.ComboBox();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.ObjetivosDataGrid = new System.Windows.Forms.DataGridView();
            this.RelevanciaNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ObjetivosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelevanciaNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // TXTTitulo
            // 
            this.TXTTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTTitulo.Location = new System.Drawing.Point(117, 16);
            this.TXTTitulo.Name = "TXTTitulo";
            this.TXTTitulo.Size = new System.Drawing.Size(397, 22);
            this.TXTTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // RTBDescripcion
            // 
            this.RTBDescripcion.Location = new System.Drawing.Point(117, 46);
            this.RTBDescripcion.Name = "RTBDescripcion";
            this.RTBDescripcion.Size = new System.Drawing.Size(397, 75);
            this.RTBDescripcion.TabIndex = 3;
            this.RTBDescripcion.Text = "";
            // 
            // LBLDepende
            // 
            this.LBLDepende.AutoSize = true;
            this.LBLDepende.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDepende.Location = new System.Drawing.Point(12, 202);
            this.LBLDepende.Name = "LBLDepende";
            this.LBLDepende.Size = new System.Drawing.Size(99, 16);
            this.LBLDepende.TabIndex = 8;
            this.LBLDepende.Text = "Objetivos Hijos";
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardar.Image = global::TableroComando.Properties.Resources.Button_Add;
            this.BTNGuardar.Location = new System.Drawing.Point(112, 367);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(144, 54);
            this.BTNGuardar.TabIndex = 6;
            this.BTNGuardar.Text = "Agregar";
            this.BTNGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Perspectiva";
            // 
            // CBPerspectiva
            // 
            this.CBPerspectiva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPerspectiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPerspectiva.FormattingEnabled = true;
            this.CBPerspectiva.Location = new System.Drawing.Point(117, 160);
            this.CBPerspectiva.Name = "CBPerspectiva";
            this.CBPerspectiva.Size = new System.Drawing.Size(288, 24);
            this.CBPerspectiva.TabIndex = 14;
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelar.Image = global::TableroComando.Properties.Resources.Stop;
            this.BTNCancelar.Location = new System.Drawing.Point(290, 367);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(144, 54);
            this.BTNCancelar.TabIndex = 19;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // ObjetivosDataGrid
            // 
            this.ObjetivosDataGrid.AllowUserToAddRows = false;
            this.ObjetivosDataGrid.AllowUserToDeleteRows = false;
            this.ObjetivosDataGrid.AllowUserToResizeColumns = false;
            this.ObjetivosDataGrid.AllowUserToResizeRows = false;
            this.ObjetivosDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ObjetivosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjetivosDataGrid.Location = new System.Drawing.Point(117, 202);
            this.ObjetivosDataGrid.Name = "ObjetivosDataGrid";
            this.ObjetivosDataGrid.RowHeadersVisible = false;
            this.ObjetivosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ObjetivosDataGrid.Size = new System.Drawing.Size(397, 150);
            this.ObjetivosDataGrid.TabIndex = 20;
            // 
            // RelevanciaNum
            // 
            this.RelevanciaNum.Location = new System.Drawing.Point(117, 129);
            this.RelevanciaNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RelevanciaNum.Name = "RelevanciaNum";
            this.RelevanciaNum.Size = new System.Drawing.Size(51, 20);
            this.RelevanciaNum.TabIndex = 21;
            this.RelevanciaNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Relevancia (%)";
            // 
            // Form_AgregarObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 435);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RelevanciaNum);
            this.Controls.Add(this.ObjetivosDataGrid);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.CBPerspectiva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.LBLDepende);
            this.Controls.Add(this.RTBDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTTitulo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AgregarObjetivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar un Objetivo";
            this.Load += new System.EventHandler(this.Form_AgregarObjetivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ObjetivosDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelevanciaNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTBDescripcion;
        private System.Windows.Forms.Label LBLDepende;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBPerspectiva;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.DataGridView ObjetivosDataGrid;
        private System.Windows.Forms.NumericUpDown RelevanciaNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}