using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eDoctor
    {
        public int nrocolegiatura { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string contra { get; set; }
        public int telefono { get; set; }
        public eEspecialidad especialidad { get; set; }
        public eDoctor()
        {
            especialidad = new eEspecialidad();
        }
        public override string ToString()
        {
            return nombre + " " + apellido;
        }
    }
}
