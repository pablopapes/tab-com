namespace TableroComando.RangosUserControls
{
    partial class RestriccionRangoUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ValorMayorTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ValorMenorTxt = new System.Windows.Forms.TextBox();
            this.EstadoCB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValorMayorTxt
            // 
            this.ValorMayorTxt.Location = new System.Drawing.Point(284, 14);
            this.ValorMayorTxt.Name = "ValorMayorTxt";
            this.ValorMayorTxt.Size = new System.Drawing.Size(87, 20);
            this.ValorMayorTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo Indicador";
            // 
            // ValorMenorTxt
            // 
            this.ValorMenorTxt.Location = new System.Drawing.Point(19, 14);
            this.ValorMenorTxt.Name = "ValorMenorTxt";
            this.ValorMenorTxt.Size = new System.Drawing.Size(87, 20);
            this.ValorMenorTxt.TabIndex = 8;
            // 
            // EstadoCB
            // 
            this.EstadoCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EstadoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoCB.FormattingEnabled = true;
            this.EstadoCB.Location = new System.Drawing.Point(408, 14);
            this.EstadoCB.Name = "EstadoCB";
            this.EstadoCB.Size = new System.Drawing.Size(103, 21);
            this.EstadoCB.TabIndex = 9;
            this.EstadoCB.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.EstadoCB_DrawItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ValorMayorTxt);
            this.groupBox1.Controls.Add(this.EstadoCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ValorMenorTxt);
            this.groupBox1.Location = new System.Drawing.Point(29, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 43);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "<";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "<";
            // 
            // RestriccionRangoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "RestriccionRangoUserControl";
            this.Size = new System.Drawing.Size(561, 49);
            this.Load += new System.EventHandler(this.RestriccionRango_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ValorMayorTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ValorMenorTxt;
        private System.Windows.Forms.ComboBox EstadoCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
