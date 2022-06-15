using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class dAdministrador:MantenimientoDB
    {
        public dAdministrador():base(){}

        public string InsertarDatosAdministrador(eAdministrador admin)
        {
            string insertar = string.Format("insert into Administrador values('{0}','{1}','{2}')", admin.usuario, admin.contra, admin.nombre);
            return Insertar(insertar);
        }
        public string ModificarDatosAdministrador(eAdministrador admin)
        {
            string update = string.Format("update Administrador set usuario='{0}',contra='{1}' where nombre='{2}'", admin.usuario, admin.contra, admin.nombre);
            return Actualizar(update);
        }
        public string EliminarAdministrador(string nombre)
        {
            string delete = string.Format("delete from Administrador where nombre='{0}'", nombre);
            return Eliminar(delete);
        }
        public List<eAdministrador> ListarAdministrador()
        {
            try
            {
                SqlConnection conexion = db.ConectaBD();
                SqlCommand comando = new SqlCommand("select * from Administrador", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                List<eAdministrador> list = new List<eAdministrador>();
                eAdministrador admintemplate = null;
                while (reader.Read())
                {
                    admintemplate= new eAdministrador();
                    admintemplate.usuario= reader.GetString(0);
                    admintemplate.contra= reader.GetString(1);
                    admintemplate.nombre= reader.GetString(2);
                    list.Add(admintemplate);
                }
                reader.Close();
                return list;
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
