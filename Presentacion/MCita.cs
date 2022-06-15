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
    public partial class MCita : Form
    {
        private eCita citaSeleccionada;
        private nCita ncita;

        private nDoctor ndoctor;
        private nDiagnostico ndiagnostico;
        private nPacientes npacientes;

        private bool actualizar = false;
        public MCita()
        {
            InitializeComponent();
            ncita = new nCita();

            ndoctor = new nDoctor();
            ndiagnostico = new nDiagnostico();
            npacientes = new nPacientes();

            citaSeleccionada = null;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd - MMMM - yyyy";
        }

        private void MCita_Load(object sender, EventArgs e)
        {
            mostrarDatos();
            llenarComboBox();
            limpiar();
        }
        public void llenarComboBox()
        {
            cbxDoctor.DataSource = ndoctor.ListarDoctores();
            cbxPaci.DataSource = npacientes.ListarPacientes();
            cbxDiagnos.DataSource = ndiagnostico.ListarTodo();
            cbxDNIPac.DisplayMember = "dnipaciente";
            cbxDNIPac.DataSource = npacientes.ListarPacientes();
            cbxNCole.DisplayMember = "nrocolegiatura";
            cbxNCole.DataSource = ndoctor.ListarDoctores();
            cbxIDdiag.DisplayMember = "iddiagnostico";
            cbxIDdiag.DataSource = ndiagnostico.ListarTodo();
            actualizar = true;
        }
        public void mostrarDatos()
        {
            dgvListarCitas.DataSource = ncita.ListarCita();
            dgvListarCitas.ClearSelection();
        }
        public void limpiar()
        {
            txtIDcita.Clear();
            cbxHora.SelectedIndex = -1;
            cbxMinutos.SelectedIndex = -1;
            cbxDiagnos.SelectedIndex = -1;
            cbxDNIPac.SelectedIndex = -1;
            cbxDoctor.SelectedIndex = -1;
            cbxIDdiag.SelectedIndex = -1;
            cbxNCole.SelectedIndex = -1;
            cbxPaci.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }
        private void dgvListarCitas_SelectionChanged(object sender, EventArgs e)
        {
            citaSeleccionada = (eCita)dgvListarCitas.CurrentRow.DataBoundItem;
            if (citaSeleccionada != null)
                llenarDatos();
        }
        public void llenarDatos()
        {
            cbxDNIPac.Text = citaSeleccionada.paciente.dnipaciente.ToString();
            cbxNCole.Text = citaSeleccionada.doctorasignado.nrocolegiatura.ToString();
            cbxIDdiag.Text = citaSeleccionada.diagnostico.iddiagnostico.ToString();
            cbxPaci.Text = citaSeleccionada.paciente.ToString();
            cbxDoctor.Text = citaSeleccionada.doctorasignado.ToString();
            cbxDiagnos.Text = citaSeleccionada.diagnostico.nombre.ToString();
            txtIDcita.Text = citaSeleccionada.idcita.ToString();
            cbxHora.Text = citaSeleccionada.hora.Hours.ToString();
            cbxMinutos.Text = citaSeleccionada.hora.Minutes.ToString();
            dtpFecha.Value = citaSeleccionada.fecha;
        }
        //public void llenarParaIngresar()
        //{
        //    citaSeleccionada.paciente.dnipaciente = Convert.ToInt32(cbxDNIPac.Text);
        //    citaSeleccionada.doctorasignado.nrocolegiatura =  Convert.ToInt32(cbxNCole.Text ) ;
        //    citaSeleccionada.diagnostico.iddiagnostico = Convert.ToInt32(cbxIDdiag.Text) ;
        //    citaSeleccionada.paciente.nombre =  cbxPaci.Text   ;
        //    citaSeleccionada.doctorasignado.nombre = cbxDoctor.Text ;
        //    citaSeleccionada.diagnostico.nombre = cbxDiagnos.Text;
        //    citaSeleccionada.idcita = Convert.ToInt32(txtIDcita.Text );
        //    citaSeleccionada.hora = new TimeSpan(Convert.ToInt32(cbxHora.Text), Convert.ToInt32(cbxMinutos.Text), 0);
        //    citaSeleccionada.fecha = dtpFecha.Value;
        //}

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbxIDdiag.SelectedIndex != -1 && cbxDNIPac.SelectedIndex != -1 && cbxNCole.SelectedIndex != -1 && cbxMinutos.SelectedIndex != -1 && cbxHora.SelectedIndex != -1)
            {
                MessageBox.Show(ncita.InsertarCita(Convert.ToInt32(cbxDNIPac.Text), Convert.ToInt32(cbxNCole.Text), dtpFecha.Value, (new TimeSpan(Convert.ToInt32(cbxHora.Text), Convert.ToInt32(cbxMinutos.Text), 0)), Convert.ToInt32(cbxIDdiag.Text)));
                mostrarDatos();
                limpiar();
            }
            else
                MessageBox.Show("Debe completar todos los campos");
        }
         private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtIDcita.Text != "")
            {
                if (MessageBox.Show("Confirmar eliminacion", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show(ncita.EliminarCita(Convert.ToInt32(txtIDcita.Text)));
                    mostrarDatos();
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cita");
            }  
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtIDcita.Text != "")
            {
                if (MessageBox.Show("Confirmar actualizacion", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show(ncita.ActualizarCita(Convert.ToInt32(txtIDcita.Text), Convert.ToInt32(cbxDNIPac.Text), Convert.ToInt32(cbxNCole.Text), dtpFecha.Value, (new TimeSpan(Convert.ToInt32(cbxHora.Text), Convert.ToInt32(cbxMinutos.Text), 0)), Convert.ToInt32(cbxIDdiag.Text)));
                    mostrarDatos();
                    limpiar();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cita");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void cbxDNIPac_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPaci.SelectedIndex = cbxDNIPac.SelectedIndex;
        }
        private void cbxPaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(actualizar)
                cbxDNIPac.SelectedIndex = cbxPaci.SelectedIndex;
        }

        private void cbxNCole_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDoctor.SelectedIndex = cbxNCole.SelectedIndex;
        }

        private void cbxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (actualizar)
                cbxNCole.SelectedIndex = cbxDoctor.SelectedIndex;
        }

        private void cbxIDdiag_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDiagnos.SelectedIndex = cbxIDdiag.SelectedIndex;
        }

        private void cbxDiagnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(actualizar)
                cbxIDdiag.SelectedIndex = cbxDiagnos.SelectedIndex;
        }
    }
}
