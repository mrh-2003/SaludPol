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
    public partial class FrmPacientes : Form
    {
        nCita datoscita;
        nDoctor datosDoctor;
        bool seCargo;
        private int dnipaciente;
        public FrmPacientes(int dniPaciente)
        {
            InitializeComponent();
            datoscita = new nCita();
            datosDoctor = new nDoctor();
            dnipaciente = dniPaciente;
            seCargo = false;
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd - MMMM - yyyy";
        }
        void mostrarDatos()
        {
            dgvListarCitas.DataSource = datoscita.ListarCita().FindAll(x => x.paciente.dnipaciente == dnipaciente);
        }

        void cargarComboBox()
        {
            cbxDoctor.DisplayMember = "nombre";
            cbxDoctor.DataSource = datosDoctor.ListarDoctores();
            cbxNCole.DisplayMember = "nrocolegiatura";
            cbxNCole.DataSource = datosDoctor.ListarDoctores();
            seCargo = true;
        }

        public void limpiar()
        {
            txtIDcita.Clear();
            cbxHora.SelectedIndex = -1;
            cbxMinutos.SelectedIndex = -1;
            cbxDoctor.SelectedIndex = -1;
            cbxNCole.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbxNCole.SelectedIndex != -1 && cbxMinutos.SelectedIndex != -1 && cbxHora.SelectedIndex != -1)
            {
                if ((new nCita()).ListarCita().Exists(x => x.doctorasignado.nrocolegiatura == Convert.ToInt32(cbxNCole.Text) && x.fecha.Date == dtpFecha.Value.Date && x.hora == (new TimeSpan(Convert.ToInt32(cbxHora.Text), Convert.ToInt32(cbxMinutos.Text), 0))))
                {
                    MessageBox.Show("Este horario ya fue tomado");
                }
                else
                {
                    MessageBox.Show(datoscita.InsertarCita(dnipaciente, Convert.ToInt32(cbxNCole.Text), dtpFecha.Value, (new TimeSpan(Convert.ToInt32(cbxHora.Text), Convert.ToInt32(cbxMinutos.Text), 0)), 0)); //El 0 significa que aun no hay diagnostico
                    mostrarDatos();
                    limpiar();
                }
            }
            else
                MessageBox.Show("Debe completar todos los campos");
        }

        private void btnQueja_Click(object sender, EventArgs e)
        {
            (new FrmQuejaPaciente(dnipaciente)).ShowDialog();
        }

        private void cbxNCole_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDoctor.SelectedIndex = cbxNCole.SelectedIndex;
        }

        private void cbxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(seCargo)
                cbxNCole.SelectedIndex = cbxDoctor.SelectedIndex;
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            mostrarDatos();
            cargarComboBox();
            limpiar();
        }
    }
}
