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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AgregarObjetivo));
            this.label1 = new System.Windows.Forms.Label();
            this.TXTTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RTBDescripcion = new System.Windows.Forms.RichTextBox();
            this.TXTNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLDepende = new System.Windows.Forms.Label();
            this.DGVObjetivosDepende = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CBPerspectiva = new System.Windows.Forms.ComboBox();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoobj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depende = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVObjetivosDepende)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título :";
            // 
            // TXTTitulo
            // 
            this.TXTTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTTitulo.Location = new System.Drawing.Point(82, 16);
            this.TXTTitulo.Name = "TXTTitulo";
            this.TXTTitulo.Size = new System.Drawing.Size(411, 22);
            this.TXTTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción :";
            // 
            // RTBDescripcion
            // 
            this.RTBDescripcion.Location = new System.Drawing.Point(12, 92);
            this.RTBDescripcion.Name = "RTBDescripcion";
            this.RTBDescripcion.Size = new System.Drawing.Size(484, 75);
            this.RTBDescripcion.TabIndex = 3;
            this.RTBDescripcion.Text = "";
            // 
            // TXTNumero
            // 
            this.TXTNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNumero.Location = new System.Drawing.Point(82, 44);
            this.TXTNumero.Name = "TXTNumero";
            this.TXTNumero.Size = new System.Drawing.Size(63, 22);
            this.TXTNumero.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número :";
            // 
            // LBLDepende
            // 
            this.LBLDepende.AutoSize = true;
            this.LBLDepende.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDepende.Location = new System.Drawing.Point(12, 232);
            this.LBLDepende.Name = "LBLDepende";
            this.LBLDepende.Size = new System.Drawing.Size(195, 16);
            this.LBLDepende.TabIndex = 8;
            this.LBLDepende.Text = "Objetivos de los que depende :";
            // 
            // DGVObjetivosDepende
            // 
            this.DGVObjetivosDepende.AllowUserToAddRows = false;
            this.DGVObjetivosDepende.AllowUserToDeleteRows = false;
            this.DGVObjetivosDepende.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVObjetivosDepende.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVObjetivosDepende.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVObjetivosDepende.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.numero,
            this.titulo,
            this.tipoobj,
            this.depende});
            this.DGVObjetivosDepende.Location = new System.Drawing.Point(12, 251);
            this.DGVObjetivosDepende.Name = "DGVObjetivosDepende";
            this.DGVObjetivosDepende.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVObjetivosDepende.Size = new System.Drawing.Size(581, 178);
            this.DGVObjetivosDepende.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Utilice una única nomenclatura     1    /   1.1    /    1-1";
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpiar.Image = global::TableroComando.Properties.Resources.edit_clear;
            this.BTNLimpiar.Location = new System.Drawing.Point(340, 443);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(161, 54);
            this.BTNLimpiar.TabIndex = 7;
            this.BTNLimpiar.Text = "Limpiar objetivos seleccionados";
            this.BTNLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardar.Image = global::TableroComando.Properties.Resources.Button_Add;
            this.BTNGuardar.Location = new System.Drawing.Point(12, 443);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(172, 54);
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
            this.label5.Location = new System.Drawing.Point(9, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Perspectiva  :";
            // 
            // CBPerspectiva
            // 
            this.CBPerspectiva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPerspectiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPerspectiva.FormattingEnabled = true;
            this.CBPerspectiva.Location = new System.Drawing.Point(12, 195);
            this.CBPerspectiva.Name = "CBPerspectiva";
            this.CBPerspectiva.Size = new System.Drawing.Size(288, 24);
            this.CBPerspectiva.TabIndex = 14;
            this.CBPerspectiva.SelectedIndexChanged += new System.EventHandler(this.CBPerspectiva_SelectedIndexChanged);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelar.Image = global::TableroComando.Properties.Resources.Stop;
            this.BTNCancelar.Location = new System.Drawing.Point(190, 443);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(144, 54);
            this.BTNCancelar.TabIndex = 19;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 40;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numero.Width = 69;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.Width = 60;
            // 
            // tipoobj
            // 
            this.tipoobj.HeaderText = "Perspectiva";
            this.tipoobj.Name = "tipoobj";
            this.tipoobj.Width = 88;
            // 
            // depende
            // 
            this.depende.DataPropertyName = "valor";
            this.depende.FalseValue = "0";
            this.depende.HeaderText = "Depende";
            this.depende.Name = "depende";
            this.depende.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.depende.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.depende.TrueValue = "1";
            this.depende.Width = 76;
            // 
            // Form_AgregarObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 509);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.CBPerspectiva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVObjetivosDepende);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.LBLDepende);
            this.Controls.Add(this.TXTNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTBDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTTitulo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_AgregarObjetivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar un Objetivo";
            this.Load += new System.EventHandler(this.Form_AgregarObjetivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVObjetivosDepende)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RTBDescripcion;
        private System.Windows.Forms.TextBox TXTNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBLDepende;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.DataGridView DGVObjetivosDepende;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBPerspectiva;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoobj;
        private System.Windows.Forms.DataGridViewCheckBoxColumn depende;
    }
}