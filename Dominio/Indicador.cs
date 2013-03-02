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
        public virtual string OrigenDatos { get; set; }
        public virtual string Espectativa { get; set; }
        public virtual int Prioridad { get; set; }
        public virtual string Observacion { get; set; }

        public virtual Objetivo Objetivo { get; set; }
        public virtual Frecuencia Frecuencia { get; set; }
        
        private IList<Medicion> _mediciones = new List<Medicion>();
        public virtual IList<Medicion> Mediciones { get { return _mediciones; } set { _mediciones = value; } }

        public virtual void AddMediciones(List<Medicion> TodasMediciones)
        {
            int i = 0;
            foreach (Medicion m in TodasMediciones)
            {
                Console.WriteLine(Mediciones.Contains(m));
                Console.WriteLine(m.Valor);
                Console.WriteLine("-------------------------------------------");
                if (!Mediciones.Contains(m))
                {
                    Mediciones.Add(m);
                }
            }
        }
    }
} 
