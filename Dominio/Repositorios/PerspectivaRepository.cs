using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using Repositorios;

namespace TableroComando.Dominio
{
    public class PerspectivaRepository : Repository<PerspectivaRepository, Perspectiva>
    {
        public void CrearPerspectivas()
        {
            if (All().Count == 0)
            {
                Save(new Perspectiva { Nombre = "Finanzas" });
                Save(new Perspectiva { Nombre = "Clientes" });
                Save(new Perspectiva { Nombre = "Procesos Internos" });
                Save(new Perspectiva { Nombre = "Aprendizajes" });
            }
        }
    }
}
