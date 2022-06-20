using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dDoctor : MantenimientoDB
    {
        public dDoctor() : base()
        {
        }
        public string insertarDoctor(eDoctor doctor)
        {
            string insert = string.Format("insert into Doctor values ({0}, '{1}', '{2}', '{3}', {4}, {5})", doctor.nrocolegiatura, doctor.contra, doctor.nombre, doctor.apellido, doctor.telefono, doctor.especialidad.idespecialidad);
            return Insertar(insert);
        }
        public string actualizarDoctor(eDoctor doctor)
        {
            string update = string.Format("update Doctor set nombre='{0}',apellido='{1}',contra='{2}',telefono={3},idespecialidad={4} where nrocolegiatura={5}", doctor.nombre, doctor.apellido, doctor.contra, doctor.telefono, doctor.especialidad.idespecialidad, doctor.nrocolegiatura);
            return Actualizar(update);
        }
        public string eliminarDoctor(int nrocolegiatura)
        {
            string delete = string.Format("delete from Doctor where nrocolegiatura={0}", nrocolegiatura);
            return Eliminar(delete);
        }
        public List<eDoctor> listarTodo()
        {
            try
            {
                List<eDoctor> lista = new List<eDoctor>();
                eDoctor doctor = null;
                SqlConnection conexion = db.ConectaBD();
                SqlCommand cmd = new SqlCommand("select d.nrocolegiatura, d.contra, d.nombre, d.apellido, d.telefono, e.idespecialidad, e.nombre especialidad from doctor d, especialidad e where d.idespecialidad = e.idespecialidad", conexion);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    doctor = new eDoctor();
                    doctor.nrocolegiatura = reader.GetInt32(0);
                    doctor.contra = reader.GetString(1);
                    doctor.nombre = reader.GetString(2);
                    doctor.apellido = reader.GetString(3);
                    doctor.telefono = reader.GetInt32(4);
                    doctor.especialidad.idespecialidad = reader.GetInt32(5);
                    doctor.especialidad.nombre = reader.GetString(6);
                    lista.Add(doctor);
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
