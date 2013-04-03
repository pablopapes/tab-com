using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class RestriccionPerspectiva : RestriccionGeneral
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

        private EstadoIndicador DefinirEstado(TipoRestriccion tipo)
        {
            switch (tipo)
            {
                case (TipoRestriccion.Mayor): return EstadoIndicador.Bien;
                case (TipoRestriccion.Rango): return EstadoIndicador.Regular;
                case (TipoRestriccion.Menor): return EstadoIndicador.Mal;
            }
            return default(EstadoIndicador);
        }

        public RestriccionPerspectiva(TipoRestriccion tipo) { Tipo = tipo; }
        public RestriccionPerspectiva() { }
    }
}
