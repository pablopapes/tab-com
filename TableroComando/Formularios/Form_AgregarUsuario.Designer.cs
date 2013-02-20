namespace TableroComando.Formularios
{
    partial class Form_AgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AgregarUsuario));
            this.TXTNombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLPrivilegios = new System.Windows.Forms.Label();
            this.CBPrivilegios = new System.Windows.Forms.ComboBox();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTNombreUsuario
            // 
            this.TXTNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNombreUsuario.Location = new System.Drawing.Point(120, 49);
            this.TXTNombreUsuario.Name = "TXTNombreUsuario";
            this.TXTNombreUsuario.Size = new System.Drawing.Size(288, 22);
            this.TXTNombreUsuario.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario :";
            // 
            // TXTNombre
            // 
            this.TXTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNombre.Location = new System.Drawing.Point(120, 21);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(288, 22);
            this.TXTNombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre :";
            // 
            // TXTPass
            // 
            this.TXTPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPass.Location = new System.Drawing.Point(120, 77);
            this.TXTPass.Name = "TXTPass";
            this.TXTPass.PasswordChar = '*';
            this.TXTPass.Size = new System.Drawing.Size(288, 22);
            this.TXTPass.TabIndex = 9;
            this.TXTPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña :";
            // 
            // LBLPrivilegios
            // 
            this.LBLPrivilegios.AutoSize = true;
            this.LBLPrivilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPrivilegios.Location = new System.Drawing.Point(40, 112);
            this.LBLPrivilegios.Name = "LBLPrivilegios";
            this.LBLPrivilegios.Size = new System.Drawing.Size(70, 16);
            this.LBLPrivilegios.TabIndex = 12;
            this.LBLPrivilegios.Text = "Privilegio :";
            // 
            // CBPrivilegios
            // 
            this.CBPrivilegios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPrivilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPrivilegios.FormattingEnabled = true;
            this.CBPrivilegios.Location = new System.Drawing.Point(120, 109);
            this.CBPrivilegios.Name = "CBPrivilegios";
            this.CBPrivilegios.Size = new System.Drawing.Size(288, 24);
            this.CBPrivilegios.TabIndex = 13;
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelar.Image = global::TableroComando.Properties.Resources.Stop;
            this.BTNCancelar.Location = new System.Drawing.Point(260, 152);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(148, 51);
            this.BTNCancelar.TabIndex = 18;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNCancelar.UseVisualStyleBackColor = true;
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardar.Image = global::TableroComando.Properties.Resources.Button_Add;
            this.BTNGuardar.Location = new System.Drawing.Point(12, 150);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(172, 54);
            this.BTNGuardar.TabIndex = 14;
            this.BTNGuardar.Text = "Agregar";
            this.BTNGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNGuardar.UseVisualStyleBackColor = true;
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 222);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.CBPrivilegios);
            this.Controls.Add(this.LBLPrivilegios);
            this.Controls.Add(this.TXTPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTNombreUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTNombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar un Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTNombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLPrivilegios;
        private System.Windows.Forms.ComboBox CBPrivilegios;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNCancelar;
    }
}