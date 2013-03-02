using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Objetivo : Modelo<Objetivo>
    {
        //public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual Perspectiva Perspectiva { get; set; }

        private IList<Indicador> indicadores = new List<Indicador>();
        public virtual IList<Indicador> Indicadores { 
            get { return indicadores; }
            protected set { indicadores = value; } 
        }

        private IList<Objetivo> objetivosHijos = new List<Objetivo>();
        public virtual IList<Objetivo> ObjetivosHijos 
        {
            get { return objetivosHijos; }
            set { objetivosHijos = value; }
        }

        public virtual string NombreCompleto { get { return Perspectiva.Nombre + " - " + Nombre; } }

        /* Retorna true si contiene el objetivo pasado por parámetro, sino retorna false */
        public virtual bool ContieneObjetivo(Objetivo o)
        {
            if(ObjetivosHijos.Contains(o)) return true;
            return false;
        }
    }
}
