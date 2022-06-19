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
        private int dnipaciente;
        public FrmPacientes(int dniPaciente)
        {
            InitializeComponent();
            datoscita = new nCita();
            dnipaciente = dniPaciente;
        }
        void mostrarDatos()
        {
            dgvListarCitas.DataSource = datoscita.ListarCita().FindAll(x => x.paciente.dnipaciente == dnipaciente);
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
                MessageBox.Show(datoscita.InsertarCita(dnipaciente, Convert.ToInt32(cbxNCole.Text), dtpFecha.Value, (new TimeSpan(Convert.ToInt32(cbxHora.Text))), 0)); //El 0 significa que aun no hay diagnostico
                mostrarDatos();
                limpiar();
            }
            else
                MessageBox.Show("Debe completar todos los campos");
        }
    }
}
