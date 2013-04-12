using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Responsable : Modelo<Responsable>
    {
        public virtual string Area{get; set;}
        public virtual string Persona {get; set;}
        public virtual string Email { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string Codigo { get; set; }

        private IList<Indicador> _indicadores = new List<Indicador>();
        public virtual IList<Indicador> Indicadores 
        { 
            get { return _indicadores; }
            protected set { _indicadores = value; }
        }

        public override string ToString()
        {
            return Area;
        }

    }
}
