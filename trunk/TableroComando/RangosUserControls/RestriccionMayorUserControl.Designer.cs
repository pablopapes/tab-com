namespace TableroComando.RangosUserControls
{
    partial class RestriccionMayorUserControl
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
            this.EstadoCB = new System.Windows.Forms.ComboBox();
            this.ValorTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.asdf = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.asdf.SuspendLayout();
            this.SuspendLayout();
            // 
            // EstadoCB
            // 
            this.EstadoCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EstadoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoCB.FormattingEnabled = true;
            this.EstadoCB.Location = new System.Drawing.Point(408, 14);
            this.EstadoCB.Name = "EstadoCB";
            this.EstadoCB.Size = new System.Drawing.Size(103, 21);
            this.EstadoCB.TabIndex = 6;
            this.EstadoCB.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.EstadoCB_DrawItem);
            // 
            // ValorTxt
            // 
            this.ValorTxt.Location = new System.Drawing.Point(18, 14);
            this.ValorTxt.Name = "ValorTxt";
            this.ValorTxt.Size = new System.Drawing.Size(87, 20);
            this.ValorTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CodigoIndicador";
            // 
            // asdf
            // 
            this.asdf.Controls.Add(this.label3);
            this.asdf.Controls.Add(this.label1);
            this.asdf.Controls.Add(this.ValorTxt);
            this.asdf.Controls.Add(this.EstadoCB);
            this.asdf.Location = new System.Drawing.Point(29, 0);
            this.asdf.Name = "asdf";
            this.asdf.Size = new System.Drawing.Size(529, 43);
            this.asdf.TabIndex = 8;
            this.asdf.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "<";
            // 
            // RestriccionMayorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.asdf);
            this.Name = "RestriccionMayorUserControl";
            this.Size = new System.Drawing.Size(561, 49);
            this.Load += new System.EventHandler(this.RestriccionMayor_Load);
            this.asdf.ResumeLayout(false);
            this.asdf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox EstadoCB;
        private System.Windows.Forms.TextBox ValorTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox asdf;
        private System.Windows.Forms.Label label3;

    }
}
