using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;

namespace TableroComando.GUIWrapper
{
    class ObjetivoDataGridViewWrapper
    {
        private Objetivo objetivo;
        
        public string Nombre { 
            get { return objetivo.Nombre; }
            private set { Nombre = objetivo.Nombre; }
        }

        public string Perspectiva
        {
            get{ return objetivo.Perspectiva.Nombre; }
            private set{ Perspectiva = objetivo.Perspectiva.Nombre; }
        }

        public bool Pertenece { get; set; }

        /* Constructor */
        public ObjetivoDataGridViewWrapper(Objetivo o)
        {
            objetivo = o;
        }

        /* Retorna el objetivo que tiene como atributo */
        public Objetivo GetObjetivo()
        {
            return objetivo;
        }

        /* 
         * Asigna un valor a la propiedad Pertenece.
         * true si el objetivo atributo es hijo del objetivo pasado por parámetro 
         */
        public void Check(Objetivo o)
        {
            Pertenece = o.ContieneObjetivo(objetivo);   
        }
        
    }
}
