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
            this.label1 = new System.Windows.Forms.Label();
            this.MayorRB = new System.Windows.Forms.RadioButton();
            this.MenorRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PrioridadUD = new System.Windows.Forms.NumericUpDown();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ObjetivosCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PropositoTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FormulaTxt = new System.Windows.Forms.TextBox();
            this.CaracteristicaTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FrecuenciasCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MedicionesGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioridadUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicionesGridView)).BeginInit();
            this.SuspendLayout();
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
            // MayorRB
            // 
            this.MayorRB.AutoSize = true;
            this.MayorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayorRB.Location = new System.Drawing.Point(44, 37);
            this.MayorRB.Name = "MayorRB";
            this.MayorRB.Size = new System.Drawing.Size(70, 24);
            this.MayorRB.TabIndex = 2;
            this.MayorRB.TabStop = true;
            this.MayorRB.Text = "Mayor";
            this.MayorRB.UseVisualStyleBackColor = true;
            // 
            // MenorRB
            // 
            this.MenorRB.AutoSize = true;
            this.MenorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenorRB.Location = new System.Drawing.Point(185, 37);
            this.MenorRB.Name = "MenorRB";
            this.MenorRB.Size = new System.Drawing.Size(72, 24);
            this.MenorRB.TabIndex = 3;
            this.MenorRB.TabStop = true;
            this.MenorRB.Text = "Menor";
            this.MenorRB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.MenorRB);
            this.groupBox1.Controls.Add(this.MayorRB);
            this.groupBox1.Location = new System.Drawing.Point(7, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tendencia";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TableroComando.Properties.Resources.menor;
            this.pictureBox2.Location = new System.Drawing.Point(253, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TableroComando.Properties.Resources.mayor1;
            this.pictureBox1.Location = new System.Drawing.Point(111, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(213, 22);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(187, 22);
            this.NombreTxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prioridad";
            // 
            // PrioridadUD
            // 
            this.PrioridadUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrioridadUD.Location = new System.Drawing.Point(213, 73);
            this.PrioridadUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PrioridadUD.Name = "PrioridadUD";
            this.PrioridadUD.Size = new System.Drawing.Size(54, 22);
            this.PrioridadUD.TabIndex = 9;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pertenece al objetivo";
            // 
            // ObjetivosCB
            // 
            this.ObjetivosCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjetivosCB.FormattingEnabled = true;
            this.ObjetivosCB.Location = new System.Drawing.Point(213, 101);
            this.ObjetivosCB.Name = "ObjetivosCB";
            this.ObjetivosCB.Size = new System.Drawing.Size(187, 24);
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
            this.CodigoTxt.Size = new System.Drawing.Size(187, 22);
            this.CodigoTxt.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Propósito";
            // 
            // PropositoTxt
            // 
            this.PropositoTxt.Location = new System.Drawing.Point(118, 255);
            this.PropositoTxt.Multiline = true;
            this.PropositoTxt.Name = "PropositoTxt";
            this.PropositoTxt.Size = new System.Drawing.Size(292, 73);
            this.PropositoTxt.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fórmula";
            // 
            // FormulaTxt
            // 
            this.FormulaTxt.Location = new System.Drawing.Point(118, 173);
            this.FormulaTxt.Multiline = true;
            this.FormulaTxt.Name = "FormulaTxt";
            this.FormulaTxt.Size = new System.Drawing.Size(292, 73);
            this.FormulaTxt.TabIndex = 20;
            // 
            // CaracteristicaTxt
            // 
            this.CaracteristicaTxt.Location = new System.Drawing.Point(118, 336);
            this.CaracteristicaTxt.Multiline = true;
            this.CaracteristicaTxt.Name = "CaracteristicaTxt";
            this.CaracteristicaTxt.Size = new System.Drawing.Size(292, 75);
            this.CaracteristicaTxt.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Característica";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FrecuenciasCB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CaracteristicaTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.FormulaTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PropositoTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CodigoTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ObjetivosCB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PrioridadUD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NombreTxt);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 543);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // FrecuenciasCB
            // 
            this.FrecuenciasCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FrecuenciasCB.FormattingEnabled = true;
            this.FrecuenciasCB.Location = new System.Drawing.Point(213, 131);
            this.FrecuenciasCB.Name = "FrecuenciasCB";
            this.FrecuenciasCB.Size = new System.Drawing.Size(187, 24);
            this.FrecuenciasCB.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Frecuencia";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MedicionesGridView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(448, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 344);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mediciones";
            // 
            // MedicionesGridView
            // 
            this.MedicionesGridView.AllowUserToResizeColumns = false;
            this.MedicionesGridView.AllowUserToResizeRows = false;
            this.MedicionesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicionesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicionesGridView.Location = new System.Drawing.Point(6, 21);
            this.MedicionesGridView.Name = "MedicionesGridView";
            this.MedicionesGridView.RowHeadersVisible = false;
            this.MedicionesGridView.Size = new System.Drawing.Size(206, 317);
            this.MedicionesGridView.TabIndex = 0;
            // 
            // Form_Indicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 607);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GuardarBtn);
            this.Name = "Form_Indicador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Indicador";
            this.Load += new System.EventHandler(this.Form_AgregarIndicador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioridadUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MedicionesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton MayorRB;
        private System.Windows.Forms.RadioButton MenorRB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PrioridadUD;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ObjetivosCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PropositoTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FormulaTxt;
        private System.Windows.Forms.TextBox CaracteristicaTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView MedicionesGridView;
        private System.Windows.Forms.ComboBox FrecuenciasCB;
        private System.Windows.Forms.Label label8;
    }
}