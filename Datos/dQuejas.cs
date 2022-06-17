using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class dQuejas : MantenimientoDB
    {
        public dQuejas() : base ()
        {
            
        }
        public string insertarQueja(eQueja queja)
        {
            string insert = string.Format("insert into Queja values( {0}, '{1}')", queja.nrocolegiatura, queja.contenido);
            return Insertar(insert);
        }
        public List<eQueja> listarQuejas()
        {
            try
            {
                SqlConnection conexion = db.ConectaBD();
                SqlCommand comando = new SqlCommand("select * from Queja", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                List<eQueja> lista = new List<eQueja>();
                eQueja queja = null;
                while (reader.Read())
                {
                   queja = new eQueja();
                   queja.idquejas = reader.GetInt32(0);
                   queja.nrocolegiatura = reader.GetInt32(1);
                   queja.contenido = reader.GetString(2);
                   lista.Add(queja);
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
