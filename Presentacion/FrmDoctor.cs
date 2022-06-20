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
        eDiagnostico diagnosticoseleccionado;
        int nrocol;
        public FrmDoctor(int nrocol)
        {
            InitializeComponent();
            citaseleccionado = null;
            diagnosticoseleccionado = null;
            datosCitas = new nCita();
            this.nrocol = nrocol;
        }

        void mostrarcita()
        {
            dataCita.DataSource =  datosCitas.ListarCita(); // solo del doctor 
        }
        void limpiar()
        {
            textBoxNombres.Clear();
            textBoxApellidos.Clear();
            textBoxDNI.Clear();
        }

        void cargarcombobox()
        {
            cbxTratamientos.DataSource = (new nTratamientoCancer()).ListarTratamientos();
            cbxDiagnos.DataSource = (new nDiagnostico()).ListarTodo();
        }
        private void FrmDoctor_Load(object sender, EventArgs e)
        {
            cargarcombobox();
            
            mostrarcita();
        }

        void desactivarPanel1()
        {
            if (citaseleccionado.diagnostico.nombre == "Cancer")
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
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Debes llenar todo los espacios");
            }
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
                    MessageBox.Show(datosCitas.ActualizarCita(citaseleccionado.idcita, citaseleccionado.paciente.dnipaciente, citaseleccionado.doctorasignado.nrocolegiatura, citaseleccionado.fecha, citaseleccionado.hora, diagnosticoseleccionado.iddiagnostico));
                    mostrarcita();
                    limpiar();
                }
            }
        }

        private void cbxDiagnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            diagnosticoseleccionado = (eDiagnostico)cbxDiagnos.SelectedItem;
        }

        private void dataCita_SelectionChanged(object sender, EventArgs e)
        {
            citaseleccionado = (eCita)dataCita.CurrentRow.DataBoundItem;
            if (citaseleccionado != null)
            {
                textBoxDNI.Text = citaseleccionado.paciente.dnipaciente.ToString();
                textBoxNombres.Text = citaseleccionado.paciente.nombre;
                textBoxApellidos.Text = citaseleccionado.paciente.apellido;
                cbxHora.Text = citaseleccionado.hora.Hours.ToString();
                cbxMinutos.Text = citaseleccionado.hora.Minutes.ToString();
                dtpFecha.Value = citaseleccionado.fecha;
            }
            desactivarPanel1();
        }
    }
}
