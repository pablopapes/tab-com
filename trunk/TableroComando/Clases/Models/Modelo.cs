using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroComando.Clases.Models
{
    public class Modelo<T>
    {
        public virtual int Id { get; protected set; }

        public override bool Equals(object obj)
        {
            Modelo<T> specificOject = (Modelo<T>)obj; 
            if (obj == null)
            {
                return false;
            }

            return (this == obj || this.Id == specificOject.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ 5;
        }
    }
}
