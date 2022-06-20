using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;
namespace Negocio
{
    public class nDoctor
    {
        dDoctor datosdoctor;
        public nDoctor()
        {
            datosdoctor = new dDoctor();
        }
        public string InsertarDoctor(int nrocoleg,string name, string lastname, string password, int telef, int idespecial)
        {
            eEspecialidad especialidad = new eEspecialidad()
            {
                idespecialidad = idespecial
            };
            eDoctor template = new eDoctor()
            {
                nrocolegiatura = nrocoleg,
                nombre = name,
                apellido=lastname,
                contra=password,
                telefono=telef,
                especialidad=especialidad
            };
            return datosdoctor.insertarDoctor(template);
        }
        public string ActualizarDoctor(int nrocoleg, string name, string lastname, string password, int telef, int idespecial)
        {
            eEspecialidad especialidad = new eEspecialidad()
            {
                idespecialidad = idespecial
            };
            eDoctor template = new eDoctor()
            {
                nrocolegiatura = nrocoleg,
                nombre = name,
                apellido = lastname,
                contra = password,
                telefono = telef,
                especialidad = especialidad
            };
            return datosdoctor.actualizarDoctor(template);
        }
        public string EliminarDoctor(int nrocoleg)
        {
            return datosdoctor.eliminarDoctor(nrocoleg);
        }
        public List<eDoctor> ListarDoctores()
        {
            return datosdoctor.listarTodo();
        }
    }
}
