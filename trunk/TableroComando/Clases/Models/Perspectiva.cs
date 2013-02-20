using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroComando.Clases.Models
{
    public class Perspectiva : Modelo<Perspectiva>
    {
        //public virtual int Id { get; protected set; }
        public virtual string Nombre { get; set; }

        private IList<Objetivo> objetivos = new List<Objetivo>();
        public virtual IList<Objetivo> Objetivos
        { 
            get{ return objetivos; }
            protected set { objetivos = value; } 
        }
    }
}
