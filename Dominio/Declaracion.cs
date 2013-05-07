using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Declaracion : Modelo<Declaracion>
    {
        public virtual string Detalle{ get; set;}
        public virtual string Tipo { get; set; }
    }
}
