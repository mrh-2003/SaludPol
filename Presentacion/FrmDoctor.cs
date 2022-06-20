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
        eCita citaseleccionado;
        nCita datosCitas;
        int nrocol;
        public FrmDoctor(int nrocol)
        {
            InitializeComponent();
            citaseleccionado = null;
            datosCitas = new nCita();
            this.nrocol = nrocol;
        }

        void mostrarcita()
        {
            dataCita.DataSource =  datosCitas.ListarCita();
        }
        void limpiar()
        {
            textBoxNombres.Clear();
            textBoxApellidos.Clear();
            textBoxDNI.Clear();
        }

        void cargarTratamientos()
        {
            cbxTratamientos.DataSource = (new nTratamientoCancer()).ListarTratamientos();
        }
        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            cargarTratamientos();
            mostrarcita();
        }

        void desactivarPanel1()
        {
            if (datosCitas.ListarCita().Exists(cita => cita.paciente.dnipaciente == pacienteseleccionado.dnipaciente && cita.diagnostico.nombre == "Cancer"))
                pnlCancer.Enabled = true;
            else
                pnlCancer.Enabled = false;
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

        private void dataPaciente_SelectionChanged(object sender, EventArgs e)
        {
            citaseleccionado = (eCita)dataCita.CurrentRow.DataBoundItem;
            if (citaseleccionado != null)
            {
                textBoxDNI.Text = citaseleccionado.paciente.dnipaciente.ToString();
                textBoxNombres.Text = citaseleccionado.paciente.nombre;
                textBoxApellidos.Text = citaseleccionado.paciente.apellido;
            }
            desactivarPanel1();
        }

        private void btnDiag_Click(object sender, EventArgs e)
        {
            (new MDiagnostico()).ShowDialog();
        }

        private void btnRegistrarDiag_Click(object sender, EventArgs e)
        {
            if (citaseleccionado != null)
            {
                if (cbxDiagnos.SelectedIndex != - 1)
                {
                    MessageBox.Show(datosCitas.ActualizarCita());
                    mostrarcita();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (citaseleccionado != null)
            {
                if (textBoxNombres.Text != "" && textBoxDNI.Text != "" && textBoxApellidos.Text != "" )
                {
                    MessageBox.Show(gp.ActualizarPacientes(citaseleccionado.dnipaciente, textBoxNombres.Text, textBoxApellidos.Text, citaseleccionado.fechadenacimiento, Convert.ToInt32(textBoxTelefono.Text)));
                    mostrarcita();
                }
            }
        }        
    }
}
