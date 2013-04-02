using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class RestriccionObjetivo : RestriccionGeneral
    {
        new public virtual TipoRestriccion Tipo
        {
            get { return (TipoRestriccion)NumTipoRestriccion; }
            protected set
            {
                NumTipoRestriccion = (int)value;
                switch (value)
                {
                    case (TipoRestriccion.Mayor):
                        NumEstadoRestriccion = (int)EstadoIndicador.Bien;
                        Orden = 2;
                        break;
                    case (TipoRestriccion.Rango): 
                        NumEstadoRestriccion = (int)EstadoIndicador.Regular;
                        Orden = 1;
                        break;
                    case (TipoRestriccion.Menor): 
                        NumEstadoRestriccion = (int)EstadoIndicador.Mal;
                        Orden = 0;
                        break;
                }
            }
        }
        /*
        public virtual EstadoObjetivo Estado
        {
            get { return (EstadoObjetivo)NumEstadoRestriccion; }
            set { NumEstadoRestriccion = (int)value; }
        }
        */
        public RestriccionObjetivo(TipoRestriccion tipo)
        {
            Tipo = tipo;
        }

        public RestriccionObjetivo() { }

    }
}

