namespace TableroComando.Formularios
{
    partial class Form_Meta
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
            this.MenorBtn = new System.Windows.Forms.Button();
            this.RangoBtn = new System.Windows.Forms.Button();
            this.MayorBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.ValorEsperadoTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MenorBtn
            // 
            this.MenorBtn.Location = new System.Drawing.Point(188, 12);
            this.MenorBtn.Name = "MenorBtn";
            this.MenorBtn.Size = new System.Drawing.Size(109, 38);
            this.MenorBtn.TabIndex = 0;
            this.MenorBtn.Text = "Valor Medido < x";
            this.MenorBtn.UseVisualStyleBackColor = true;
            this.MenorBtn.Click += new System.EventHandler(this.MenorBtn_Click);
            // 
            // RangoBtn
            // 
            this.RangoBtn.Location = new System.Drawing.Point(303, 12);
            this.RangoBtn.Name = "RangoBtn";
            this.RangoBtn.Size = new System.Drawing.Size(126, 38);
            this.RangoBtn.TabIndex = 1;
            this.RangoBtn.Text = "x < Valor Medido < y";
            this.RangoBtn.UseVisualStyleBackColor = true;
            this.RangoBtn.Click += new System.EventHandler(this.RangoBtn_Click);
            // 
            // MayorBtn
            // 
            this.MayorBtn.Location = new System.Drawing.Point(435, 12);
            this.MayorBtn.Name = "MayorBtn";
            this.MayorBtn.Size = new System.Drawing.Size(110, 38);
            this.MayorBtn.TabIndex = 2;
            this.MayorBtn.Text = "x < Valor Medido";
            this.MayorBtn.UseVisualStyleBackColor = true;
            this.MayorBtn.Click += new System.EventHandler(this.MayorBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarBtn.Image = global::TableroComando.Properties.Resources.Button_Check;
            this.GuardarBtn.Location = new System.Drawing.Point(298, 336);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(131, 48);
            this.GuardarBtn.TabIndex = 14;
            this.GuardarBtn.Text = "Aceptar";
            this.GuardarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // ValorEsperadoTxt
            // 
            this.ValorEsperadoTxt.Location = new System.Drawing.Point(97, 69);
            this.ValorEsperadoTxt.Name = "ValorEsperadoTxt";
            this.ValorEsperadoTxt.Size = new System.Drawing.Size(100, 20);
            this.ValorEsperadoTxt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Valor Esperado";
            // 
            // Form_Meta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValorEsperadoTxt);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.MayorBtn);
            this.Controls.Add(this.RangoBtn);
            this.Controls.Add(this.MenorBtn);
            this.Name = "Form_Meta";
            this.Text = "Form_Meta";
            this.Load += new System.EventHandler(this.Form_Meta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MenorBtn;
        private System.Windows.Forms.Button RangoBtn;
        private System.Windows.Forms.Button MayorBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.TextBox ValorEsperadoTxt;
        private System.Windows.Forms.Label label1;
    }
}