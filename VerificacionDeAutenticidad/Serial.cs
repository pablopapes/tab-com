using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System.Data.SQLite; 
using Microsoft.Win32;
using System.Collections;
namespace VerificacionDeAutenticidad
{


    public partial class Serial : Form
    {
       
   
        

        public Serial()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            // Guardo los valores ingresado de Nombre y Serial en la BD
            BaseDatos.ExecuteQuery("delete from Registro;");
            BaseDatos.ExecuteQuery("insert into Registro VALUES ('" + TxtNombre.Text + "','" + TxtSerial.Text + "');");
           if (Verificador())
           {
               MessageBox.Show("Su Codigo  a sido Activado! Por favor Vuelva a iniciar la Aplicación","Codigo Activado",MessageBoxButtons.OK,MessageBoxIcon.Information);
               this.Close();
     
           }
           else
           {

               MessageBox.Show("El Codigo No es Valido", "Codigo Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }

           
        }
                

        private bool Verificador()
        {
            ArrayList DatosNombreSerial = BaseDatos.LoadData();

            String[] ListaNombreYSerial = (string[])DatosNombreSerial[0];
            String Nombre = ListaNombreYSerial[0];
            String Serial = ListaNombreYSerial[1];

            if ((Nombre == "") | (Serial == ""))
            {
                return false;
            }
            else
            {
                // Comprueba que el serial sea valido
                if (ComprobarSerial(Serial))
                {

                }
                else
                {
                    return false;
                }

                // Verifica el nombre con el servidor online
                if (VerificarOnline(Nombre))
                {
                    
                    // Creo el registro para verificar al iniciar el software
                    RegistryKey registryAccess = Registry.Users;
                    registryAccess = registryAccess.OpenSubKey(".DEFAULT\\software", true);
                    RegistryKey rk2 = registryAccess.CreateSubKey("FlexitTC");
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }




        private bool VerificarOnline(string Nombre)
        {
            string Query = "Select Verificado from usuarios where Nombre = '" + Nombre+ "';" ;
            ejecutar VerificarObject = new ejecutar();
            MySqlDataReader Verificar = VerificarObject.EjecutarSQL(Query);

            if (Verificar.HasRows == false)
            {
                BaseDatos.ExecuteQuery("delete from Registro;");
                return false;
            }
            else
            {
                Verificar.Read();
                if (Verificar.GetString("Verificado") == "False")
                {
                    string QueryUsuario = "UPDATE usuarios SET Verificado = True where Nombre = '" + Nombre + "';";
                    ejecutar UpdateUsuarioObject = new ejecutar();
                    MySqlDataReader UpdateUsuario = VerificarObject.EjecutarSQL(QueryUsuario);

                    return true;
                }
                else
                {
                    BaseDatos.ExecuteQuery("delete from Registro;");
                    return false;
                }
            }

        }

        private bool VerificarRegistro()
        {
            RegistryKey registryAccess = Registry.Users;
            registryAccess = registryAccess.OpenSubKey(".DEFAULT\\Software\\FlexitTC", true);

            if (registryAccess == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       

        private string Encoding64B(string serial)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(serial));

        }

        private string Decoding64B(string serial)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(serial));
        }

        private bool ComprobarSerial(string Serial)
        {
            try
            {
                Serial = Decoding64B(Serial);
                DateTime dt = Convert.ToDateTime(Serial);
                return true;
            }
            catch
            {
                BaseDatos.ExecuteQuery("delete from Registro;");
                return false;
            }
        }

        private void Serial_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
