using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class MantenimientoDB
    {
        protected DataBase db;
        public MantenimientoDB()
        {
            db = new DataBase();
        }
        public string Insertar(string insert)
        {
            try
            {
                SqlConnection conexion = db.ConectaBD();
                SqlCommand comando = new SqlCommand(insert, conexion);
                comando.ExecuteNonQuery();
                return "Se insertó correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaBD();
            }
        }
        public string Actualizar(string update)
        {
            try
            {
                SqlConnection conexion = db.ConectaBD();
                SqlCommand comando = new SqlCommand(update, conexion);
                comando.ExecuteNonQuery();
                return "Se actualizó correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaBD();
            }
        }
        public string Eliminar(string delete)
        {
            try
            {
                SqlConnection conexion = db.ConectaBD();
                SqlCommand comando = new SqlCommand(delete, conexion);
                comando.ExecuteNonQuery();
                return "Se eliminó correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaBD();
            }
        }
    }
}
