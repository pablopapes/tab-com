namespace TableroComando.Formularios
{
    partial class Form_Mapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Mapa));
            this.DGVObjetivos = new System.Windows.Forms.DataGridView();
            this.idobjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroObjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloObjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perspectiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBLObjetivos = new System.Windows.Forms.Label();
            this.LBLObjNecesarios = new System.Windows.Forms.Label();
            this.DGVOBjNecesarios = new System.Windows.Forms.DataGridView();
            this.idobjNecesario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroobjNecesario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloobjNecesario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perspectivaobjNecesario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVObjetivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOBjNecesarios)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVObjetivos
            // 
            this.DGVObjetivos.AllowUserToAddRows = false;
            this.DGVObjetivos.AllowUserToDeleteRows = false;
            this.DGVObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idobjetivo,
            this.numeroObjetivo,
            this.tituloObjetivo,
            this.perspectiva});
            this.DGVObjetivos.Location = new System.Drawing.Point(12, 28);
            this.DGVObjetivos.Name = "DGVObjetivos";
            this.DGVObjetivos.ReadOnly = true;
            this.DGVObjetivos.Size = new System.Drawing.Size(694, 240);
            this.DGVObjetivos.TabIndex = 0;
            // 
            // idobjetivo
            // 
            this.idobjetivo.HeaderText = "idobjetivo";
            this.idobjetivo.Name = "idobjetivo";
            this.idobjetivo.ReadOnly = true;
            this.idobjetivo.Visible = false;
            // 
            // numeroObjetivo
            // 
            this.numeroObjetivo.HeaderText = "Número";
            this.numeroObjetivo.Name = "numeroObjetivo";
            this.numeroObjetivo.ReadOnly = true;
            // 
            // tituloObjetivo
            // 
            this.tituloObjetivo.HeaderText = "Título";
            this.tituloObjetivo.Name = "tituloObjetivo";
            this.tituloObjetivo.ReadOnly = true;
            // 
            // perspectiva
            // 
            this.perspectiva.HeaderText = "Perspectiva";
            this.perspectiva.Name = "perspectiva";
            this.perspectiva.ReadOnly = true;
            // 
            // LBLObjetivos
            // 
            this.LBLObjetivos.AutoSize = true;
            this.LBLObjetivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLObjetivos.Location = new System.Drawing.Point(12, 9);
            this.LBLObjetivos.Name = "LBLObjetivos";
            this.LBLObjetivos.Size = new System.Drawing.Size(115, 16);
            this.LBLObjetivos.TabIndex = 1;
            this.LBLObjetivos.Text = "Lista de Objetivos";
            // 
            // LBLObjNecesarios
            // 
            this.LBLObjNecesarios.AutoSize = true;
            this.LBLObjNecesarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLObjNecesarios.Location = new System.Drawing.Point(12, 293);
            this.LBLObjNecesarios.Name = "LBLObjNecesarios";
            this.LBLObjNecesarios.Size = new System.Drawing.Size(144, 16);
            this.LBLObjNecesarios.TabIndex = 3;
            this.LBLObjNecesarios.Text = "Objetivos Necesarios :";
            // 
            // DGVOBjNecesarios
            // 
            this.DGVOBjNecesarios.AllowUserToAddRows = false;
            this.DGVOBjNecesarios.AllowUserToDeleteRows = false;
            this.DGVOBjNecesarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOBjNecesarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idobjNecesario,
            this.numeroobjNecesario,
            this.tituloobjNecesario,
            this.perspectivaobjNecesario});
            this.DGVOBjNecesarios.Location = new System.Drawing.Point(12, 312);
            this.DGVOBjNecesarios.Name = "DGVOBjNecesarios";
            this.DGVOBjNecesarios.ReadOnly = true;
            this.DGVOBjNecesarios.Size = new System.Drawing.Size(694, 269);
            this.DGVOBjNecesarios.TabIndex = 2;
            // 
            // idobjNecesario
            // 
            this.idobjNecesario.HeaderText = "idclientes";
            this.idobjNecesario.Name = "idobjNecesario";
            this.idobjNecesario.ReadOnly = true;
            this.idobjNecesario.Visible = false;
            // 
            // numeroobjNecesario
            // 
            this.numeroobjNecesario.HeaderText = "Número";
            this.numeroobjNecesario.Name = "numeroobjNecesario";
            this.numeroobjNecesario.ReadOnly = true;
            // 
            // tituloobjNecesario
            // 
            this.tituloobjNecesario.HeaderText = "Título";
            this.tituloobjNecesario.Name = "tituloobjNecesario";
            this.tituloobjNecesario.ReadOnly = true;
            // 
            // perspectivaobjNecesario
            // 
            this.perspectivaobjNecesario.HeaderText = "Perspectiva";
            this.perspectivaobjNecesario.Name = "perspectivaobjNecesario";
            this.perspectivaobjNecesario.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TableroComando.Properties.Resources.MS_Office_2003_Excel_icon;
            this.button1.Location = new System.Drawing.Point(190, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 54);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exportar a Excel";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BTNImprimir
            // 
            this.BTNImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNImprimir.Image = global::TableroComando.Properties.Resources.Printer;
            this.BTNImprimir.Location = new System.Drawing.Point(12, 587);
            this.BTNImprimir.Name = "BTNImprimir";
            this.BTNImprimir.Size = new System.Drawing.Size(172, 54);
            this.BTNImprimir.TabIndex = 11;
            this.BTNImprimir.Text = "Imprimir";
            this.BTNImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNImprimir.UseVisualStyleBackColor = true;
            // 
            // Form_Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNImprimir);
            this.Controls.Add(this.LBLObjNecesarios);
            this.Controls.Add(this.DGVOBjNecesarios);
            this.Controls.Add(this.LBLObjetivos);
            this.Controls.Add(this.DGVObjetivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Mapa";
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Mapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVObjetivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOBjNecesarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVObjetivos;
        private System.Windows.Forms.Label LBLObjetivos;
        private System.Windows.Forms.Label LBLObjNecesarios;
        private System.Windows.Forms.DataGridView DGVOBjNecesarios;
        private System.Windows.Forms.Button BTNImprimir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idobjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroObjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloObjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn perspectiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn idobjNecesario;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroobjNecesario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloobjNecesario;
        private System.Windows.Forms.DataGridViewTextBoxColumn perspectivaobjNecesario;
    }
}