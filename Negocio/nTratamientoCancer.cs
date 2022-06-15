using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades; 

namespace Negocio
{
    public class nTratamientoCancer
    {
        dTratamientoCancer tratamietod; 
        public nTratamientoCancer()
        {
            tratamietod = new dTratamientoCancer();
        }
        public string InsertarTratamiento(int nropaccurados, string nombre)
        {
            eTratamientoCancer tratamiento = new eTratamientoCancer()
            {
                nropaccurados = nropaccurados,
                nombre = nombre
            };
            return tratamietod.insertarTratamiento(tratamiento); 
        }
        public string ActualizarTratamiento(int idtratamiento, int nropaccurados, string nombre)
        {
            eTratamientoCancer tratamiento = new eTratamientoCancer()
            {
                idtratamiento = idtratamiento,
                nropaccurados = nropaccurados,
                nombre = nombre
            };
            return tratamietod.actualizarTratamiento(tratamiento); 
        }
        public string EliminarTratamiento(int idtratamiento)
        {
            return tratamietod.eliminarTratamiento(idtratamiento); 
        }
        public List<eTratamientoCancer> ListarTratamientos()
        {
            return tratamietod.listarTodo(); 
        }
    }
}
