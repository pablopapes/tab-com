using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace TableroComando.Clases
{
    class Herramientas
    {
        public static byte[] ConversionImagen(string nombrearchivo)
        {
            //Declaramos fs para poder abrir la imagen.
            FileStream fs = new FileStream(nombrearchivo, FileMode.Open);

            // Declaramos un lector binario para pasar la imagen
            // a bytes
            BinaryReader br = new BinaryReader(fs);
            byte[] imagen = new byte[(int)fs.Length];
            br.Read(imagen, 0, (int)fs.Length);
            br.Close();
            fs.Close();
            return imagen;
        }

        public static Image resizeImage(int newWidth, int newHeight, string stPhotoPath)
        {
            Image imgPhoto = Image.FromFile(stPhotoPath);

            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;

            //Consider vertical pics
            if (sourceWidth < sourceHeight)
            {
                int buff = newWidth;

                newWidth = newHeight;
                newHeight = buff;
            }

            int sourceX = 0, sourceY = 0, destX = 0, destY = 0;
            float nPercent = 0, nPercentW = 0, nPercentH = 0;

            nPercentW = ((float)newWidth / (float)sourceWidth);
            nPercentH = ((float)newHeight / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((newWidth -
                          (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((newHeight -
                          (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);


            Bitmap bmPhoto = new Bitmap(newWidth, newHeight,
                          PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                         imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.White);
            grPhoto.InterpolationMode =
                InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }


        public static Chart PropiedadesDelGrafico(String Titulo, String EjeX, String EjeY, Chart Grafico, SeriesChartType tipo)
        {
            Grafico.BorderSkin.SkinStyle = BorderSkinStyle.Emboss;
            Grafico.BorderlineDashStyle = ChartDashStyle.Solid;
            Grafico.BorderlineColor = Color.CadetBlue;
            Grafico.BorderlineWidth = 3;

            Grafico.Series["Series1"].Points.Clear();
            Grafico.Series["Series2"].Points.Clear();
            Grafico.Titles.Clear();
            Grafico.Titles.Add(Titulo);
            Grafico.Titles[0].Text = Titulo;
            Grafico.Titles[0].Font = new Font("Calibri", 14, FontStyle.Bold);
            Grafico.Series["Series2"].LegendText = "Valor Esperado";
            Grafico.Series["Series1"].LegendText = "Mediciones";
            Grafico.Series["Series1"]["LabelStyle"] = "Bottom";
            Grafico.Series["Series1"].ChartType = tipo;
            Grafico.Series["Series2"].ChartType = tipo;
            Grafico.Series["Series1"].BorderWidth = 5;
            Grafico.Series["Series2"].BorderWidth = 5;
            Grafico.Series["Series1"].Label = "#VALY";
            Grafico.Series["Series1"].MarkerStyle = MarkerStyle.Circle;
            Grafico.Series["Series1"].MarkerSize = 8;
            Grafico.Series["Series1"].MarkerColor = Color.Magenta;
            Grafico.Series["Series1"].MarkerBorderColor = Color.Red;
            Grafico.Series["Series1"].MarkerBorderWidth = 1;
            Grafico.ChartAreas["ChartArea1"].AxisX.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
            Grafico.ChartAreas["ChartArea1"].AxisY.TitleFont = new Font("Calibri", 12, FontStyle.Bold);
            Grafico.ChartAreas["ChartArea1"].AxisX.Title = EjeX;
            Grafico.ChartAreas["ChartArea1"].AxisY.Title = EjeY;
            Grafico.ChartAreas["ChartArea1"].AxisY.StripLines.Clear();

            return Grafico;
        }
    
    }
}
