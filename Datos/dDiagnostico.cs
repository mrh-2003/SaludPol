using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dDiagnostico : MantenimientoDB
    {
        public dDiagnostico() : base()
        {
        }
        public string insertarDiagnostico(eDiagnostico diagnostico)
        {
            string insert = string.Format("insert into Diagnostico values ('{0}')", diagnostico.nombre);
            return Insertar(insert);
        }
        public string actualizarDiagnostico(eDiagnostico diagnostico)
        {
            string update = string.Format("update Diagnostico set nombre='{0}' where iddiagnostico={1}", diagnostico.nombre, diagnostico.iddiagnostico);
            return Insertar(update);
        }
        public string eliminarDiagnostico(int iddiagnostico)
        {
            string delete = string.Format("delete from Diagnostico where iddiagnostico={0}", iddiagnostico);
            return Eliminar(delete);
        }
        public List<eDiagnostico> listarTodo()
        {
            try { 
                List<eDiagnostico> lista = new List<eDiagnostico>();
                eDiagnostico diagnostico = null;
                SqlConnection conexion = db.ConectaBD();
                SqlCommand comando = new SqlCommand("select * from Diagnostico", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    diagnostico = new eDiagnostico();
                    diagnostico.iddiagnostico = reader.GetInt32(0);
                    diagnostico.nombre = reader.GetString(1);
                    lista.Add(diagnostico);
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
