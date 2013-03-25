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
            get { return _accionCorrectiva.FechaFin; } 
        }

        public Responsable Responsable
        {
            get { return _accionCorrectiva.Responsable; }
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
