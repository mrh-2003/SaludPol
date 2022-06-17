using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dTratamientoCancer : MantenimientoDB
    {
        public dTratamientoCancer() : base()
        {
        }
        public string insertarTratamiento(eTratamientoCancer obj)
        {
            string insert = string.Format("insert into TratamientoCancer values ({0}, {1}, '{2}')", obj.idtratamiento, obj.nropaccurados, obj.nombre);
            return Insertar(insert);
        }
        public string actualizarTratamiento(eTratamientoCancer obj)
        {
            string update = string.Format("update TratamientoCancer set nropaccurados = {0}, nombre = '{1}' where idtratamiento = {2}", obj.nropaccurados, obj.nombre, obj.idtratamiento);
            return Actualizar(update);
        }
        public string eliminarTratamiento(int idtratamiento)
        {
            string delete = string.Format("delete from TratamientoCancer where idtratamiento = {0}", idtratamiento);
            return Eliminar(delete);
        }
        public List<eTratamientoCancer> listarTodo()
        {
            try
            {
                List<eTratamientoCancer> lista = new List<eTratamientoCancer>();
                eTratamientoCancer obj = null;
                SqlConnection conexion = db.ConectaBD();
                SqlCommand cmd = new SqlCommand("select * from TratamientoCancer", conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    obj = new eTratamientoCancer();
                    obj.idtratamiento = reader.GetInt32(0);
                    obj.nropaccurados = reader.GetInt32(1);
                    obj.nombre = reader.GetString(2);
                    lista.Add(obj);
                }
                reader.Close();
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                db.DesconectaBD();
            }
        }
    }
}    
