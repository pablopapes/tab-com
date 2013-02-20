namespace TableroComando.Formularios
{
    partial class Form_AgregarIndicador
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ObjetivosCB = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioridadUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
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
            this.groupBox1.Location = new System.Drawing.Point(35, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 100);
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
            this.NombreTxt.Location = new System.Drawing.Point(95, 31);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(164, 20);
            this.NombreTxt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prioridad";
            // 
            // PrioridadUD
            // 
            this.PrioridadUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrioridadUD.Location = new System.Drawing.Point(95, 81);
            this.PrioridadUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PrioridadUD.Name = "PrioridadUD";
            this.PrioridadUD.Size = new System.Drawing.Size(54, 22);
            this.PrioridadUD.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Unidad de medida";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBtn.Image = global::TableroComando.Properties.Resources.Button_Check;
            this.GuardarBtn.Location = new System.Drawing.Point(129, 358);
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pertenece al objetivo";
            // 
            // ObjetivosCB
            // 
            this.ObjetivosCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjetivosCB.FormattingEnabled = true;
            this.ObjetivosCB.Location = new System.Drawing.Point(160, 186);
            this.ObjetivosCB.Name = "ObjetivosCB";
            this.ObjetivosCB.Size = new System.Drawing.Size(121, 21);
            this.ObjetivosCB.TabIndex = 14;
            // 
            // Form_AgregarIndicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 444);
            this.Controls.Add(this.ObjetivosCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrioridadUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form_AgregarIndicador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Indicador";
            this.Load += new System.EventHandler(this.Form_AgregarIndicador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrioridadUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ObjetivosCB;
    }
}