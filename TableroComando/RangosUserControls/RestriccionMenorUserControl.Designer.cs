namespace TableroComando.RangosUserControls
{
    partial class RestriccionMenorUserControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.EstadoCB = new System.Windows.Forms.ComboBox();
            this.ValorTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "<";
            // 
            // EstadoCB
            // 
            this.EstadoCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EstadoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoCB.FormattingEnabled = true;
            this.EstadoCB.Location = new System.Drawing.Point(408, 14);
            this.EstadoCB.Name = "EstadoCB";
            this.EstadoCB.Size = new System.Drawing.Size(103, 21);
            this.EstadoCB.TabIndex = 10;
            this.EstadoCB.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.EstadoCB_DrawItem);
            // 
            // ValorTxt
            // 
            this.ValorTxt.Location = new System.Drawing.Point(162, 13);
            this.ValorTxt.Name = "ValorTxt";
            this.ValorTxt.Size = new System.Drawing.Size(87, 20);
            this.ValorTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CodigoIndicador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ValorTxt);
            this.groupBox1.Controls.Add(this.EstadoCB);
            this.groupBox1.Location = new System.Drawing.Point(29, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 43);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Image = global::TableroComando.Properties.Resources.minus;
            this.EliminarBtn.Location = new System.Drawing.Point(0, 6);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(29, 32);
            this.EliminarBtn.TabIndex = 12;
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // RestriccionMenorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "RestriccionMenorUserControl";
            this.Size = new System.Drawing.Size(561, 49);
            this.Load += new System.EventHandler(this.RestriccionMenor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EstadoCB;
        private System.Windows.Forms.TextBox ValorTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EliminarBtn;

    }
}
