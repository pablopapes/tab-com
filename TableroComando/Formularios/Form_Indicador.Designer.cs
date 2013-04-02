namespace TableroComando.Formularios
{
    partial class Form_Indicador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Indicador));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DetalleTxt = new System.Windows.Forms.TextBox();
            this.MedicionesGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ObjetivosCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PropositoTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FormulaTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CaracteristicaTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FrecuenciasCB = new System.Windows.Forms.ComboBox();
            this.ResponsableCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ValorEsperadoTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripGraficoBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripMetaBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripAcciones = new System.Windows.Forms.ToolStripButton();
            this.toolStripInforme = new System.Windows.Forms.ToolStripButton();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicionesGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.DetalleTxt);
            this.groupBox3.Controls.Add(this.MedicionesGridView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(502, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 523);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mediciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Detalle";
            // 
            // DetalleTxt
            // 
            this.DetalleTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DetalleTxt.Location = new System.Drawing.Point(6, 378);
            this.DetalleTxt.Multiline = true;
            this.DetalleTxt.Name = "DetalleTxt";
            this.DetalleTxt.ReadOnly = true;
            this.DetalleTxt.Size = new System.Drawing.Size(206, 139);
            this.DetalleTxt.TabIndex = 25;
            // 
            // MedicionesGridView
            // 
            this.MedicionesGridView.AllowUserToAddRows = false;
            this.MedicionesGridView.AllowUserToDeleteRows = false;
            this.MedicionesGridView.AllowUserToResizeColumns = false;
            this.MedicionesGridView.AllowUserToResizeRows = false;
            this.MedicionesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicionesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicionesGridView.Location = new System.Drawing.Point(6, 21);
            this.MedicionesGridView.MultiSelect = false;
            this.MedicionesGridView.Name = "MedicionesGridView";
            this.MedicionesGridView.ReadOnly = true;
            this.MedicionesGridView.RowHeadersVisible = false;
            this.MedicionesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicionesGridView.Size = new System.Drawing.Size(206, 317);
            this.MedicionesGridView.TabIndex = 0;
            this.MedicionesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicionesGridView_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGraficoBtn,
            this.toolStripMetaBtn,
            this.toolStripAcciones,
            this.toolStripInforme});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(213, 22);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(272, 22);
            this.NombreTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pertenece al objetivo";
            // 
            // ObjetivosCB
            // 
            this.ObjetivosCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjetivosCB.FormattingEnabled = true;
            this.ObjetivosCB.Location = new System.Drawing.Point(213, 105);
            this.ObjetivosCB.Name = "ObjetivosCB";
            this.ObjetivosCB.Size = new System.Drawing.Size(272, 24);
            this.ObjetivosCB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Código";
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(213, 49);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.Size = new System.Drawing.Size(272, 22);
            this.CodigoTxt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Propósito";
            // 
            // PropositoTxt
            // 
            this.PropositoTxt.Location = new System.Drawing.Point(118, 208);
            this.PropositoTxt.Multiline = true;
            this.PropositoTxt.Name = "PropositoTxt";
            this.PropositoTxt.Size = new System.Drawing.Size(367, 73);
            this.PropositoTxt.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fórmula";
            // 
            // FormulaTxt
            // 
            this.FormulaTxt.Location = new System.Drawing.Point(118, 294);
            this.FormulaTxt.Multiline = true;
            this.FormulaTxt.Name = "FormulaTxt";
            this.FormulaTxt.Size = new System.Drawing.Size(367, 73);
            this.FormulaTxt.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Característica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Responsable";
            // 
            // CaracteristicaTxt
            // 
            this.CaracteristicaTxt.Location = new System.Drawing.Point(118, 378);
            this.CaracteristicaTxt.Multiline = true;
            this.CaracteristicaTxt.Name = "CaracteristicaTxt";
            this.CaracteristicaTxt.Size = new System.Drawing.Size(367, 75);
            this.CaracteristicaTxt.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Frecuencia";
            // 
            // FrecuenciasCB
            // 
            this.FrecuenciasCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FrecuenciasCB.FormattingEnabled = true;
            this.FrecuenciasCB.Location = new System.Drawing.Point(213, 135);
            this.FrecuenciasCB.Name = "FrecuenciasCB";
            this.FrecuenciasCB.Size = new System.Drawing.Size(272, 24);
            this.FrecuenciasCB.TabIndex = 24;
            // 
            // ResponsableCB
            // 
            this.ResponsableCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResponsableCB.FormattingEnabled = true;
            this.ResponsableCB.Location = new System.Drawing.Point(213, 164);
            this.ResponsableCB.Name = "ResponsableCB";
            this.ResponsableCB.Size = new System.Drawing.Size(272, 24);
            this.ResponsableCB.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Valor Esperado";
            // 
            // ValorEsperadoTxt
            // 
            this.ValorEsperadoTxt.Location = new System.Drawing.Point(213, 77);
            this.ValorEsperadoTxt.Name = "ValorEsperadoTxt";
            this.ValorEsperadoTxt.Size = new System.Drawing.Size(272, 22);
            this.ValorEsperadoTxt.TabIndex = 27;
            this.ValorEsperadoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ValorEsperadoTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ResponsableCB);
            this.groupBox2.Controls.Add(this.FrecuenciasCB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CaracteristicaTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.FormulaTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PropositoTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CodigoTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ObjetivosCB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NombreTxt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 523);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // toolStripGraficoBtn
            // 
            this.toolStripGraficoBtn.Image = global::TableroComando.Properties.Resources.Chart_Bar;
            this.toolStripGraficoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGraficoBtn.Name = "toolStripGraficoBtn";
            this.toolStripGraficoBtn.Size = new System.Drawing.Size(84, 22);
            this.toolStripGraficoBtn.Text = "Ver gráfico";
            this.toolStripGraficoBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripMetaBtn
            // 
            this.toolStripMetaBtn.Image = global::TableroComando.Properties.Resources.gears2;
            this.toolStripMetaBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMetaBtn.Name = "toolStripMetaBtn";
            this.toolStripMetaBtn.Size = new System.Drawing.Size(92, 22);
            this.toolStripMetaBtn.Text = "Definir Meta";
            this.toolStripMetaBtn.Click += new System.EventHandler(this.toolStripMetaBtn_Click);
            // 
            // toolStripAcciones
            // 
            this.toolStripAcciones.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAcciones.Image")));
            this.toolStripAcciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAcciones.Name = "toolStripAcciones";
            this.toolStripAcciones.Size = new System.Drawing.Size(137, 22);
            this.toolStripAcciones.Text = "Acciones Correctivas";
            this.toolStripAcciones.Click += new System.EventHandler(this.toolStripAcciones_Click);
            // 
            // toolStripInforme
            // 
            this.toolStripInforme.Image = ((System.Drawing.Image)(resources.GetObject("toolStripInforme.Image")));
            this.toolStripInforme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripInforme.Name = "toolStripInforme";
            this.toolStripInforme.Size = new System.Drawing.Size(69, 22);
            this.toolStripInforme.Text = "Informe";
            this.toolStripInforme.Click += new System.EventHandler(this.toolStripInforme_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBtn.Image = global::TableroComando.Properties.Resources.Button_Check;
            this.GuardarBtn.Location = new System.Drawing.Point(274, 555);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(131, 48);
            this.GuardarBtn.TabIndex = 12;
            this.GuardarBtn.Text = "Agregar";
            this.GuardarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // Form_Indicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 607);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GuardarBtn);
            this.Name = "Form_Indicador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Indicador";
            this.Load += new System.EventHandler(this.Form_AgregarIndicador_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicionesGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView MedicionesGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DetalleTxt;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripGraficoBtn;
        private System.Windows.Forms.ToolStripButton toolStripMetaBtn;
        private System.Windows.Forms.ToolStripButton toolStripAcciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ValorEsperadoTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ResponsableCB;
        private System.Windows.Forms.ComboBox FrecuenciasCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CaracteristicaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FormulaTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PropositoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ObjetivosCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripInforme;
    }
}