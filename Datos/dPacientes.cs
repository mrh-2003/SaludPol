using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dPacientes:MantenimientoDB
    {
        public dPacientes():base()
        {
        }
        public string insertarPacientes (ePacientes pacientes)
        {
            string insert = string.Format("insert into Paciente values({0},'{1}','{2},'{3}',{4})", pacientes.dnipaciente, pacientes.nombre, pacientes.apellido, pacientes.fechadenacimiento.ToString("yyyy-MM-dd"), pacientes.telefono);
            return Insertar(insert);
        }
        public string actualizarPacientes(ePacientes pacientes)
        {
            string update = string.Format("update Paciente set nombre='{0}', apellido = '{1}', fechadenacimiento = '{2}', telefono = {3} where dnipaciente = {4})", pacientes.nombre, pacientes.apellido, pacientes.fechadenacimiento.ToString("yyyy - MM - dd"), pacientes.telefono, pacientes.dnipaciente);
            return Actualizar(update);
        }
        public string eliminarPacientes (int dnipaciente)
        {
            string delete = string.Format("delete from Paciente where dnipaciente = {0}", dnipaciente);
            return Eliminar(delete);
        }
        public List<ePacientes> listarTodo()
        {
            try
            {
                List<ePacientes> lista = new List<ePacientes>();
                ePacientes paciente = null;
                SqlConnection conexion = db.ConectaBD();
                SqlCommand cmd = new SqlCommand("select * from Paciente", conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    paciente = new ePacientes();
                    paciente.dnipaciente = reader.GetInt32(0);
                    paciente.nombre = reader.GetString(1);
                    paciente.apellido = reader.GetString(2);
                    paciente.fechadenacimiento = reader.GetDateTime(3);
                    paciente.telefono = reader.GetInt32(4);
                    lista.Add(paciente);
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
