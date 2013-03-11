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
        public virtual string FrecuenciaEspecifica { get; set; }
        protected FrecuenciaEspecifica _frecuenciaEspecifica;

        public Frecuencia()
        {
            Console.WriteLine("Frecuencia {0}", this is NHibernate.Proxy.INHibernateProxy);
            if (this is NHibernate.Proxy.INHibernateProxy && Id != 0) 
                _frecuenciaEspecifica = GetFrecuenciaEspecifica();
        }
        
        public virtual DateTime ProximaFechaMedicion(DateTime fecha)
        {
            return fecha.AddDays(CantidadDias);
        }

        public virtual DateTime ProximaMedicion(DateTime ultimaMedicion)
        {
            return _frecuenciaEspecifica.ProximaMedicion(ultimaMedicion);
        }

        public virtual bool RequiereMedicion(DateTime ultimaMedicion)
        {
            return _frecuenciaEspecifica.RequiereMedicion(ultimaMedicion);
        }

        protected virtual FrecuenciaEspecifica GetFrecuenciaEspecifica()
        {
            Console.WriteLine(Id);
            Type type = Type.GetType("FrecuenciaStrategy." + FrecuenciaEspecifica + ",FrecuenciaStrategy");

            if (type == null)
            {
                throw new ArgumentException("No such type: " + type);
            }
            if (!typeof(FrecuenciaEspecifica).IsAssignableFrom(type))
            {
                throw new ArgumentException("Type " + type +
                                    " is not compatible with FooParent.");
    }
            return (FrecuenciaEspecifica) Activator.CreateInstance(type);
        }
    }
}
