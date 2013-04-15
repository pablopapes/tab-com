namespace TableroComando.Formularios
{
    partial class Form_RestriccionesPerspectivas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RestriccionesPerspectivas));
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Image = global::TableroComando.Properties.Resources.Button_Check;
            this.GuardarBtn.Location = new System.Drawing.Point(248, 213);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(141, 40);
            this.GuardarBtn.TabIndex = 1;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarBtn.UseVisualStyleBackColor = true;
            // 
            // Form_RestriccionesPerspectivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 262);
            this.Controls.Add(this.GuardarBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_RestriccionesPerspectivas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restricciones Perspectivas";
            this.Load += new System.EventHandler(this.Form_RestriccionesPerspectivas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GuardarBtn;
    }
}