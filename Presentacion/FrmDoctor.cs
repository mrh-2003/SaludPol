using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class FrmDoctor : Form
    {
        ePacientes pacienteseleccionado;
        nPacientes gp;
        nCita datosCitas;
        int nrocol;
        public FrmDoctor(int nrocol)
        {
            InitializeComponent();
            pacienteseleccionado = null;
            gp = new nPacientes();
            datosCitas = new nCita();
            this.nrocol = nrocol;
        }

        void mostrarpacientes()
        {
            dataPaciente.DataSource =  gp.ListarPacientes();
        }
        void limpiar()
        {
            textBoxNombres.Clear();
            textBoxApellidos.Clear();
            textBoxTelefono.Clear();
            textBoxDNI.Clear();
            dateTimePickerFechaPac.Text = ""; 
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (pacienteseleccionado != null)
            {
                if (textBoxNombres.Text != "" && textBoxDNI.Text != "" && textBoxApellidos.Text != "" && textBoxTelefono.Text != "" && dateTimePickerFechaPac.Text != "")
                {
                    MessageBox.Show(gp.ActualizarPacientes(pacienteseleccionado.dnipaciente, textBoxNombres.Text, textBoxApellidos.Text, pacienteseleccionado.fechadenacimiento, Convert.ToInt32(textBoxTelefono.Text)));
                    mostrarpacientes();
                }
            }
        }
        private void btnDiag_Click(object sender, EventArgs e)
        {
            (new MDiagnostico()).ShowDialog();
        }


        private void dataPaciente_SelectionChanged(object sender, EventArgs e)
        {
            pacienteseleccionado = (ePacientes)dataPaciente.CurrentRow.DataBoundItem;
            if (pacienteseleccionado != null)
            {
                textBoxDNI.Text = pacienteseleccionado.dnipaciente.ToString();
                textBoxNombres.Text = pacienteseleccionado.nombre;
                textBoxApellidos.Text = pacienteseleccionado.apellido;
                textBoxTelefono.Text = pacienteseleccionado.telefono.ToString();
                dateTimePickerFechaPac.Text = pacienteseleccionado.fechadenacimiento.ToShortDateString();
            }
            desactivarPanel1();
        }
        void cargarTratamientos()
        {
            cbxTratamientos.DataSource = (new nTratamientoCancer()).ListarTratamientos();
        }
        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            cargarTratamientos();
            mostrarpacientes();
        }

        void desactivarPanel1()
        {
            if (datosCitas.ListarCita().Exists(cita => cita.paciente.dnipaciente == pacienteseleccionado.dnipaciente && cita.diagnostico.nombre == "Cancer"))
                splitContainer1.Panel1.Enabled = true;
            else
                splitContainer1.Panel1.Enabled = false;
        }

        void limpiarTratamientos()
        {
            cbxPacienteCurado.SelectedIndex = -1;
            cbxTratamientos.SelectedIndex = -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            eTratamientoCancer tratamiento = cbxTratamientos.SelectedItem as eTratamientoCancer;
            if (cbxPacienteCurado.SelectedIndex != -1 && cbxTratamientos.SelectedIndex != -1)
            {
                if (cbxPacienteCurado.Text == "Si")
                {
                    (new nTratamientoCancer()).ActualizarTratamiento(tratamiento.idtratamiento, (new nTratamientoCancer()).ListarTratamientos().Find(trat => trat.idtratamiento == tratamiento.idtratamiento).nropaccurados + 1, cbxTratamientos.Text);
                    limpiarTratamientos();
                }
            }
            else
            {
                MessageBox.Show("Debes llenar todo los espacios");
            }
        }
    }
}
