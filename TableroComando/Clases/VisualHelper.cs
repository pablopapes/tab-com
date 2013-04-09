using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Dominio;

namespace TableroComando.Clases
{
    class VisualHelper
    {
        private static Dictionary<EstadoIndicador, Color> _estadoColor;
        private static Dictionary<EstadoIndicador, Color> EstadoColor
        {
            get
            {
                if (_estadoColor == null)
                {
                    _estadoColor = new Dictionary<EstadoIndicador, Color>();
                    _estadoColor.Add(EstadoIndicador.Bien, Color.Green);
                    _estadoColor.Add(EstadoIndicador.Mal, Color.Red);
                    _estadoColor.Add(EstadoIndicador.Regular, Color.Yellow);
                    _estadoColor.Add(EstadoIndicador.NoDefinido, Color.White);
                }
                return _estadoColor;
            }
        }
        public static Color GetColor(EstadoIndicador estado)
        {
            return EstadoColor[estado];
        }
    }
}
