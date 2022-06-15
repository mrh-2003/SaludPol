using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ePacientes
    {
        public int dnipaciente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fechadenacimiento { get; set; }
        public int telefono { get; set; }
        public override string ToString()
        {
            return nombre + " " + apellido;
        }
    }
}
