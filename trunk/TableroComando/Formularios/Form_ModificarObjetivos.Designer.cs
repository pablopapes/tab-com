namespace TableroComando.Formularios
{
    partial class Form_ModificarObjetivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ModificarObjetivos));
            this.DGVFinanciera = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perspectiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFinanciera)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFinanciera
            // 
            this.DGVFinanciera.AllowUserToAddRows = false;
            this.DGVFinanciera.AllowUserToDeleteRows = false;
            this.DGVFinanciera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVFinanciera.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVFinanciera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFinanciera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.numero,
            this.titulo,
            this.estado,
            this.perspectiva});
            this.DGVFinanciera.Location = new System.Drawing.Point(12, 12);
            this.DGVFinanciera.MultiSelect = false;
            this.DGVFinanciera.Name = "DGVFinanciera";
            this.DGVFinanciera.ReadOnly = true;
            this.DGVFinanciera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFinanciera.Size = new System.Drawing.Size(615, 411);
            this.DGVFinanciera.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 40;
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
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 65;
            // 
            // perspectiva
            // 
            this.perspectiva.HeaderText = "Perspectiva";
            this.perspectiva.Name = "perspectiva";
            this.perspectiva.ReadOnly = true;
            this.perspectiva.Width = 88;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TableroComando.Properties.Resources.mail_new;
            this.button1.Location = new System.Drawing.Point(633, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 51);
            this.button1.TabIndex = 17;
            this.button1.Text = "Agregar Indicador";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNModificar.Image = global::TableroComando.Properties.Resources.refresh;
            this.BTNModificar.Location = new System.Drawing.Point(633, 12);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(148, 51);
            this.BTNModificar.TabIndex = 16;
            this.BTNModificar.Text = "Modificar Objetivo";
            this.BTNModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelar.Image = global::TableroComando.Properties.Resources.Stop;
            this.BTNCancelar.Location = new System.Drawing.Point(633, 69);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(148, 51);
            this.BTNCancelar.TabIndex = 15;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNCancelar.UseVisualStyleBackColor = true;
            // 
            // Form_ModificarObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.DGVFinanciera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ModificarObjetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar un Objetivo";
            ((System.ComponentModel.ISupportInitialize)(this.DGVFinanciera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFinanciera;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn perspectiva;
        private System.Windows.Forms.Button button1;
    }
}