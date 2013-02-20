namespace TableroComando.Formularios
{
    partial class Form_Valores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Valores));
            this.RTBValores = new System.Windows.Forms.RichTextBox();
            this.LBLValores = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTBValores
            // 
            this.RTBValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBValores.Location = new System.Drawing.Point(12, 31);
            this.RTBValores.Name = "RTBValores";
            this.RTBValores.Size = new System.Drawing.Size(492, 337);
            this.RTBValores.TabIndex = 14;
            this.RTBValores.Text = "";
            // 
            // LBLValores
            // 
            this.LBLValores.AutoSize = true;
            this.LBLValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLValores.Location = new System.Drawing.Point(9, 9);
            this.LBLValores.Name = "LBLValores";
            this.LBLValores.Size = new System.Drawing.Size(61, 16);
            this.LBLValores.TabIndex = 13;
            this.LBLValores.Text = "Valores :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TableroComando.Properties.Resources.Printer;
            this.button1.Location = new System.Drawing.Point(183, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "Imprimir";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelar.Image = global::TableroComando.Properties.Resources.Stop;
            this.BTNCancelar.Location = new System.Drawing.Point(354, 374);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(148, 51);
            this.BTNCancelar.TabIndex = 17;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardar.Image = global::TableroComando.Properties.Resources.Button_Check;
            this.BTNGuardar.Location = new System.Drawing.Point(11, 374);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(148, 51);
            this.BTNGuardar.TabIndex = 16;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // Valores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.RTBValores);
            this.Controls.Add(this.LBLValores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Valores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valores";
            this.Load += new System.EventHandler(this.Valores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBValores;
        private System.Windows.Forms.Label LBLValores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNGuardar;
    }
}