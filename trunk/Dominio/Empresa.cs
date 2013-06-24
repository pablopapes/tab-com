using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public class Empresa : Modelo<Empresa>
    {
        public virtual string Mision { get; set; }
        public virtual string Vision { get; set; }
        public virtual string Valores { get; set; }
        public virtual string Denominacion { get; set; }
        public virtual string Cuit { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string Autoridades { get; set; }
    }
}
