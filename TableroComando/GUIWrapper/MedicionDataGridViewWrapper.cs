using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;

namespace TableroComando.GUIWrapper
{
    class MedicionDataGridViewWrapper
    {
        private Medicion _medicion;
        public DateTime Fecha 
        { 
            get { return _medicion.Fecha; } 
            set { _medicion.Fecha = value; } 
        }

        public decimal Valor 
        {
            get { return _medicion.Valor; }
            set { _medicion.Valor = value; }
        }

        public MedicionDataGridViewWrapper(Medicion m)
        {
            _medicion = m;
        }

        // Este constructor se utiliza cuando se agrega una fila a un DataGridView
        public MedicionDataGridViewWrapper()
        {
            _medicion = new Medicion();
            Fecha = DateTime.Now;
        }

        public Medicion GetMedicion()
        {
            return _medicion;
        }
    }
}
