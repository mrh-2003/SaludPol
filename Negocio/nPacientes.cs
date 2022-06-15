using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nPacientes
    {
        dPacientes datospacientes;
        public nPacientes()
        {
            datospacientes = new dPacientes();
        }
        public string InsertarPacientes (int dni, string nom, string apell, DateTime fechanac, int telef)
        {
            ePacientes template = new ePacientes()
            {
                dnipaciente = dni,
                nombre = nom,
                apellido = apell,
                fechadenacimiento = fechanac,
                telefono = telef,
            };
            return datospacientes.insertarPacientes(template);
        }
        public string ActualizarPacientes(int dni, string nom, string apell, DateTime fechanac, int telef)
        {
            ePacientes template = new ePacientes()
            {
                dnipaciente = dni,
                nombre = nom,
                apellido = apell,
                fechadenacimiento = fechanac,
                telefono = telef,
            };
            return datospacientes.actualizarPacientes(template);
        }
        public string EliminarPacientes(int dni)
        {
            return datospacientes.eliminarPacientes(dni);
        }
        public List <ePacientes> ListarPacientes()
        {
            return datospacientes.listarTodo();
        }
    }
}
