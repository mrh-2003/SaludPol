using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;
namespace Negocio
{
    public class nCita
    {
        dCita datosCita;
        public nCita()
        {
            datosCita = new dCita();
        }
        public string InsertarCita(int dni, int nrocoleg, DateTime fech, TimeSpan hor, int iddiag)
        {
            ePacientes temppaciente = new ePacientes()
            {
                dnipaciente = dni
            };
            eDoctor tempdoctor = new eDoctor()
            {
                nrocolegiatura = nrocoleg
            };
            eDiagnostico tempdiag = new eDiagnostico()
            {
                iddiagnostico = iddiag
            };
            eCita cita = new eCita()
            {
                doctorasignado = tempdoctor,
                paciente = temppaciente,
                fecha = fech,
                hora = hor,
                diagnostico = tempdiag
                
            };
            return datosCita.insertarCita(cita);
        }
        public string ActualizarCita(int idc, int dni, int nrocoleg, DateTime fech, TimeSpan hor, int iddiag)
        {
            ePacientes temppaciente = new ePacientes()
            {
                dnipaciente = dni
            };
            eDoctor tempdoctor = new eDoctor()
            {
                nrocolegiatura = nrocoleg
            };
            eDiagnostico tempdiag = new eDiagnostico()
            {
                iddiagnostico = iddiag
            };
            eCita cita = new eCita()
            {
                idcita = idc,
                paciente=temppaciente,
                doctorasignado=tempdoctor,
                fecha = fech,
                hora = hor,
                diagnostico = tempdiag
            };
            return datosCita.actualizarCita(cita);
        }
        public string EliminarCita(int idc)
        {
            return datosCita.eliminarCita(idc);
        }
        public List<eCita> ListarCita()
        {
            return datosCita.listarTodo();
        }
    }
}
