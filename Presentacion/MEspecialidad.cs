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
    public partial class MEspecialidad : Form
    {
        eEspecialidad seleccionada;
        nEspecialidad nespecialidad;

        public MEspecialidad()
        {
            InitializeComponent();
            seleccionada = null;
            nespecialidad = new nEspecialidad();
        }

        public void CargarDatos()
        {
            dgvespecialidad.DataSource = nespecialidad.ListarEspecialidad();
        }

        private void LimpiarCajas()
        {
            txtid.Clear();
            txtnombre.Clear();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")
            {
                MessageBox.Show(nespecialidad.RegistrarEspecialidad(txtnombre.Text));
            }
            else
            {
                MessageBox.Show("Tienes que ingresar la especialidad");
            }
        }

        private void dgvespecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionada = (eEspecialidad)dgvespecialidad.CurrentRow.DataBoundItem;
            if (seleccionada != null)
            {
                txtid.Text = seleccionada.idespecialidad.ToString();
                txtnombre.Text = seleccionada.nombre;
            }
        }

        private void dgvespecialidad_SelectionChanged(object sender, EventArgs e)
        {
            seleccionada = (eEspecialidad)dgvespecialidad.CurrentRow.DataBoundItem;

            if (seleccionada != null)
            {
                txtid.Text = seleccionada.idespecialidad.ToString();
                txtnombre.Text = seleccionada.nombre;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (seleccionada != null)
            {
                if (txtid.Text != "" && txtnombre.Text != "")
                {
                    MessageBox.Show(nespecialidad.Modificar(seleccionada.idespecialidad, seleccionada.nombre));
                    CargarDatos();
                    LimpiarCajas();
                }

            }
            else
            {
                MessageBox.Show("Debes seleccionar ");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (seleccionada != null)
            {
                MessageBox.Show(nespecialidad.Eliminar(seleccionada.idespecialidad));
                CargarDatos();
                LimpiarCajas();
            }
            else
            {
                MessageBox.Show("Debes seleccionar ");
            }

        }


    }

}
