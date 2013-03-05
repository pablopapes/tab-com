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
using TableroComando.Fachadas;
using Dominio;


namespace TableroComando.Formularios
{

	public partial class Form_MapaEstrategico : Form {

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
            // Open the NShape project
        
            // Path to the NShape sample diagrams
            xmlStore1.DirectoryName = AppDomain.CurrentDomain.BaseDirectory;
            project1.Name = "Circles";
            // Path to the NShape shape library assemblies
            project1.LibrarySearchPaths.Add(AppDomain.CurrentDomain.BaseDirectory);
            project1.Open();

            Diagrama();

		}


		private void fileSaveToolStripMenuItem_Click(object sender, EventArgs e) {
			project1.Repository.SaveChanges();
		}


		private void fileLoadStatisticsToolStripMenuItem_Click(object sender, EventArgs e) {
			
			
		}

        private void Diagrama()
        {
            Dictionary<string, RectangleBase> shapeDict = new Dictionary<string, RectangleBase>(1000);
            Diagram diagram = new Diagram("D1");
            diagram.Height = 1123;
            diagram.Width = 1200;

            int x1 = 50;
            int x2 = 50;
            int x3 = 50;
            int x4 = 50;

            diagram.Shapes.Add(TextoPerspectiva("Aprendizaje y Crecimiento",20,1010));
            diagram.Shapes.Add(TextoPerspectiva("Procesos Internos", 20, 750));
            diagram.Shapes.Add(TextoPerspectiva("Cliente", 20, 450));
            diagram.Shapes.Add(TextoPerspectiva("Financiera", 20, 150));

            LineaDePerspectiva(diagram,900);
            LineaDePerspectiva(diagram, 600);
            LineaDePerspectiva(diagram, 300);

            IList<Objetivo> ListaObj = ObjetivoFachada.Instance.All();


            foreach (Objetivo Objetivo in ListaObj)
            {

                RectangleBase referringShape;
                if (!shapeDict.TryGetValue(Objetivo.Nombre, out referringShape))
                {
                    referringShape = (RectangleBase)project1.ShapeTypes["Ellipse"].CreateInstance();
                    referringShape.Width = 120;
                    referringShape.Height = 70;
                    switch (Objetivo.Perspectiva.Id)
                    {
                        // Aprendizaje y crecimiento
                        case 1:
                            CoordenadasPersp(x1, 1000, referringShape);
                            x1 += 150;
                            break;
                        // Procesos internos
                        case 2:
                            CoordenadasPersp(x2, 700, referringShape);
                            x2 += 150;
                            break;
                        // Clientes
                        case 3:
                            CoordenadasPersp(x3, 400, referringShape);
                            x3 += 150;
                            break;
                        // Financiera
                        case 4:
                            CoordenadasPersp(x4, 100, referringShape);
                            x4 += 150;
                            break;
                    }

                    referringShape.SetCaptionText(0, Objetivo.Nombre);
                    shapeDict.Add(Objetivo.Nombre, referringShape);
                    diagram.Shapes.Add(referringShape);
                }
                foreach (Objetivo objetivoHijo in Objetivo.ObjetivosHijos)
                {
                    RectangleBase referredShape;
                    if (!shapeDict.TryGetValue(objetivoHijo.Nombre, out referredShape))
                    {
                        referredShape = (RectangleBase)project1.ShapeTypes["Ellipse"].CreateInstance();
                        referredShape.Width = 120;
                        referredShape.Height = 70;
                        switch (objetivoHijo.Perspectiva.Id)
                        {
                            // Aprendizaje y crecimiento
                            case 1:
                                CoordenadasPersp(x1, 1000, referredShape);
                                x1 += 150;
                                break;
                            // Procesos internos
                            case 2:
                                CoordenadasPersp(x2, 700, referredShape);
                                x2 += 150;
                                break;
                            // Clientes
                            case 3:
                                CoordenadasPersp(x3, 400, referredShape);
                                x3 += 150;
                                break;
                            // Financiera
                            case 4:
                                CoordenadasPersp(x4, 100, referredShape);
                                x4 += 150;
                                break;
                        }
                        referredShape.SetCaptionText(0, objetivoHijo.Nombre);
                        shapeDict.Add(objetivoHijo.Nombre, referredShape);
                        diagram.Shapes.Add(referredShape);
                    }
                    // Add the connection

                    Polyline arrow = (Polyline)project1.ShapeTypes["Polyline"].CreateInstance();
                    diagram.Shapes.Add(arrow);
                    arrow.Connect(ControlPointId.FirstVertex, referringShape, ControlPointId.Reference);
                    arrow.Connect(ControlPointId.LastVertex, referredShape, ControlPointId.Reference);
                    //
                }
            }
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

	}

}