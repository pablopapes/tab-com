using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableroComando.Fachadas
{
    public abstract class Fachada<T> where T : Fachada<T>, new()
    {
        protected Repository Db;
        public static readonly T Instance = new T();

        protected Fachada()
        {
            Db = Repository.Instance;
        }

        //abstract public IList<T> All();

    }
}
