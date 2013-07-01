using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio
{
    public enum EstadoTarea{ Activa, Pendiente, Cancelada, Finalizada }

    public class AccionCorrectiva : Modelo<AccionCorrectiva>
    {
        public virtual string Descripcion { get; set; }
        public virtual string Objetivo { get; set; }    // ¿Cuál es el objetivo de una acción correctiva en particular?
        public virtual DateTime FechaFin { get; set; }
        protected virtual int NumEstado { get; set; } // Propiedad persistente. Es el número que representa el estado de la tarea.
        public virtual EstadoTarea Estado 
        {
            get { return (EstadoTarea)NumEstado; }
            set { NumEstado = (int)value; }
        }
        public virtual Responsable Responsable { get; set; }
        public virtual Indicador Indicador { get; set; }

        public AccionCorrectiva()
        {
            FechaFin = DateTime.Now.AddDays(1); // Por defecto la fecha fin es el día siguiente.
        }
    }
}
