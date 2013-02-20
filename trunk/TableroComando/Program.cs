using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TableroComando.Clases.Models;
using TableroComando.Fachadas;

namespace TableroComando
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Principal());
                //LoadData();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }

        static void LoadData()
        {            
            Frecuencia diaria = new Frecuencia { Periodo = "Diaria", CantidadDias = 1 };
            Frecuencia semanal = new Frecuencia { Periodo = "Semanal", CantidadDias = 7 };
            Frecuencia mensual = new Frecuencia { Periodo = "Mensual", CantidadDias = 30 };
            Frecuencia trimestral = new Frecuencia { Periodo = "Trimestral", CantidadDias = 90 };
            Frecuencia anual = new Frecuencia { Periodo = "Anual", CantidadDias = 365 };

            Repository.Instance.Session.Save(diaria);
            Repository.Instance.Session.Save(semanal);
            Repository.Instance.Session.Save(mensual);
            Repository.Instance.Session.Save(trimestral);
            Repository.Instance.Session.Save(anual);

            
            Perspectiva p1 = new Perspectiva { Nombre = "Aprendizaje y Crecimiento" };
            Perspectiva p2 = new Perspectiva { Nombre = "Procesos Internos" };
            Perspectiva p3 = new Perspectiva { Nombre = "Clientes" };
            Perspectiva p4 = new Perspectiva { Nombre = "Financiera" };
            PerspectivaFachada.Instance.Save(p1);
            PerspectivaFachada.Instance.Save(p2);
            PerspectivaFachada.Instance.Save(p3);
            PerspectivaFachada.Instance.Save(p4);

            Objetivo o1 = new Objetivo { Nombre = "Objetivo 1", Perspectiva = p1, Codigo = "1.1", Descripcion = "Descripción del objetivo 1" };
            Objetivo o2 = new Objetivo { Nombre = "Objetivo 2", Perspectiva = p1, Codigo = "2.1", Descripcion = "Descripción del objetivo 2" };
            Objetivo o3 = new Objetivo { Nombre = "Objetivo 3", Perspectiva = p2, Codigo = "3.1", Descripcion = "Descripción del objetivo 3" };
            Objetivo o4 = new Objetivo { Nombre = "Objetivo 4", Perspectiva = p3, Codigo = "4.1", Descripcion = "Descripción del objetivo 4" };
            ObjetivoFachada.Instance.Save(o1);
            ObjetivoFachada.Instance.Save(o2);
            ObjetivoFachada.Instance.Save(o3);
            ObjetivoFachada.Instance.Save(o4);

            Indicador i1 = new Indicador { Nombre = "Indicador 1", Codigo = "I1", Observacion = "Esta es una observación del indicador 1", Calculo = "Presion = (Fuerza/Area)", Frecuencia = diaria};
            Indicador i2 = new Indicador { Nombre = "Indicador 2", Codigo = "I2", Observacion = "Esta es una observación del indicador 2", Calculo = "Presion = (Fuerza/Area)", Frecuencia = mensual };
            Indicador i3 = new Indicador { Nombre = "Indicador 3", Codigo = "I3", Observacion = "Esta es una observación del indicador 3", Calculo = "Presion = (Fuerza/Area)", Frecuencia = trimestral };
            Indicador i4 = new Indicador { Nombre = "Indicador 4", Codigo = "I4", Observacion = "Esta es una observación del indicador 4", Calculo = "Presion = (Fuerza/Area)", Frecuencia = diaria };
            IndicadorFachada.Instance.Save(i1);
            IndicadorFachada.Instance.Save(i2);
            IndicadorFachada.Instance.Save(i3);
            IndicadorFachada.Instance.Save(i4);

            Repository.Instance.Session.Flush();
            //IList<Objetivo> objetivos = reposotory.Session.CreateCriteria<Objetivo>().List<Objetivo>();
        }
    }
}
