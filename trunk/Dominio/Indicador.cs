using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Dominio
{
    public class Indicador : Modelo<Indicador>
    {
        public virtual string Nombre { get; set;}
        public virtual string Codigo { get; set;}
        public virtual string Proposito { get; set; }
        public virtual string Calculo { get; set; }
        public virtual string Caracteristica { get; set; }
        public virtual Responsable Responsable { get; set; }
        public virtual string Espectativa { get; set; }
        public virtual int Prioridad { get; set; }
        public virtual string Observacion { get; set; }
        public virtual decimal? ValorEsperado { get; set; }

        public virtual Objetivo Objetivo { get; set; }
        public virtual Frecuencia Frecuencia { get; set; }
        
        private IList<Medicion> _mediciones = new List<Medicion>();
        public virtual IList<Medicion> Mediciones 
        { 
            get { return _mediciones; } 
            protected set { _mediciones = value; } 
        }

        public virtual void AddMediciones(List<Medicion> TodasMediciones)
        {
            // Obtengo solo las nuevas mediciones que no están guardadas aún
            List<Medicion> nuevasMediciones = TodasMediciones.Except(Mediciones).ToList(); 
            foreach (Medicion m in nuevasMediciones)
            {
                Mediciones.Add(m);
            }
        }
    }
} 
