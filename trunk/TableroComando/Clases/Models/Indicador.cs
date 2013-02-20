using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroComando.Clases.Models
{
    public class Indicador : Modelo<Indicador>
    {
        //public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set;}
        public virtual string Codigo { get; set;}
        public virtual string Proposito { get; set; }
        public virtual string Calculo { get; set; }
        public virtual string Caracteristica { get; set; }
        public virtual string OrigenDatos { get; set; }
        public virtual string Espectativa { get; set; }
        public virtual int Prioridad { get; set; }
        public virtual string Observacion { get; set; }

        public virtual Objetivo Objetivo { get; set; }
        public virtual Frecuencia Frecuencia { get; set; }
        
        private List<Medicion> mediciones;
        public virtual List<Medicion> Mediciones { get; protected set; }

        // Frecuencias: diarias, semanal, mensual, trimestral, anual
    }
}
