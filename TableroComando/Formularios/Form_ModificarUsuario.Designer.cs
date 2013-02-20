namespace TableroComando.Formularios
{
    partial class Form_ModificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ModificarUsuario));
            this.CBPrivilegios = new System.Windows.Forms.ComboBox();
            this.LBLPrivilegios = new System.Windows.Forms.Label();
            this.TXTPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTNombreUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.CBUsuarios = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBPrivilegios
            // 
            this.CBPrivilegios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPrivilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPrivilegios.FormattingEnabled = true;
            this.CBPrivilegios.Location = new System.Drawing.Point(124, 138);
            this.CBPrivilegios.Name = "CBPrivilegios";
            this.CBPrivilegios.Size = new System.Drawing.Size(288, 24);
            this.CBPrivilegios.TabIndex = 26;
            // 
            // LBLPrivilegios
            // 
            this.LBLPrivilegios.AutoSize = true;
            this.LBLPrivilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPrivilegios.Location = new System.Drawing.Point(48, 142);
            this.LBLPrivilegios.Name = "LBLPrivilegios";
            this.LBLPrivilegios.Size = new System.Drawing.Size(70, 16);
            this.LBLPrivilegios.TabIndex = 25;
            this.LBLPrivilegios.Text = "Privilegio :";
            // 
            // TXTPass
            // 
            this.TXTPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPass.Location = new System.Drawing.Point(124, 106);
            this.TXTPass.Name = "TXTPass";
            this.TXTPass.PasswordChar = '*';
            this.TXTPass.Size = new System.Drawing.Size(288, 22);
            this.TXTPass.TabIndex = 23;
            this.TXTPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Contraseña :";
            // 
            // TXTNombreUsuario
            // 
            this.TXTNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNombreUsuario.Location = new System.Drawing.Point(124, 78);
            this.TXTNombreUsuario.Name = "TXTNombreUsuario";
            this.TXTNombreUsuario.Size = new System.Drawing.Size(288, 22);
            this.TXTNombreUsuario.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Usuario :";
            // 
            // TXTNombre
            // 
            this.TXTNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNombre.Location = new System.Drawing.Point(124, 50);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(288, 22);
            this.TXTNombre.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre :";
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCancelar.Image = global::TableroComando.Properties.Resources.Stop;
            this.BTNCancelar.Location = new System.Drawing.Point(240, 218);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(172, 53);
            this.BTNCancelar.TabIndex = 28;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNCancelar.UseVisualStyleBackColor = true;
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGuardar.Image = global::TableroComando.Properties.Resources.Button_Check;
            this.BTNGuardar.Location = new System.Drawing.Point(16, 218);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(172, 54);
            this.BTNGuardar.TabIndex = 27;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNGuardar.UseVisualStyleBackColor = true;
            // 
            // CBUsuarios
            // 
            this.CBUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBUsuarios.FormattingEnabled = true;
            this.CBUsuarios.Location = new System.Drawing.Point(124, 12);
            this.CBUsuarios.Name = "CBUsuarios";
            this.CBUsuarios.Size = new System.Drawing.Size(288, 24);
            this.CBUsuarios.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Usuario :";
            // 
            // CBEstado
            // 
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Location = new System.Drawing.Point(124, 168);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(288, 24);
            this.CBEstado.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Estado :";
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 283);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBUsuarios);
            this.Controls.Add(this.label4);
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
            this.Name = "ModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar un usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.ComboBox CBPrivilegios;
        private System.Windows.Forms.Label LBLPrivilegios;
        private System.Windows.Forms.TextBox TXTPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTNombreUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label label5;
    }
}