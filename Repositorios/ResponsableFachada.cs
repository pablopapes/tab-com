using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;

namespace TableroComando.Fachadas
{
    class ResponsableFachada : Fachada<ResponsableFachada>
    {
        public void Save(Responsable r)
        {
            base.Save<Responsable>(r);
        }
    }
}
