using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Datos;

namespace Negocio
{
    public class nQueja
    {
        public string insertarQueja(int nroCol, string contenido)
        {
            eQueja queja = new eQueja() { nrocolegiatura = nroCol, contenido = contenido };
            return (new dQuejas()).insertarQueja(queja);
        }
        public List<eQueja> listarQuejas()
        {
            return (new dQuejas()).listarQuejas();
        }
    }
}
