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
    public partial class RListaDoctoresxEspecialidad : Form
    {
        nDoctor negdoctor = new nDoctor();
        nEspecialidad negespecialidad = new nEspecialidad();
        List<eDoctor> ListaDoctoresxEspecialidad = new List<eDoctor>();
        public RListaDoctoresxEspecialidad()
        {
            InitializeComponent();
            foreach (eEspecialidad esp in negespecialidad.ListarEspecialidad())
            {
                comboBox1.Items.Add(esp);
            }
        }

        private void RListaDoctoresxEspecialidad_Load(object sender, EventArgs e)
        {
            foreach (eEspecialidad esp in negespecialidad.ListarEspecialidad())
            {
                comboBox1.Items.Add(esp);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                foreach (eDoctor doctor in negdoctor.ListarDoctores())
                {
                    if (doctor.especialidad.nombre == comboBox1.Text) ListaDoctoresxEspecialidad.Add(doctor);
                }
                dataGridViewlistar.DataSource = ListaDoctoresxEspecialidad;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una especialidad");
            }
        }
    }
}
