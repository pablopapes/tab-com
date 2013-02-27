using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;

namespace TableroComando.GUIWrapper
{
    class IndicadorDataGridViewWrapper
    {
        private Indicador indicador;
        private Indicador i;
        public string Codigo
        {
            get { return indicador.Codigo; }
        }

        public string Nombre
        {
            get { return indicador.Nombre; }
        }

        /* Constructor */
        public IndicadorDataGridViewWrapper(Indicador i)
        {
            indicador = i;
        }

        public Indicador GetIndicador()
        {
            return indicador;
        }
    }
}
