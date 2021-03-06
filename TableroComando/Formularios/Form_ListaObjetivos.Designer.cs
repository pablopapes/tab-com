﻿namespace TableroComando.Formularios
{
    partial class Form_ListaObjetivos
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
            this.ObjetivosDataGrid = new System.Windows.Forms.DataGridView();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.BorrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ObjetivosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjetivosDataGrid
            // 
            this.ObjetivosDataGrid.AllowUserToAddRows = false;
            this.ObjetivosDataGrid.AllowUserToDeleteRows = false;
            this.ObjetivosDataGrid.AllowUserToResizeRows = false;
            this.ObjetivosDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ObjetivosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjetivosDataGrid.Location = new System.Drawing.Point(12, 12);
            this.ObjetivosDataGrid.Name = "ObjetivosDataGrid";
            this.ObjetivosDataGrid.RowHeadersVisible = false;
            this.ObjetivosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ObjetivosDataGrid.Size = new System.Drawing.Size(449, 567);
            this.ObjetivosDataGrid.TabIndex = 0;
            this.ObjetivosDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ObjetivosDataGrid_CellDoubleClick);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarBtn.Image = global::TableroComando.Properties.Resources.Button_Add;
            this.AgregarBtn.Location = new System.Drawing.Point(469, 238);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(156, 48);
            this.AgregarBtn.TabIndex = 15;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarBtn.Image = global::TableroComando.Properties.Resources.Delete;
            this.BorrarBtn.Location = new System.Drawing.Point(469, 305);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(156, 48);
            this.BorrarBtn.TabIndex = 16;
            this.BorrarBtn.Text = "Borrar";
            this.BorrarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorrarBtn.UseVisualStyleBackColor = true;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // Form_ListaObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 591);
            this.Controls.Add(this.BorrarBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.ObjetivosDataGrid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ListaObjetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Objetivos";
            this.Load += new System.EventHandler(this.Form_ListaObjetivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ObjetivosDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ObjetivosDataGrid;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Button BorrarBtn;
    }
}