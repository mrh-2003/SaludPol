using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Datos
{
    public class DataBase
    {
        private SqlConnection conexion;
        public SqlConnection ConectaBD()
        {
            try
            {
                string cadenaConexion = "Data Source=HUB_CJ\\SQLEXPRESS;Initial Catalog=dbsaludpol;Integrated Security=True";
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (SqlException ex)
            {
                return null;
            }
        }
        public void DesconectaBD()
        {
            conexion.Close();
        }
    }
}
