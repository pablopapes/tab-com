using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Perspectiva : Modelo<Perspectiva>
    {
        //public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }

        private IList<Objetivo> objetivos = new List<Objetivo>();
        public virtual IList<Objetivo> Objetivos
        { 
            get{ return objetivos; }
            protected set { objetivos = value; } 
        }

        public virtual decimal EstadoPorcentual { get { return Objetivos.Sum(o => o.EstadoPorcentual); } }
        
        public virtual EstadoIndicador Estado(IEnumerable<RestriccionPerspectiva> restricciones)
        {
            foreach (RestriccionPerspectiva restriccion in restricciones)
            {
                if (restriccion.Evaluar(EstadoPorcentual)) return restriccion.Estado;
            }
            return default(EstadoIndicador);
        }

        public override string ToString()
        {
            return Nombre;
        }


        
    }
}
