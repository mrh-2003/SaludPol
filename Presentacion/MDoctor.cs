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
    public partial class MDoctor : Form
    {
        nDoctor negdoctor = new nDoctor();
        eDoctor doctorseleccionado = null;
        int nrocolegseleccionado;
        public MDoctor()
        {
            InitializeComponent();
            MostrarDoctores();
        }
        private void MostrarDoctores()
        {
            dataGridViewdoctor.DataSource = negdoctor.ListarDoctores();
        }
        private void LimpiarCajas()
        {
            textBoxapellido.Clear();
            textBoxcolegiatura.Clear();
            textBoxcontra.Clear();
            textBoxnombre.Clear();
            textBoxtelef.Clear();
            comboBoxespecialidad.SelectedIndex = -1;
        }
        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            if (textBoxapellido.Text != "" && textBoxcolegiatura.Text != "" && textBoxcontra.Text != "" && textBoxnombre.Text != "" && textBoxtelef.Text != "" && comboBoxespecialidad.SelectedIndex != -1)
            {
                switch (comboBoxespecialidad.SelectedIndex)
                {
                    case 0: negdoctor.InsertarDoctor(Convert.ToInt32(textBoxcolegiatura.Text), textBoxnombre.Text, textBoxapellido.Text, textBoxcontra.Text, Convert.ToInt32(textBoxtelef.Text), 1, 0); break;
                    case 1: negdoctor.InsertarDoctor(Convert.ToInt32(textBoxcolegiatura.Text), textBoxnombre.Text, textBoxapellido.Text, textBoxcontra.Text, Convert.ToInt32(textBoxtelef.Text), 2, 0); break;
                    case 2: negdoctor.InsertarDoctor(Convert.ToInt32(textBoxcolegiatura.Text), textBoxnombre.Text, textBoxapellido.Text, textBoxcontra.Text, Convert.ToInt32(textBoxtelef.Text), 3, 0); break;
                    default:
                        break;
                }
                MostrarDoctores();
                LimpiarCajas();
            }
            else
            {
                MessageBox.Show("Llene todos los campos con la información");
            }
        }

        private void dataGridViewdoctor_SelectionChanged(object sender, EventArgs e)
        {
            doctorseleccionado = (eDoctor)dataGridViewdoctor.CurrentRow.DataBoundItem;
            if (doctorseleccionado != null)
            {
                nrocolegseleccionado = doctorseleccionado.nrocolegiatura;
                textBoxapellido.Text = doctorseleccionado.apellido;
                textBoxcolegiatura.Text = doctorseleccionado.nrocolegiatura.ToString();
                textBoxcontra.Text = doctorseleccionado.contra;
                textBoxnombre.Text = doctorseleccionado.nombre;
                textBoxtelef.Text = doctorseleccionado.telefono.ToString();
                switch (doctorseleccionado.especialidad.idespecialidad)
                {
                    case 1: comboBoxespecialidad.Text = "Oncologia"; break;
                    case 2: comboBoxespecialidad.Text = "Traumatologia"; break;
                    case 3: comboBoxespecialidad.Text = "Pediatria"; break;
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)///-----------------------------
        {
            if (doctorseleccionado != null)
            {
                if (textBoxapellido.Text != "" && textBoxcolegiatura.Text != "" && textBoxcontra.Text != "" && textBoxnombre.Text != "" && textBoxtelef.Text != "" && comboBoxespecialidad.SelectedIndex != -1)
                {
                    switch (comboBoxespecialidad.SelectedIndex)
                    {
                        case 0: negdoctor.ActualizarDoctor(nrocolegseleccionado, textBoxnombre.Text, textBoxapellido.Text, textBoxcontra.Text, Convert.ToInt32(textBoxtelef.Text), 1, 0); break;
                        case 1: negdoctor.ActualizarDoctor(nrocolegseleccionado, textBoxnombre.Text, textBoxapellido.Text, textBoxcontra.Text, Convert.ToInt32(textBoxtelef.Text), 2, 0); break;
                        case 2: negdoctor.ActualizarDoctor(nrocolegseleccionado, textBoxnombre.Text, textBoxapellido.Text, textBoxcontra.Text, Convert.ToInt32(textBoxtelef.Text), 3, 0); break;
                        default:
                            break;
                    }
                    MostrarDoctores();
                    LimpiarCajas();
                }
                else
                {
                    MessageBox.Show("Llene todos los campos con la información");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un medico para modificar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (doctorseleccionado != null)
            {
                negdoctor.EliminarDoctor(nrocolegseleccionado);
                MostrarDoctores();
                LimpiarCajas();
            }
        }
    }
}
