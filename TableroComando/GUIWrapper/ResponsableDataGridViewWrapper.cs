using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;

namespace TableroComando.GUIWrapper
{
    class ResponsableDataGridViewWrapper
    {
        private Responsable _responsable;

        public virtual string Area 
        { 
            get { return _responsable.Area; }
            set { _responsable.Area = value; } 
        }
        
        public virtual string Persona 
        { 
            get { return _responsable.Persona; } 
            set {_responsable.Persona = value; } 
        }
        
        public virtual string Email 
        {
            get { return _responsable.Email; }
            set { _responsable.Email = value; } 
        }

        public virtual string Telefono 
        {
            get { return _responsable.Telefono ; }
            set { _responsable.Telefono = value; } 
        }

        public ResponsableDataGridViewWrapper(Responsable r)
        {
            _responsable = r;
        }
        
        public Responsable GetResponsable() 
        { 
            return _responsable;  
        }
    }
}
