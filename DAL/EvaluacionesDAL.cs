﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RRHH.DAL
{
    public class EvaluacionesDAL
    {
        ConexionDAL conexion;

        public EvaluacionesDAL ()
        {
            conexion = new ConexionDAL();
        }

        public DataSet getEvaluaciones (int top = 0)
        {
            SqlCommand query = new SqlCommand();

            if (top > 0)
            {
                query.CommandText = "SELECT " +
                "TOP (@top)" +
                "evaluaciones.id_evaluacion AS ID, " +
                "evaluaciones.evaluacion AS Evaluacion, " +
                "tipos_evaluaciones.tipo_evaluacion AS \"Tipo evaluacion\", " +
                "evaluaciones.objetivos AS Objetivos, " +
                "evaluaciones.descripcion AS Descripcion, " +
                "evaluaciones.puntaje_maximo AS \"Nota Maxima\" " +
                "FROM evaluaciones " +
                "JOIN tipos_evaluaciones ON evaluaciones.id_tipo_evaluacion = tipos_evaluaciones.id_tipo_evaluacion";
                query.Parameters.AddWithValue("@top", top);
            } else
            {
                query.CommandText = "SELECT " +
                "evaluaciones.id_evaluacion AS ID, " +
                "evaluaciones.evaluacion AS Evaluacion, " +
                "tipos_evaluaciones.tipo_evaluacion AS \"Tipo evaluacion\", " +
                "evaluaciones.objetivos AS Objetivos, " +
                "evaluaciones.descripcion AS Descripcion, " +
                "evaluaciones.puntaje_maximo AS \"Nota Maxima\" " +
                "FROM evaluaciones " +
                "JOIN tipos_evaluaciones ON evaluaciones.id_tipo_evaluacion = tipos_evaluaciones.id_tipo_evaluacion";
            }
            
            return conexion.selectQuery(query);
        }
    }
}
