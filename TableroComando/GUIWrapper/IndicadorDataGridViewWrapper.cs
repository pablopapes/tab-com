﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;

namespace TableroComando.GUIWrapper
{
    class IndicadorDataGridViewWrapper
    {
        private Indicador indicador;
        public string Codigo
        {
            get { return indicador.Codigo; }
        }

        public string Nombre
        {
            get { return indicador.Nombre; }
        }

        public string Frecuencia
        {
            get { return indicador.Frecuencia.Periodo;  }
        }

        public DateTime? UltimaMedicion
        {
            get 
            {
                if (indicador.Mediciones.Count != 0)
                    return indicador.Mediciones.Last().Fecha; 
                return null;
            }
        }

        public DateTime ProximaFechaMedicion
        {
            get { return indicador.ProximaFechaMedicion; }
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
