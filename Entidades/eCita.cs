using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eCita
    {
        public int idcita { get; set; }
        public ePacientes paciente { get; set; }
        public eDoctor doctorasignado { get; set; }
        public DateTime fecha { get; set; }
        public TimeSpan hora { get; set; }
        public eDiagnostico diagnostico { get; set; }
        public eCita()
        {
            paciente = new ePacientes();
            doctorasignado = new eDoctor();
            diagnostico = new eDiagnostico();
        }
        public override string ToString()
        {
            return idcita.ToString();
        }

    }
}
