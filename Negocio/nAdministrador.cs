using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;
namespace Negocio
{
    public class nAdministrador
    {
        dAdministrador datosadmin;
        public nAdministrador()
        {
            datosadmin = new dAdministrador();
        }
        public string InsertarAdministrador(string user, string password, string name)
        {
            eAdministrador template = new eAdministrador()
            {
                nombre=name, usuario=user, contra=password
            };
            return datosadmin.InsertarDatosAdministrador(template);
        }
        public string ModificarAdministrador(string user, string password, string name)
        {
            eAdministrador template = new eAdministrador()
            {
                nombre = name,
                usuario = user,
                contra = password
            };
            return datosadmin.ModificarDatosAdministrador(template);
        }
        public string EliminarAdministrador(string name)
        {
            return datosadmin.EliminarAdministrador(name);
        }
        public List<eAdministrador> ListarAdministradores()
        {
            return datosadmin.ListarAdministrador();
        }
    }
}
