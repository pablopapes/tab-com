using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;

namespace Repositorios
{
    public class EmpresaRepository: Repository<EmpresaRepository, Empresa>
    {
        public void CrearEmpresa()
        {
            if (All().Count == 0)
            {
                Save(new Empresa { });
            }
        }
    }
}
