using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RRHH.BLL;
using System.Windows.Forms;

namespace RRHH.DAL
{
    class LoginDAL
    {
        ConexionDAL conexion;

        public LoginDAL ()
        {
            conexion = new ConexionDAL();
        }

        public bool validar(string user, string clave)
        {
            SqlCommand query = new SqlCommand();
            query.CommandText = "SELECT * FROM usuarios WHERE usuario = @user AND password = @clave";
            query.Parameters.AddWithValue("@user", user);
            query.Parameters.AddWithValue("@clave", clave);
            query.Connection = conexion.conectar();
            conexion.abrir();
            SqlDataReader queryResult = query.ExecuteReader();
            if (queryResult.Read())
            {
                Console.WriteLine("Encontrado");
                return true;
            } else
            {
                Console.WriteLine("No encontrado");
                return false;
            }
            conexion.cerrar();

        }
    }
}
