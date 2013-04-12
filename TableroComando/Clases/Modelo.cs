using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominio;
using System.Drawing;
using Repositorios;

namespace TableroComando.Clases
{
    class Modelo
    {
       
            public string Nombre;
            public string Unidad;
            public Color Color;
            public String UltimaMed;
            public String FechaUltMed;
            public Objetivo Objetivo;
            public Indicador Indicador;
            public bool isPerspective = false;
            public bool isObjetive = false;
            public IList<Objetivo> ListaObjetivo;
            public IList<Indicador> ListaIndicadores;
            private List<Modelo> children;

            // Crear el Hijo

            public List<Modelo> Children
            {
                get
                {

                    if (this.children == null)
                    {
                        if (this.ListaIndicadores != null)
                        {

                            children = CreateModelInd(this, this.ListaIndicadores);
                        }
                        else
                        {
                            children = CreateModelObj(this, this.ListaObjetivo);
                        }
                    }

                    return this.children;
                }
                set { this.children = value; }
            }

            // MODELOS

            // Modelo de Perspectiva
            public static List<Modelo> CreateModelPers(Modelo Padre, IList<Perspectiva> ListaPerspectiva)
            {
                // lista de Restricciones de perspectiva
                IList<RestriccionPerspectiva> restriccionesPersp = RestriccionGeneralRepository.Instance.All<RestriccionPerspectiva>();

                List<Modelo> ListaPersp = new List<Modelo>();

                foreach (Perspectiva pers in ListaPerspectiva)
                {
                    ListaPersp.Add(new Modelo { Nombre = pers.Nombre, ListaObjetivo = pers.Objetivos, Color = VisualHelper.GetColor(pers.Estado(restriccionesPersp)), isPerspective = true });
                }

                return ListaPersp;
            }

            // Modelo de Objetivos
            public static List<Modelo> CreateModelObj(Modelo Padre, IList<Objetivo> ListaObjetivo)
            {
                List<Modelo> ListaObjetivos = new List<Modelo>();
                // Lista de Restricciones de Objetivos
                IList<RestriccionObjetivo> restriccionesObj = RestriccionGeneralRepository.Instance.All<RestriccionObjetivo>();


                foreach (Objetivo Obj in ListaObjetivo)
                {
                    ListaObjetivos.Add(new Modelo { Nombre = Obj.Nombre, ListaIndicadores = Obj.Indicadores, Color = VisualHelper.GetColor(Obj.Estado(restriccionesObj)), isObjetive = true , Objetivo = Obj});
                }

                return ListaObjetivos;
            }

            // Modelo de Indicadores
            public static List<Modelo> CreateModelInd(Modelo Padre, IList<Indicador> ListaIndicador)
            {
                List<Modelo> ListaIndicadores = new List<Modelo>();

                foreach (Indicador Ind in ListaIndicador)
                {
                    if (Ind.Mediciones.Count > 0)
                    {
                        Medicion Med = Ind.Mediciones.Last();

                        ListaIndicadores.Add(new Modelo { Nombre = Ind.Codigo + " - " + Ind.Nombre, Color = VisualHelper.GetColor(Ind.Estado), Unidad = Ind.Unidad, UltimaMed = Med.Valor.ToString(), FechaUltMed = Med.Fecha.Date.ToShortDateString(), Indicador = Ind });
                    }
                    else
                    {

                        ListaIndicadores.Add(new Modelo { Nombre = Ind.Codigo + " - " + Ind.Nombre, Color = VisualHelper.GetColor(Ind.Estado), Unidad = Ind.Unidad , Indicador = Ind });
                    }

                }

                return ListaIndicadores;
            }
    }
}
