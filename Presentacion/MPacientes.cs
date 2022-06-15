using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
namespace Presentacion
{
    public partial class MPacientes : Form
    {
        nPacientes gp = new nPacientes();
        ePacientes pacienteseleccionado = null;
        int DNIpersona;

        public MPacientes()
        {
            InitializeComponent();
            mostrarpacientes();
        }
        private void mostrarpacientes()
        {
            dataPaciente.DataSource = gp.ListarPacientes();
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

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            int DNI;
            string nombre;
            string apellido;
            int telefono;
            DateTime d;
            List<ePacientes> lista = gp.ListarPacientes();
            DNI = Convert.ToInt32(textBoxDNI.Text);
            nombre = textBoxNombres.Text;
            apellido = textBoxApellidos.Text;
            telefono = Convert.ToInt32(textBoxTelefono.Text);
            d = Convert.ToDateTime(dateTimePickerFechaPac.Text); ////
            if (!lista.Exists(delegate (ePacientes value)
            {
                return value.dnipaciente == DNI;
            }))
            {
                MessageBox.Show(gp.InsertarPacientes(DNI, nombre, apellido, d, telefono));
                mostrarpacientes();
            }
            else
            {
                MessageBox.Show("Ya fue registrado");
            }
            //if (textBoxNombres.Text != ""&& textBoxDNI.Text != ""&& textBoxApellidos.Text !="" && textBoxTelefono.Text!="" && dateTimePickerFechaPac.Text!="")
            //{
            //    MessageBox.Show(gp.InsertarPacientes(Convert.ToInt32(textBoxDNI.Text), textBoxNombres.Text, textBoxApellidos.Text, Convert.ToDateTime(dateTimePickerFechaPac.Text), Convert.ToInt32(textBoxTelefono.Text)));
            mostrarpacientes();
            textBoxNombres.Clear();
            textBoxApellidos.Clear();
            textBoxTelefono.Clear();
            textBoxDNI.Clear();
            dateTimePickerFechaPac.Text = ""; //
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gp != null)
            {
                MessageBox.Show(gp.EliminarPacientes(pacienteseleccionado.dnipaciente));
            }
            else
                MessageBox.Show("Por favor debe seleccionar un pasajero de la lista");
            textBoxNombres.Focus();
        }

        private void dataPaciente_SelectionChanged(object sender, EventArgs e)
        {
            pacienteseleccionado = (ePacientes)dataPaciente.CurrentRow.DataBoundItem;
            if (pacienteseleccionado != null)
            {
                DNIpersona = pacienteseleccionado.dnipaciente;
                textBoxDNI.Text = DNIpersona.ToString();
                textBoxNombres.Text = pacienteseleccionado.nombre;
                textBoxApellidos.Text = pacienteseleccionado.apellido;
                textBoxTelefono.Text = pacienteseleccionado.telefono.ToString();
                dateTimePickerFechaPac.Text = pacienteseleccionado.fechadenacimiento.ToShortDateString(); ///

            }
        }
    }
}
