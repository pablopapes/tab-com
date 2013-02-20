namespace TableroComando.Formularios
{
    partial class Form_Empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Empresa));
            this.LBLEmpresa = new System.Windows.Forms.Label();
            this.TXTEmpresa = new System.Windows.Forms.TextBox();
            this.TXTCUIT = new System.Windows.Forms.TextBox();
            this.LBLCUIT = new System.Windows.Forms.Label();
            this.LBLMision = new System.Windows.Forms.Label();
            this.RTBMision = new System.Windows.Forms.RichTextBox();
            this.RTBVision = new System.Windows.Forms.RichTextBox();
            this.LBLVision = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLEmpresa
            // 
            this.LBLEmpresa.AutoSize = true;
            this.LBLEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEmpresa.Location = new System.Drawing.Point(13, 22);
            this.LBLEmpresa.Name = "LBLEmpresa";
            this.LBLEmpresa.Size = new System.Drawing.Size(153, 16);
            this.LBLEmpresa.TabIndex = 0;
            this.LBLEmpresa.Text = "Nombre de la empresa :";
            // 
            // TXTEmpresa
            // 
            this.TXTEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTEmpresa.Location = new System.Drawing.Point(12, 41);
            this.TXTEmpresa.Name = "TXTEmpresa";
            this.TXTEmpresa.Size = new System.Drawing.Size(495, 22);
            this.TXTEmpresa.TabIndex = 1;
            // 
            // TXTCUIT
            // 
            this.TXTCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCUIT.Location = new System.Drawing.Point(12, 96);
            this.TXTCUIT.Name = "TXTCUIT";
            this.TXTCUIT.Size = new System.Drawing.Size(177, 22);
            this.TXTCUIT.TabIndex = 3;
            // 
            // LBLCUIT
            // 
            this.LBLCUIT.AutoSize = true;
            this.LBLCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCUIT.Location = new System.Drawing.Point(12, 77);
            this.LBLCUIT.Name = "LBLCUIT";
            this.LBLCUIT.Size = new System.Drawing.Size(45, 16);
            this.LBLCUIT.TabIndex = 2;
            this.LBLCUIT.Text = "CUIT :";
            // 
            // LBLMision
            // 
            this.LBLMision.AutoSize = true;
            this.LBLMision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMision.Location = new System.Drawing.Point(11, 126);
            this.LBLMision.Name = "LBLMision";
            this.LBLMision.Size = new System.Drawing.Size(53, 16);
            this.LBLMision.TabIndex = 4;
            this.LBLMision.Text = "Misión :";
            // 
            // RTBMision
            // 
            this.RTBMision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBMision.Location = new System.Drawing.Point(12, 145);
            this.RTBMision.Name = "RTBMision";
            this.RTBMision.Size = new System.Drawing.Size(710, 106);
            this.RTBMision.TabIndex = 8;
            this.RTBMision.Text = "";
            // 
            // RTBVision
            // 
            this.RTBVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBVision.Location = new System.Drawing.Point(12, 284);
            this.RTBVision.Name = "RTBVision";
            this.RTBVision.Size = new System.Drawing.Size(710, 175);
            this.RTBVision.TabIndex = 10;
            this.RTBVision.Text = "";
            // 
            // LBLVision
            // 
            this.LBLVision.AutoSize = true;
            this.LBLVision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLVision.Location = new System.Drawing.Point(13, 264);
            this.LBLVision.Name = "LBLVision";
            this.LBLVision.Size = new System.Drawing.Size(51, 16);
            this.LBLVision.TabIndex = 9;
            this.LBLVision.Text = "Visión :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TableroComando.Properties.Resources.Printer;
            this.button1.Location = new System.Drawing.Point(188, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Imprimir";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelar.Image = global::TableroComando.Properties.Resources.Stop;
            this.BTNCancelar.Location = new System.Drawing.Point(359, 479);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(148, 51);
            this.BTNCancelar.TabIndex = 14;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardar.Image = global::TableroComando.Properties.Resources.Button_Check;
            this.BTNGuardar.Location = new System.Drawing.Point(12, 479);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(148, 51);
            this.BTNGuardar.TabIndex = 13;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // Form_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.RTBVision);
            this.Controls.Add(this.LBLVision);
            this.Controls.Add(this.RTBMision);
            this.Controls.Add(this.LBLMision);
            this.Controls.Add(this.TXTCUIT);
            this.Controls.Add(this.LBLCUIT);
            this.Controls.Add(this.TXTEmpresa);
            this.Controls.Add(this.LBLEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la empresa ";
            this.Load += new System.EventHandler(this.Empresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLEmpresa;
        private System.Windows.Forms.TextBox TXTEmpresa;
        private System.Windows.Forms.TextBox TXTCUIT;
        private System.Windows.Forms.Label LBLCUIT;
        private System.Windows.Forms.Label LBLMision;
        private System.Windows.Forms.RichTextBox RTBMision;
        private System.Windows.Forms.RichTextBox RTBVision;
        private System.Windows.Forms.Label LBLVision;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button button1;
    }
}