﻿namespace TableroComando.Formularios
{
	partial class Form_MapaEstrategico {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MapaEstrategico));
            Dataweb.NShape.RoleBasedSecurityManager roleBasedSecurityManager1 = new Dataweb.NShape.RoleBasedSecurityManager();
            this.display1 = new Dataweb.NShape.WinFormsUI.Display();
            this.diagramSetController1 = new Dataweb.NShape.Controllers.DiagramSetController();
            this.project1 = new Dataweb.NShape.Project(this.components);
            this.cachedRepository1 = new Dataweb.NShape.Advanced.CachedRepository();
            this.xmlStore1 = new Dataweb.NShape.XmlStore();
            this.toolSetController1 = new Dataweb.NShape.Controllers.ToolSetController();
            this.toolSetListViewPresenter1 = new Dataweb.NShape.WinFormsUI.ToolSetListViewPresenter(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.display1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display1
            // 
            this.display1.AllowDrop = true;
            this.display1.AutoScroll = true;
            this.display1.BackColorGradient = System.Drawing.SystemColors.Control;
            this.display1.BackgroundGradientAngle = 45;
            this.display1.ConnectionPointShape = Dataweb.NShape.Controllers.ControlPointShape.Circle;
            this.display1.ControlPointAlpha = ((byte)(255));
            this.display1.Controls.Add(this.button1);
            this.display1.DiagramSetController = this.diagramSetController1;
            this.display1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display1.GridAlpha = ((byte)(255));
            this.display1.GridColor = System.Drawing.Color.White;
            this.display1.GridSize = 20;
            this.display1.GripSize = 3;
            this.display1.HideDeniedMenuItems = false;
            this.display1.HighQualityBackground = true;
            this.display1.HighQualityRendering = true;
            this.display1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.display1.Location = new System.Drawing.Point(0, 0);
            this.display1.MinRotateRange = 30;
            this.display1.Name = "display1";
            this.display1.PropertyController = null;
            this.display1.RenderingQualityHighQuality = Dataweb.NShape.Advanced.RenderingQuality.HighQuality;
            this.display1.RenderingQualityLowQuality = Dataweb.NShape.Advanced.RenderingQuality.DefaultQuality;
            this.display1.ResizeGripShape = Dataweb.NShape.Controllers.ControlPointShape.Square;
            this.display1.SelectionHilightColor = System.Drawing.Color.Firebrick;
            this.display1.SelectionInactiveColor = System.Drawing.Color.Gray;
            this.display1.SelectionInteriorColor = System.Drawing.Color.WhiteSmoke;
            this.display1.SelectionNormalColor = System.Drawing.Color.DarkGreen;
            this.display1.ShowGrid = true;
            this.display1.ShowScrollBars = true;
            this.display1.Size = new System.Drawing.Size(830, 584);
            this.display1.SnapDistance = 5;
            this.display1.SnapToGrid = true;
            this.display1.TabIndex = 0;
            this.display1.ToolPreviewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
            this.display1.ToolPreviewColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.display1.ZoomLevel = 50;
            this.display1.ZoomWithMouseWheel = true;
            // 
            // diagramSetController1
            // 
            this.diagramSetController1.ActiveTool = null;
            this.diagramSetController1.Project = this.project1;
            // 
            // project1
            // 
            this.project1.AutoGenerateTemplates = true;
            this.project1.LibrarySearchPaths = ((System.Collections.Generic.IList<string>)(resources.GetObject("project1.LibrarySearchPaths")));
            this.project1.Name = null;
            this.project1.Repository = this.cachedRepository1;
            roleBasedSecurityManager1.CurrentRole = Dataweb.NShape.StandardRole.Administrator;
            roleBasedSecurityManager1.CurrentRoleName = "Administrator";
            this.project1.SecurityManager = roleBasedSecurityManager1;
            // 
            // cachedRepository1
            // 
            this.cachedRepository1.ProjectName = null;
            this.cachedRepository1.Store = this.xmlStore1;
            this.cachedRepository1.Version = 0;
            // 
            // xmlStore1
            // 
            this.xmlStore1.DesignFileName = "";
            this.xmlStore1.DirectoryName = "";
            this.xmlStore1.FileExtension = ".xml";
            this.xmlStore1.ProjectName = "";
            // 
            // toolSetController1
            // 
            this.toolSetController1.DiagramSetController = this.diagramSetController1;
            // 
            // toolSetListViewPresenter1
            // 
            this.toolSetListViewPresenter1.HideDeniedMenuItems = false;
            this.toolSetListViewPresenter1.ListView = null;
            this.toolSetListViewPresenter1.ShowDefaultContextMenu = true;
            this.toolSetListViewPresenter1.ToolSetController = this.toolSetController1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_MapaEstrategico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 584);
            this.Controls.Add(this.display1);
            this.Name = "Form_MapaEstrategico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapa Estrategico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.display1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private Dataweb.NShape.WinFormsUI.Display display1;
		private Dataweb.NShape.Project project1;
		private Dataweb.NShape.Controllers.DiagramSetController diagramSetController1;
		private Dataweb.NShape.Advanced.CachedRepository cachedRepository1;
		private Dataweb.NShape.XmlStore xmlStore1;
		private Dataweb.NShape.Controllers.ToolSetController toolSetController1;
        private Dataweb.NShape.WinFormsUI.ToolSetListViewPresenter toolSetListViewPresenter1;
        private System.Windows.Forms.Button button1;
	}
}

