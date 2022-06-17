using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eQueja
    {

        public int idquejas { get; set; }
        public int nrocolegiatura { get; set; }
        public string contenido { get; set; }
        public override string ToString()
        {
            return contenido;
        }
    }
}
