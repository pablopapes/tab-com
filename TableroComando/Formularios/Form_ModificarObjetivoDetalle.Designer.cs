namespace TableroComando.Formularios
{
    partial class Form_ModificarObjetivoDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ModificarObjetivoDetalle));
            this.CBPerspectiva = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVObjetivosDepende = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoobj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBLDepende = new System.Windows.Forms.Label();
            this.TXTNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RTBDescripcion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVObjetivosDepende)).BeginInit();
            this.SuspendLayout();
            // 
            // CBPerspectiva
            // 
            this.CBPerspectiva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPerspectiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPerspectiva.FormattingEnabled = true;
            this.CBPerspectiva.Location = new System.Drawing.Point(12, 189);
            this.CBPerspectiva.Name = "CBPerspectiva";
            this.CBPerspectiva.Size = new System.Drawing.Size(288, 24);
            this.CBPerspectiva.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Perspectiva  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Utilice una única nomenclatura     1    /   1.1    /    1-1";
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
            this.tipoobj});
            this.DGVObjetivosDepende.Location = new System.Drawing.Point(15, 245);
            this.DGVObjetivosDepende.Name = "DGVObjetivosDepende";
            this.DGVObjetivosDepende.ReadOnly = true;
            this.DGVObjetivosDepende.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVObjetivosDepende.Size = new System.Drawing.Size(484, 178);
            this.DGVObjetivosDepende.TabIndex = 21;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 69;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 60;
            // 
            // tipoobj
            // 
            this.tipoobj.HeaderText = "Perspectiva";
            this.tipoobj.Name = "tipoobj";
            this.tipoobj.ReadOnly = true;
            this.tipoobj.Width = 88;
            // 
            // LBLDepende
            // 
            this.LBLDepende.AutoSize = true;
            this.LBLDepende.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDepende.Location = new System.Drawing.Point(12, 226);
            this.LBLDepende.Name = "LBLDepende";
            this.LBLDepende.Size = new System.Drawing.Size(195, 16);
            this.LBLDepende.TabIndex = 22;
            this.LBLDepende.Text = "Objetivos de los que depende :";
            // 
            // TXTNumero
            // 
            this.TXTNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNumero.Location = new System.Drawing.Point(82, 38);
            this.TXTNumero.Name = "TXTNumero";
            this.TXTNumero.Size = new System.Drawing.Size(63, 22);
            this.TXTNumero.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Número :";
            // 
            // RTBDescripcion
            // 
            this.RTBDescripcion.Location = new System.Drawing.Point(12, 86);
            this.RTBDescripcion.Name = "RTBDescripcion";
            this.RTBDescripcion.Size = new System.Drawing.Size(484, 75);
            this.RTBDescripcion.TabIndex = 19;
            this.RTBDescripcion.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripción :";
            // 
            // TXTTitulo
            // 
            this.TXTTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTTitulo.Location = new System.Drawing.Point(82, 10);
            this.TXTTitulo.Name = "TXTTitulo";
            this.TXTTitulo.Size = new System.Drawing.Size(411, 22);
            this.TXTTitulo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Título :";
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelar.Image = global::TableroComando.Properties.Resources.Stop;
            this.BTNCancelar.Location = new System.Drawing.Point(185, 429);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(144, 54);
            this.BTNCancelar.TabIndex = 28;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNCancelar.UseVisualStyleBackColor = true;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLimpiar.Image = global::TableroComando.Properties.Resources.edit_clear;
            this.BTNLimpiar.Location = new System.Drawing.Point(335, 429);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(161, 54);
            this.BTNLimpiar.TabIndex = 27;
            this.BTNLimpiar.Text = "Limpiar objetivos seleccionados";
            this.BTNLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            // 
            // BTNModificar
            // 
            this.BTNModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNModificar.Image = global::TableroComando.Properties.Resources.Button_Check;
            this.BTNModificar.Location = new System.Drawing.Point(12, 429);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(167, 54);
            this.BTNModificar.TabIndex = 26;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // Form_ModificarObjetivoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 493);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.CBPerspectiva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVObjetivosDepende);
            this.Controls.Add(this.LBLDepende);
            this.Controls.Add(this.TXTNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RTBDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTTitulo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ModificarObjetivoDetalle";
            this.Text = "Modificar un Objetivo";
            this.Load += new System.EventHandler(this.Form_ModificarObjetivoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVObjetivosDepende)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBPerspectiva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVObjetivosDepende;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoobj;
        private System.Windows.Forms.Label LBLDepende;
        private System.Windows.Forms.TextBox TXTNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RTBDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNModificar;
    }
}