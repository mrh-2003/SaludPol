using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;

namespace Negocio
{
    public class nDiagnostico
    {
        private dDiagnostico datosDiag;
        public nDiagnostico()
        {
            datosDiag = new dDiagnostico();
        }
        public string InsertarDiagnostico(string nombre)
        {
            eDiagnostico diagnostico = new eDiagnostico()
            {
                nombre = nombre
            };
            return datosDiag.insertarDiagnostico(diagnostico);
        }
        public string ActualizarDiagnostico(int iddiagnostico, string nombre)
        {
            eDiagnostico diagnostico = new eDiagnostico()
            {
                iddiagnostico = iddiagnostico,
                nombre = nombre
            };
            return datosDiag.actualizarDiagnostico(diagnostico);
        }
        public string EliminarDiagnostico(int iddiagnostico)
        {
            return datosDiag.eliminarDiagnostico(iddiagnostico);
        }
        public List<eDiagnostico> ListarTodo()
        {
            return datosDiag.listarTodo();
        }
    }
}
