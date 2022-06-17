using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class dEspecialidad : MantenimientoDB
    {
       
      public dEspecialidad() : base()
      {
      }
      public string insertEspecialidad(eEspecialidad especialidad)
      {
          string insert = string.Format("insert into Especialidad values('{0}')", especialidad.nombre);
          return Insertar(insert);
      }
      public string actualizarEspecialidad(eEspecialidad especialidad)
      {
            string update = string.Format("update Especialidad set nombre='{0}' where idespecialidad={1}", especialidad.nombre, especialidad.idespecialidad);
            return Actualizar(update);
      }
      public string eliminarEspecialidad(int idespe)
      {
          string delete = string.Format("delete from Especialidad where idespecialidad={0}", idespe);
          return Eliminar(delete);
      }
      public List<eEspecialidad> listarTodo()
      {
          try
          {
              SqlConnection conexion = db.ConectaBD();
              SqlCommand comando = new SqlCommand("select * from Especialidad", conexion);
              SqlDataReader reader = comando.ExecuteReader();
              List<eEspecialidad> lista = new List<eEspecialidad>();
              eEspecialidad especialidad = null;
              while (reader.Read())
              {
                  especialidad = new eEspecialidad();
                  especialidad.idespecialidad = reader.GetInt32(0);
                  especialidad.nombre = reader.GetString(1);
                 
                  lista.Add(especialidad);
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
