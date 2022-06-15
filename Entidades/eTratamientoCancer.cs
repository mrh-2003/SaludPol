using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eTratamientoCancer
    {
        //tratamientos experimentales
        public int idtratamiento { get; set; }
        //public int dnipaciente { get; set; }
        //public int nrocolegiatura { get; set; } 
        //public DateTime fecha { get; set; }
        //public TimeSpan hora { get; set; } // ta por verse
        //public string estado { get; set; } // se curo -- no se curo -- esto seriviria para contar cnatidades
        public int nropaccurados { get; set; }
        public string nombre { get; set; }
        public override string ToString()
        {
            return nombre;
        }
    }
}
