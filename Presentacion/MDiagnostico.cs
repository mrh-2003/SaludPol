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
    public partial class MDiagnostico : Form
    {
        eDiagnostico diagnosticoseleccionado = null;
        int iddiagnseleccionado;
        nDiagnostico negdiag = new nDiagnostico();
        public MDiagnostico()
        {
            InitializeComponent();
            MostrarDiagnosticos();
        }
        private void LimpiarCajas()
        {
            textBoxnombre.Clear();
        }
        private void MostrarDiagnosticos()
        {
            dataGridViewdiagn.DataSource = negdiag.ListarTodo();
        }
        private void MDiagnostico_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (textBoxnombre.Text != "")
            {
                negdiag.InsertarDiagnostico(textBoxnombre.Text);
                LimpiarCajas();
                MostrarDiagnosticos();
            }
            else
            {
                MessageBox.Show("Debe rellenar el campo con un nombre");
            }
        }

        private void dataGridViewdiagn_SelectionChanged(object sender, EventArgs e)
        {
            diagnosticoseleccionado = (eDiagnostico)dataGridViewdiagn.CurrentRow.DataBoundItem;
            if (diagnosticoseleccionado != null)
            {
                iddiagnseleccionado = diagnosticoseleccionado.iddiagnostico;
                textBoxnombre.Text = diagnosticoseleccionado.nombre;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (diagnosticoseleccionado != null)
            {
                negdiag.ActualizarDiagnostico(iddiagnseleccionado, textBoxnombre.Text);
                LimpiarCajas();
                MostrarDiagnosticos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un diagnostico para actualizar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (diagnosticoseleccionado != null)
            {
                negdiag.EliminarDiagnostico(iddiagnseleccionado);
                LimpiarCajas();
                MostrarDiagnosticos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un diagnostico para eliminar");
            }
        }
    }
}
