using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;
using Dataweb.NShape.GeneralShapes;
using Dataweb.NShape.Layouters;
using TableroComando.Dominio;
using Dominio;
using TableroComando.Clases;
using TableroComando.GUIWrapper;
using Repositorios;


namespace TableroComando.Formularios
{

	public partial class Form_MapaEstrategico : Form {

        Template Verde;
        Template Amarillo;
        Template Rojo;
        Diagram diagram = new Diagram("D1");

		[DllImport("shfolder.dll", CharSet = CharSet.Auto)]
		private static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken, int dwFlags, StringBuilder lpszPath);


		private static string GetSharedDocumentsPath() {
			StringBuilder sb = new StringBuilder(260);
			SHGetFolderPath(IntPtr.Zero, 46, IntPtr.Zero, 0, sb);
			return sb.ToString();

		}


		public Form_MapaEstrategico() {
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e) {
            /* Open the NShape project
        
            // Path to the NShape sample diagrams
            xmlStore1.DirectoryName = AppDomain.CurrentDomain.BaseDirectory;
            project1.Name = "Circles";
            // Path to the NShape shape library assemblies
            project1.LibrarySearchPaths.Add(AppDomain.CurrentDomain.BaseDirectory);
            project1.Open();

            // Template Verde
            Template Verde = new Template("Verde", project1.ShapeTypes["Ellipse"].CreateInstance());
            ((IPlanarShape)Verde.Shape).FillStyle = project1.Design.FillStyles.Green;
            project1.Repository.InsertTemplate(Verde);

            // Template Amarillo
            Template Amarillo = new Template("Amarillo", project1.ShapeTypes["Ellipse"].CreateInstance());
            ((IPlanarShape)Amarillo.Shape).FillStyle = project1.Design.FillStyles.Yellow;
            project1.Repository.InsertTemplate(Amarillo);

            // Template Rojo
            Template Rojo = new Template("Rojo", project1.ShapeTypes["Ellipse"].CreateInstance());
            ((IPlanarShape)Rojo.Shape).FillStyle = project1.Design.FillStyles.Red;
            project1.Repository.InsertTemplate(Rojo);
            */
            Diagrama();

		}


		private void fileSaveToolStripMenuItem_Click(object sender, EventArgs e) {
			project1.Repository.SaveChanges();
		}


		private void fileLoadStatisticsToolStripMenuItem_Click(object sender, EventArgs e) {
			
			
		}

        private void Diagrama()
        {
            Diagram diagram = new Diagram("D1");
            diagram = Clases.MapaEstrategico.CrearMapa(project1, diagram, xmlStore1);
            cachedRepository1.InsertDiagram(diagram);
            display1.Diagram = diagram;
        }

        private void LineaDePerspectiva(Diagram diagram,int y)
        {
            Polyline shape = (Polyline)project1.ShapeTypes["Polyline"].CreateInstance();
            shape.MoveControlPointTo(ControlPointId.FirstVertex, 0, y, ResizeModifiers.None);
            shape.MoveControlPointTo(ControlPointId.LastVertex, 1200, y, ResizeModifiers.None);
            diagram.Shapes.Add(shape);
        }


        private static void CoordenadasPersp(int x, int y, RectangleBase Shape)
        {
            Shape.X = x + 100;
            Shape.Y = y;
        }

        private RectangleBase TextoPerspectiva(string texto, int x, int y)
        {
            RectangleBase shape = (RectangleBase)project1.ShapeTypes["Text"].CreateInstance();
            shape.X = x;
            shape.Y = y;
            shape.SetCaptionText(0, texto);
            shape.Rotate(2700, x, y);
            return shape;
        }

        private Template SetColor(System.Drawing.Color Color)
        {
            // Compruebo el color del objetivo 
            Template TColor = null;

            if (Color == System.Drawing.Color.Green)
            {
                TColor = Verde;
            }
            if (Color == System.Drawing.Color.Yellow)
            {
                TColor = Amarillo;
            }
            if (Color == System.Drawing.Color.Red)
            {
                TColor = Rojo;
            }

            return TColor;
            
            
        }
		private void fileLayoutToolStripMenuItem_Click(object sender, EventArgs e) {
			foreach (Shape s in display1.Diagram.Shapes) {
				s.X = 100;
				s.Y = 100;
			}
			RepulsionLayouter layouter = new RepulsionLayouter(project1);
			layouter.SpringRate = 8;
			layouter.Repulsion = 3;
			layouter.RepulsionRange = 500;
			layouter.Friction = 0;
			layouter.Mass = 50;
			layouter.AllShapes = display1.Diagram.Shapes;
			layouter.Shapes = display1.Diagram.Shapes;
			//
			layouter.Prepare();
			layouter.Execute(10);
			layouter.Fit(50, 50, display1.Diagram.Width - 100, display1.Diagram.Height - 100);
		}

        private void button1_Click(object sender, EventArgs e)
        {
            diagram.CreateImage(ImageFileFormat.Png);
        }

	}

}