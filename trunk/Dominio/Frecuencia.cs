using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrecuenciaStrategy;

namespace Dominio
{
    public class Frecuencia : Modelo<Frecuencia>
    {
        public virtual string Periodo { get; set; }
        public virtual int CantidadDias { get; set; }
        public virtual IList<Indicador> Indicadores { get; protected set; }
        public virtual string NombreFrecuenciaEspecifica { get; set; }

        protected FrecuenciaEspecifica _frecuenciaEspecifica;
        protected FrecuenciaEspecifica FrecuenciaEspecifica
        {
            get
            {
                if(_frecuenciaEspecifica == null)
                {
                    Type type = Type.GetType("FrecuenciaStrategy." + NombreFrecuenciaEspecifica + ",FrecuenciaStrategy");

                    if (type == null) throw new ArgumentException("No such type: " + type);
                    if (!typeof(FrecuenciaEspecifica).IsAssignableFrom(type)) throw new ArgumentException("Type " + type +" is not compatible with FooParent.");
                    _frecuenciaEspecifica = (FrecuenciaEspecifica) Activator.CreateInstance(type);
                }
  
                return _frecuenciaEspecifica;
            }
         }
        
        
        public virtual DateTime ProximaFechaMedicion(DateTime fecha)
        {
            return fecha.AddDays(CantidadDias);
        }

        public virtual DateTime ProximaMedicion(DateTime ultimaMedicion)
        {
            return FrecuenciaEspecifica.ProximaMedicion(ultimaMedicion);
        }

        public virtual bool RequiereMedicion(DateTime ultimaMedicion)
        {
            return FrecuenciaEspecifica.RequiereMedicion(ultimaMedicion);
        }

    }
}
