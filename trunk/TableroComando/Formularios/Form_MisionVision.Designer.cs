namespace TableroComando.Formularios
{
    partial class Form_MisionVision
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
            this.MisionTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VisionTxt = new System.Windows.Forms.TextBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MisionTxt
            // 
            this.MisionTxt.Location = new System.Drawing.Point(55, 43);
            this.MisionTxt.Multiline = true;
            this.MisionTxt.Name = "MisionTxt";
            this.MisionTxt.Size = new System.Drawing.Size(493, 131);
            this.MisionTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Misión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visión";
            // 
            // VisionTxt
            // 
            this.VisionTxt.Location = new System.Drawing.Point(55, 204);
            this.VisionTxt.Multiline = true;
            this.VisionTxt.Name = "VisionTxt";
            this.VisionTxt.Size = new System.Drawing.Size(493, 131);
            this.VisionTxt.TabIndex = 4;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(223, 371);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(144, 41);
            this.GuardarBtn.TabIndex = 5;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // Form_MisionVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 424);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.VisionTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MisionTxt);
            this.Name = "Form_MisionVision";
            this.Text = "Misión - Visión";
            this.Load += new System.EventHandler(this.Form_MisionVision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MisionTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VisionTxt;
        private System.Windows.Forms.Button GuardarBtn;
    }
}