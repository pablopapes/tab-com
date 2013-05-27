using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace VerificacionDeAutenticidad
{
    class ejecutar
    {
        private static MySqlCommand command;
        private static conectar Coneccion;
        private static MySqlDataAdapter adaptador;
        
        /* 
         * Creo un metodo que recibe la sentencia SQL y retorna un objeto de 
         * MySqlDataReader
         */
        public  MySqlDataReader EjecutarSQL(string Sentencia_SQL)
        {
            //INSTANCIA DEL CONECTOR
            Coneccion = new conectar();
            command = new MySqlCommand(Sentencia_SQL, Coneccion.Cnx);
            return command.ExecuteReader();
        }

        public void cerrar()
        {
            Coneccion.Dispose();
        }

        public  MySqlDataAdapter AdaptadorSQL(String Sql)
        {  
            Coneccion = new conectar();
            command = new MySqlCommand(Sql, Coneccion.Cnx);
            adaptador = new MySqlDataAdapter(command);
            return adaptador;
        }
    }
}
