using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Dominio
{

    public enum TipoRestriccion { Mayor, Menor, Rango };

    public class Restriccion : Modelo<Restriccion>
    {
        public virtual decimal ValorMenor { get; set; }
        public virtual decimal ValorMayor { get; set; }
        public virtual Indicador Indicador { get; set; }

        protected virtual int NumTipoRestriccion { get; set; }
        public virtual TipoRestriccion Tipo
        {
            get { return (TipoRestriccion)NumTipoRestriccion; }
            set { NumTipoRestriccion = (int)value; }
        }

        protected virtual int NumEstadoRestriccion { get; set; }
        public virtual EstadoIndicador Estado
        {
            get { return (EstadoIndicador)NumEstadoRestriccion; }
            set { NumEstadoRestriccion = (int)value; }
        }

        public virtual int Orden { get; protected set; }

        /* Constructor */
        public Restriccion(TipoRestriccion tipo, int orden)
        {
            NumTipoRestriccion = (int)tipo;
            Orden = orden;
        }

        /* Constructor para nhibernate */
        protected Restriccion() { }

        public virtual bool Evaluar(decimal valor2)
        { 
            switch(Tipo)
            {
                case(TipoRestriccion.Mayor):
                    return valor2 > ValorMayor;
                case(TipoRestriccion.Menor):
                    return valor2 < ValorMenor;
                case(TipoRestriccion.Rango):
                    return ValorMenor <= valor2 && valor2 <= ValorMayor;
            }
            return default(bool);
        }

    }
}
