using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Dominio.Validations;

namespace Dominio
{

    public enum EstadoIndicador
    {
        Mal,
        Regular,
        Bien, // Bueno = 2 por lo tanto para promediar todos los indicadores habrá que dividir por 2
        NoDefinido
    };

    public class Indicador : Modelo<Indicador>
    {
        /*********** Definición de propiedades **************/

        public virtual string Nombre { get; set;}
        public virtual string Codigo { get; set;}
        public virtual string Proposito { get; set; }
        public virtual string Calculo { get; set; }
        public virtual string Caracteristica { get; set; }
        public virtual Responsable Responsable { get; set; }
        public virtual string Espectativa { get; set; }
        public virtual int Prioridad { get; set; }
        public virtual string Observacion { get; set; }
        public virtual decimal ValorEsperado { get; set; }
        protected virtual DateTime FechaCreacion { get; set; }
        public virtual Objetivo Objetivo { get; set; }
        public virtual Frecuencia Frecuencia { get; set; }
        public virtual string Unidad { get; set; }

        public virtual EstadoIndicador Estado
        {
            get
            {
                if (Mediciones.Count != 0)
                {
                    decimal ultimoValorMedicion = Mediciones.Last().Valor;

                    /* 
                     * Se evalúa cada restriccion para evaluar en en qué restriccion se encuentra ultimoValorMedicion 
                     * y así conocer el estado del indicador en función de la última medicion
                     * 
                     */
                    foreach (Restriccion r in Restricciones)
                    {
                        if (r.Evaluar(ultimoValorMedicion)) return r.Estado;
                    }
                }
                return EstadoIndicador.NoDefinido;
            }
        }

        /* Mediciones */
        private IList<Medicion> _mediciones = new List<Medicion>();
        public virtual IList<Medicion> Mediciones 
        { 
            get 
            {
                return _mediciones; 
            } 
            protected set { _mediciones = value; } 
        }

        /* Restricciones */
        private IList<Restriccion> _restricciones = new List<Restriccion>();
        public virtual IList<Restriccion> Restricciones
        {
            get
            {
                if (_restricciones.Count == 0) // Si no hay restricciones definidas, por defecto se crean 3.
                {
                    CrearRestriccion(TipoRestriccion.Menor, 1);
                    CrearRestriccion(TipoRestriccion.Rango, 2);
                    CrearRestriccion(TipoRestriccion.Mayor, 5);
                }
                return _restricciones; 
            }
            set { _restricciones = value; }
        }

        /* Acciones Correctivas */
        private IList<AccionCorrectiva> _acciones = new List<AccionCorrectiva>();
        public virtual IList<AccionCorrectiva> Acciones
        {
            get { return _acciones; }
            set { _acciones = value; }
        }

        public virtual DateTime UltimaFechaMedicion
        {
            get { return (Mediciones.Count == 0) ? FechaCreacion : Mediciones.Last().Fecha; }
        }

        public virtual bool RequiereMedicion
        {
            get { return Frecuencia.RequiereMedicion(UltimaFechaMedicion); }
        }

        public virtual DateTime ProximaFechaMedicion
        {
            get { return Frecuencia.ProximaFechaMedicion(UltimaFechaMedicion); }
        }


        /************* Constructor *************/

        public Indicador()
        {
            Validator = new IndicadorValidator();

            if (FechaCreacion.Year == 1) // Fecha de creación será null si el indicador es nuevo, es ese caso, se le asigna la fecha actual.
            {
                FechaCreacion = DateTime.Now;
            }    
        }

        /************* Métodos *****************/

        public virtual void AddMediciones(List<Medicion> TodasMediciones)
        {
            // Obtengo solo las nuevas mediciones que no están guardadas aún
            List<Medicion> nuevasMediciones = TodasMediciones.Except(Mediciones).ToList(); 
            foreach (Medicion m in nuevasMediciones)
            {
                Mediciones.Add(m);
            }
        }

        public override string ToString()
        {
            return Codigo + " - " + Nombre;
        }


        public virtual Medicion CrearMedicion()
        {
            return new Medicion { Indicador = this, Frecuencia = this.Frecuencia };
        }
        public virtual void AddMedicion(Medicion medicionActual)
        {
            Mediciones.Add(medicionActual);
        }

        public virtual Restriccion CrearRestriccion(TipoRestriccion tipo)
        {
            return CrearRestriccion(tipo, Restricciones.Count);
        }

        protected virtual Restriccion CrearRestriccion(TipoRestriccion tipo, int orden)
        {
            Restriccion restriccion = new Restriccion(tipo, orden) { Indicador = this };
            _restricciones.Add(restriccion);
            return restriccion;
        }
    }

   
} 
