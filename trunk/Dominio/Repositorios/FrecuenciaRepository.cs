using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;

namespace Repositorios
{
    public class FrecuenciaRepository : Repository<FrecuenciaRepository, Frecuencia>
    {
        public void CrearFrecuencias()
        {
            if (All().Count == 0)
            {
                Save(new Frecuencia() { Periodo = "Diaria", CantidadDias = 1, NombreFrecuenciaEspecifica = "FrecuenciaDiaria" });
                Save(new Frecuencia() { Periodo = "Semanal", CantidadDias = 7, NombreFrecuenciaEspecifica = "FrecuenciaSemanal" });
                Save(new Frecuencia() { Periodo = "Mensual", CantidadDias = 30, NombreFrecuenciaEspecifica = "FrecuenciaMensual" });
                Save(new Frecuencia() { Periodo = "Trimestral", CantidadDias = 90, NombreFrecuenciaEspecifica = "FrecuenciaTrimestral" });
                Save(new Frecuencia() { Periodo = "Anual", CantidadDias = 365, NombreFrecuenciaEspecifica = "FrecuenciaAnual" });
            }
        }
    }
}
