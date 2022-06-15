using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
    public class nEspecialidad
    {
        dEspecialidad especialidatos;

        public nEspecialidad()
        {
           especialidatos = new dEspecialidad();
        }
        public string RegistrarEspecialidad(string nombrespecialidad)
        {
            eEspecialidad especialidad = new eEspecialidad()
            {
                nombre = nombrespecialidad
            };
            return especialidatos.insertEspecialidad(especialidad);
        }
     public string Modificar(int idespe, string nombrespecialidad)
        {
            eEspecialidad especialidad = new eEspecialidad()
            {
                nombre = nombrespecialidad,
                idespecialidad = idespe
            };
            return especialidatos.actualizarEspecialidad(especialidad);
        }
        public string Eliminar(int id)
        {
            return especialidatos.eliminarEspecialidad(id);
        }
        public List<eEspecialidad> ListarEspecialidad()
        {
            return especialidatos.listarTodo();
        }
    }
}
