using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class RestriccionPerspectiva : RestriccionGeneral
    {
        public virtual TipoRestriccion Tipo
        {
            get { return (TipoRestriccion)NumTipoRestriccion; }
            set
            {
                NumTipoRestriccion = (int)value;
                NumEstadoRestriccion = (int)DefinirEstado(value);
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
    }
}
