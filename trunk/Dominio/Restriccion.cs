using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Dominio
{
    public class Restriccion
    {
        public enum Tipo { Malo, Regular, Bueno};
        public virtual decimal ValorMenor { get; set; }
        public virtual decimal ValorMayor { get; set; }
        protected int Definicion { get; set; } // Define si es Malo = 0, Regular = 1 o Bueno = 2
        public Tipo TipoDefinicion // retorna o setea la propiedad Definicion pero con enum
        {
            get { return (Tipo)Definicion; }
            set { Definicion = (int)value; }
        }
        protected virtual string NombreRestriccion{get; set;}
        protected RestriccionEspecifica RestriccionEspec
        {
            get
            {
                Type tipoRestriccion = Type.GetType(string.Format("Dominio.Restriccion+{0}", NombreRestriccion));
                return (RestriccionEspecifica)Activator.CreateInstance(tipoRestriccion, this);
            }
        }

        public Restriccion(RestriccionEspecifica restriccion)
        {
            NombreRestriccion = restriccion.GetType().Name;
        }

        public bool Evaluar(decimal Valor2)
        {
            
            return true;
                /*(bool)tipoRestriccion.InvokeMember("Evaluar",
                BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static,
                null,
                null,
                new object[] { this, Valor2 });*/
        }


        protected abstract class RestriccionEspecifica
        {
            
            public abstract bool Evaluar(Restriccion restriccion, decimal Valor);
        }

        /* Clases anidadas */
        protected class Menor : RestriccionEspecifica
        {
            public override bool Evaluar(Restriccion restriccion, decimal ValorMenor)
            {
                return ValorMenor <= restriccion.ValorMenor;
            }
        }

        protected class Mayor : RestriccionEspecifica
        {
            public override bool Evaluar(Restriccion restriccion, decimal valorMayor)
            {
                return valorMayor > restriccion.ValorMenor;
            }
        }

        protected class Rango : RestriccionEspecifica 
        {
            public override bool Evaluar(Restriccion restriccion, decimal valorMedio)
            {
                return true; // Menor.Evaluar(restriccion, valorMedio) && Mayor.Evaluar(restriccion, valorMedio);
            }
        }
    }
}
