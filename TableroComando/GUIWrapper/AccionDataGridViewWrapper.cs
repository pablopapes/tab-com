using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;

namespace TableroComando.GUIWrapper
{
    public class AccionDataGridViewWrapper
    {
        protected AccionCorrectiva _accionCorrectiva;
        public string Indicador 
        {
            get 
            { 
                return (_accionCorrectiva.Indicador != null) ? _accionCorrectiva.Indicador.Codigo : "";
            } 
        }

        public DateTime FechaFin 
        {
            set { _accionCorrectiva.FechaFin = value;  }
            get { return _accionCorrectiva.FechaFin; } 
        }

        public Responsable Responsable
        {
            set { _accionCorrectiva.Responsable = value; }
            get { return _accionCorrectiva.Responsable; }
        }

        public EstadoTarea Estado { get { return _accionCorrectiva.Estado; } set { _accionCorrectiva.Estado = value; } }

        public string Descripcion
        {
            get { return _accionCorrectiva.Descripcion; }
            set { _accionCorrectiva.Descripcion = value; }
        }

        public string Objetivo
        {
            get { return _accionCorrectiva.Objetivo; }
            set { _accionCorrectiva.Objetivo = value; }
        }

        public AccionDataGridViewWrapper(AccionCorrectiva a)
        {
            _accionCorrectiva = a;
        }


        public AccionDataGridViewWrapper()
        {
            _accionCorrectiva = new AccionCorrectiva();
        }

        public AccionCorrectiva GetAccionCorrectiva()
        {
            return _accionCorrectiva;
        }
    }
}
