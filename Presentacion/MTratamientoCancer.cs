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
    public partial class MTratamientoCancer : Form
    {
        private eTratamientoCancer etratamientoSeleccionado = null;
        private nTratamientoCancer nTratamiento = new nTratamientoCancer();
        int id;
        public MTratamientoCancer()
        {
            InitializeComponent();
            mostrarDatosTratamiento();
        }
        public void mostrarDatosTratamiento()
        {
            dataGridViewTratamientos.DataSource = nTratamiento.ListarTratamientos();
            dataGridViewTratamientos.ClearSelection();
        }
        public void Limpiar()
        {
            textBoxNombreT.Clear();
            textBoxPacientesCurados.Clear();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxNombreT.Text != "" && textBoxPacientesCurados.Text != "")
            {
                MessageBox.Show(nTratamiento.InsertarTratamiento(Convert.ToInt32(textBoxPacientesCurados.Text), textBoxNombreT.Text));
                Limpiar();
                mostrarDatosTratamiento();
            }
            else { MessageBox.Show("Debe rellenar todos los campos"); }

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (etratamientoSeleccionado != null)
            {

                if (textBoxNombreT.Text != "" && textBoxPacientesCurados.Text != "")
                {

                    MessageBox.Show(nTratamiento.ActualizarTratamiento(id, Convert.ToInt32(textBoxPacientesCurados.Text), textBoxNombreT.Text));
                    Limpiar();
                    mostrarDatosTratamiento();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar");
            }

        }

        private void dataGridViewTratamientos_SelectionChanged(object sender, EventArgs e)
        {
            etratamientoSeleccionado = (eTratamientoCancer)dataGridViewTratamientos.CurrentRow.DataBoundItem;
            if (etratamientoSeleccionado != null)
            {
                id = etratamientoSeleccionado.idtratamiento;
                textBoxNombreT.Text = etratamientoSeleccionado.nombre;
                textBoxPacientesCurados.Text = etratamientoSeleccionado.nropaccurados.ToString();
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (etratamientoSeleccionado != null)
            {

                MessageBox.Show(nTratamiento.EliminarTratamiento(id));
                Limpiar();
                mostrarDatosTratamiento();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar");
            }
        }
    }
}
