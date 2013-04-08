using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;
using Dataweb.NShape.GeneralShapes;
using Dataweb.NShape.Layouters;
using TableroComando.Fachadas;
using Dominio;
using TableroComando.Clases;
using TableroComando.GUIWrapper;
using Repositorios;
using System.Runtime.InteropServices;


namespace TableroComando.Clases
{
    class MapaEstrategico
    {
        

        [DllImport("shfolder.dll", CharSet = CharSet.Auto)]
        private static extern int SHGetFolderPath(IntPtr hwndOwner, int nFolder, IntPtr hToken, int dwFlags, StringBuilder lpszPath);

        private static string GetSharedDocumentsPath()
        {
            StringBuilder sb = new StringBuilder(260);
            SHGetFolderPath(IntPtr.Zero, 46, IntPtr.Zero, 0, sb);
            return sb.ToString();

        }

        private static Project configurarMapaEstrategico(Template Verde,Template Amarillo,Template Rojo,Project project1, XmlStore xmlStore1)
        {
            // Open the NShape project

            // Path to the NShape sample diagrams
            xmlStore1.DirectoryName = AppDomain.CurrentDomain.BaseDirectory;
            project1.Name = "Circles";
            // Path to the NShape shape library assemblies
            project1.LibrarySearchPaths.Add(AppDomain.CurrentDomain.BaseDirectory);
            project1.Open();

            // Template Verde
             Verde = new Template("Verde", project1.ShapeTypes["Ellipse"].CreateInstance());
            ((IPlanarShape)Verde.Shape).FillStyle = project1.Design.FillStyles.Green;
            project1.Repository.InsertTemplate(Verde);

            // Template Amarillo
             Amarillo = new Template("Amarillo", project1.ShapeTypes["Ellipse"].CreateInstance());
            ((IPlanarShape)Amarillo.Shape).FillStyle = project1.Design.FillStyles.Yellow;
            project1.Repository.InsertTemplate(Amarillo);

            // Template Rojo
             Rojo = new Template("Rojo", project1.ShapeTypes["Ellipse"].CreateInstance());
            ((IPlanarShape)Rojo.Shape).FillStyle = project1.Design.FillStyles.Red;
            project1.Repository.InsertTemplate(Rojo);
            return project1;

        }
        public static Diagram CrearMapa(Project project1, Diagram diagram, XmlStore xmlStore1)
        {
            Template Verde = null;
            Template Amarillo = null;
            Template Rojo = null;

            project1 = configurarMapaEstrategico(Verde,Amarillo,Rojo, project1, xmlStore1);

            Dictionary<string, RectangleBase> shapeDict = new Dictionary<string, RectangleBase>(1000);

            diagram.Height = 1123;
            diagram.Width = 1200;

            int x1 = 50;
            int x2 = 50;
            int x3 = 50;
            int x4 = 50;

            diagram.Shapes.Add(TextoPerspectiva(project1,"Aprendizaje y Crecimiento", 20, 1010));
            diagram.Shapes.Add(TextoPerspectiva(project1, "Procesos Internos", 20, 750));
            diagram.Shapes.Add(TextoPerspectiva(project1, "Cliente", 20, 450));
            diagram.Shapes.Add(TextoPerspectiva(project1, "Financiera", 20, 150));

            LineaDePerspectiva(project1,diagram, 900);
            LineaDePerspectiva(project1, diagram, 600);
            LineaDePerspectiva(project1, diagram, 300);

            IList<Objetivo> ListaObj = ObjetivoRepository.Instance.All();

            Verde = project1.Repository.GetTemplate("Verde");
            Amarillo = project1.Repository.GetTemplate("Amarillo");
            Rojo = project1.Repository.GetTemplate("Rojo");

            IList<RestriccionObjetivo> restricciones = RestriccionGeneralRepository.Instance.All<RestriccionObjetivo>();

            foreach (Objetivo Objetivo in ListaObj)
            {

                RectangleBase referringShape;
                if (!shapeDict.TryGetValue(Objetivo.Nombre, out referringShape))
                {



                    System.Drawing.Color Color = VisualHelper.GetColor(Objetivo.Estado(restricciones));

                    Template TColorObejtivo = SetColor(Verde,Amarillo,Rojo,Color);

                    referringShape = (RectangleBase)TColorObejtivo.CreateShape();
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
                        System.Drawing.Color Color = VisualHelper.GetColor(objetivoHijo.Estado(restricciones));

                        Template TColorObejtivo = SetColor(Verde,Amarillo,Rojo,Color);

                        referredShape = (RectangleBase)TColorObejtivo.CreateShape();
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

            return diagram;
        }

        private static void LineaDePerspectiva(Project project1, Diagram diagram, int y)
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

        private static RectangleBase TextoPerspectiva(Project project1,string texto, int x, int y)
        {
            RectangleBase shape = (RectangleBase)project1.ShapeTypes["Text"].CreateInstance();
            shape.X = x;
            shape.Y = y;
            shape.SetCaptionText(0, texto);
            shape.Rotate(2700, x, y);
            return shape;
        }

        private static Template SetColor(Template Verde,Template Amarillo,Template Rojo,  System.Drawing.Color Color)
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
    }
}
