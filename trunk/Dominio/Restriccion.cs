using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Dominio
{

    public enum TipoRestriccion { Mayor, Menor, Rango };

    public class Restriccion : RestriccionGeneral
    {
        new public virtual EstadoIndicador Estado
        {
            get { return (EstadoIndicador)NumEstadoRestriccion; }
            set { NumEstadoRestriccion = (int)value; }
        }

        new public virtual TipoRestriccion Tipo
        {
            get { return (TipoRestriccion)NumTipoRestriccion; }
            set { NumTipoRestriccion = (int)value; }
        }

        public virtual Indicador Indicador { get; set; }

        /* Constructor */
        public Restriccion(TipoRestriccion tipo, int orden)
        {
            NumTipoRestriccion = (int)tipo;
            Orden = orden;
        }

        /* Constructor para nhibernate */
        protected Restriccion() { }

    }
}
