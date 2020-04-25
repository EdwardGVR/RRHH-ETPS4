using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RRHH.DAL
{
    public class UsuariosDAL
    {
        ConexionDAL conexion;

        public UsuariosDAL ()
        {
            conexion = new ConexionDAL();
        }

        public DataSet getUsuarios ()
        {
            SqlCommand query = new SqlCommand();
            query.CommandText = "SELECT " +
                "usuarios.id_usuario AS ID, " +
                "usuarios.nombres AS Nombres, " +
                "usuarios.apellidos AS Apellidos, " +
                "usuarios.correo AS Correo, " +
                "usuarios.usuario AS Usuario, " +
                "estados_usuarios.estado_usuario AS Estado, " +
                "niveles_usuarios.nivel_usuario AS Nivel, " +
                "usuarios.fecha_creacion AS \"Fecha registro\" " +
                "FROM usuarios " +
                "JOIN estados_usuarios ON usuarios.id_estado_usuario = estados_usuarios.id_estado_usuario " +
                "JOIN niveles_usuarios ON usuarios.id_nivel = niveles_usuarios.id_nivel_usuario";
            return conexion.selectQuery(query);
        }
    }
}
