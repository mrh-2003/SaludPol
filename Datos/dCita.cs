using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class dCita : MantenimientoDB
    {
        public dCita() : base()
        {
        }
        public string insertarCita(eCita cita)
        {
            string insert = string.Format("insert into Cita values({0},{1},'{2}','{3}',{4})", cita.paciente.dnipaciente, cita.doctorasignado.nrocolegiatura, cita.fecha, cita.hora, cita.diagnostico.iddiagnostico);
            return Insertar(insert);
        }
        public string actualizarCita(eCita cita)
        {
            string update = string.Format("update Cita set dnipaciente={0},nrocolegiatura={1},fecha='{2}',hora='{3}',iddiagnostico={4} where idcita={5}", cita.paciente.dnipaciente, cita.doctorasignado.nrocolegiatura, cita.fecha, cita.hora, cita.diagnostico.iddiagnostico, cita.idcita);
            return Actualizar(update);
        }
        public string eliminarCita(int idcita)
        {
            string delete = string.Format("delete from Cita where idcita={0}", idcita);
            return Eliminar(delete);
        }
        public List<eCita> listarTodo()
        {
            try
            {
                SqlConnection conexion = db.ConectaBD();
                SqlCommand comando = new SqlCommand("select c.idcita, p.dnipaciente, p.nombre, p.apellido, d.nrocolegiatura, d.nombre, d.apellido, c.fecha, c.hora, di.iddiagnostico, di.nombre from Cita c, Paciente p, Doctor d, Diagnostico di where c.dnipaciente = p.dnipaciente and c.iddiagnostico = di.iddiagnostico and c.nrocolegiatura = d.nrocolegiatura", conexion);
                SqlDataReader reader = comando.ExecuteReader();
                List<eCita> lista = new List<eCita>();
                eCita cita = null;
                while (reader.Read())
                {
                    cita = new eCita();
                    cita.idcita = reader.GetInt32(0);
                    cita.paciente.dnipaciente = reader.GetInt32(1);
                    cita.paciente.nombre = reader.GetString(2);
                    cita.paciente.apellido = reader.GetString(3);
                    cita.doctorasignado.nrocolegiatura = reader.GetInt32(4);
                    cita.doctorasignado.nombre = reader.GetString(5);
                    cita.doctorasignado.apellido = reader.GetString(6);
                    cita.fecha = reader.GetDateTime(7);
                    cita.hora = reader.GetTimeSpan(8);
                    cita.diagnostico.iddiagnostico = reader.GetInt32(9);
                    cita.diagnostico.nombre = reader.GetString(10);
                    lista.Add(cita);
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
