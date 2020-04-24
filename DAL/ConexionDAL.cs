using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RRHH.DAL
{
    class ConexionDAL
    {
        //private static string dbUser = "DESKTOP-9LV57DI\\SQLEXPRESS";
        private static string dbUser = "DESKTOP-F0AK4UN";
        private static string db = "etps4_rrhh";
        string cadena = $"Data Source = {dbUser}; Initial Catalog = {db}; Integrated Security = True";
        SqlConnection conexion;

        public SqlConnection conectar ()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = cadena;
            return conexion;
        }

        public void abrir ()
        {
            try
            {
                conexion.Open();
            } catch (Exception e)
            {
                Console.WriteLine("Error de BD: " + e.Message);
            }
        }

        public void cerrar ()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error de BD: " + e.Message);
            }
        }

        public bool pruebaConectar()
        {
            try
            {
                SqlCommand query = new SqlCommand();
                query.CommandText = "SELECT * FROM niveles_usuarios";
                query.Connection= conectar();
                conexion.Open();
                query.ExecuteNonQuery();
                conexion.Close();

                return true;
            } catch
            {
                return false;
            }
        }
    }
}
