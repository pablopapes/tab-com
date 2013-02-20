using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroComando.Clases.Models
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

    }
}
