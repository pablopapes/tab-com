using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace VerificacionDeAutenticidad
{
   public class BaseDatos
    {
        public static SQLiteConnection sql_con;
        public static SQLiteCommand sql_cmd;
        public static SQLiteDataAdapter DB;
        public static DataSet DS = new DataSet();
        public static DataTable DT = new DataTable();

      

        public static ArrayList LoadData()
        {
            ArrayList Datos = new ArrayList();
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Registro";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            if (DS.Tables[0].Rows.Count == 0)
            {
                 String[] RowsVacio = new String[]  {"",""};
                 Datos.Add(RowsVacio);
            }
            else
            {
                foreach (DataRow dtRow in DS.Tables[0].Rows)
                {
                    String[] Rows = new String[dtRow.Table.Columns.Count];
                    for (int i = 0; i <= dtRow.ItemArray.Length - 1; i++)
                    {
                        Rows[i] = dtRow[i].ToString();
                    } 
                   Datos.Add(Rows);
                }
            }
            sql_con.Close();
            return Datos;
           
        }

        public static void SetConnection()
        {
            sql_con = new SQLiteConnection
               ("Data Source=database.db;Version=3;New=False;Compress=True;");
        }

        // Ejecutar Query en Sqlite
        public static void ExecuteQuery(string txtQuery)
        {
            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandText = txtQuery;
                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
                sql_cmd.Dispose();
                sql_con.Dispose();
            }
            catch
            {
            }
        }
    }
}
