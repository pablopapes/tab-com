using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace VerificacionDeAutenticidad
{
    class conectar
    {

        private string connStr = null;
        private MySqlConnection conn = null;

        public void ConectarMySql()
        {
            //conectar con Mysql
            //se conecta con MySQl 
            //Server: nombre del servidor
            //Database:nombre de la base de datos (no va con ningun tipo de extencion)
            //Uid:Usuario(Standard=root) no soporta el usuario vacío
            //Pwd:clave de acceso (si la tiene)
            //Port:default=3306(si no se coloca se toma el default)
            connStr = "Server=flexitargentina.com.ar;Database=flexitar_tableroClientes;Uid=flexitar_Tablero;Pwd=0K%^I)+$_8L}V=84J$;Port=3306;Pooling=false;Connection Lifetime=1; Max Pool Size=1;Allow Zero Datetime=True;Convert Zero Datetime=True";
            conn = new MySqlConnection(connStr);

        }
        public void Dispose()
        {
         Dispose(true);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                   
                }
            }
        }


        public MySqlConnection Cnx
        {
            get
            {
                ConectarMySql();
                conn.Open();
                return conn;
            }
            
        }
    }
}
