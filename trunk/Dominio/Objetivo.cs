using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio.Validations;

namespace Dominio
{

    public enum EstadoObjetivo { Malo, Regular, Bueno };

    public class Objetivo : Modelo<Objetivo>
    {
        public virtual string Nombre { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual int PorcentajeRelevancia { get; set; }

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

        /* Retorna el número que representa en qué grado se ha cumplido el objetivo entre 0 y 1 */
        public virtual decimal EstadoRelativo
        {
            get
            {
                if (Indicadores.Count > 0)
                {
                    decimal sumaEstadoIndicadores = Indicadores.Sum(i => (int)i.Estado);
                    return sumaEstadoIndicadores / ((int)EstadoIndicador.Bien * Indicadores.Count);
                }
                else
                {
                    return 0;
                }
            }
        }
        
        /* Retorna en qué estado se encuentra el objetivo respecto de la relevacia que tiene en la perspectiva */
        public virtual decimal EstadoPorcentual
        {
            get 
            {
                return (EstadoRelativo * PorcentajeRelevancia);
            }
        }

        public Objetivo()
        {
            Validator = new ObjetivoValidator();

            PorcentajeRelevancia = 1; // Por defecto, el porcentaje de relevancia es 1%
        }

        /* Devuelve un EstadoObjetivo que representa si su estado es Bien, Mal, Regular */
        public virtual EstadoIndicador Estado(IEnumerable<RestriccionObjetivo> restricciones)
        {
            foreach (RestriccionObjetivo restriccion in restricciones)
            {
                if (restriccion.Evaluar(EstadoPorcentual)) return restriccion.Estado;
            }
            return default(EstadoIndicador);
        }
       
        /* Retorna true si contiene el objetivo pasado por parámetro, sino retorna false */
        public virtual bool ContieneObjetivo(Objetivo o)
        {
            return ObjetivosHijos.Contains(o);
        }

    }
}
