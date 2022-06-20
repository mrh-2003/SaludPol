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
    public partial class FrmQuejaPaciente : Form
    {
        int dnipacienteregistrado;
        List<eDoctor> listaDoctor = new List<eDoctor>();
        public FrmQuejaPaciente(int dni)
        {

            InitializeComponent();
            dnipacienteregistrado = dni;
        }
        nCita negcita = new nCita();
        nQueja negqueja = new nQueja();
        private void FrmQuejaPaciente_Load(object sender, EventArgs e)
        {
            foreach (eCita cita in negcita.ListarCita().FindAll(x => x.paciente.dnipaciente == dnipacienteregistrado))
            {
                listaDoctor.Add(cita.doctorasignado);
            }
            comboBoxnombredoctores.DataSource = listaDoctor;
        }
        private void Limpiar()
        {
            textBoxquejaaingresar.Clear();
            comboBoxnombredoctores.SelectedIndex = -1;
        }
        private void buttonqueja_Click(object sender, EventArgs e)
        {
            if (comboBoxnombredoctores.SelectedIndex != -1 && textBoxquejaaingresar.Text != "")
            {
                eDoctor itemdoctor = (eDoctor)comboBoxnombredoctores.SelectedItem;
                negqueja.insertarQueja(itemdoctor.nrocolegiatura, textBoxquejaaingresar.Text);
                Limpiar();
                MessageBox.Show("Se registro exitosamente la queja al doctor " + itemdoctor.nombre + " " + itemdoctor.apellido);
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos necesarios para ingresar la queja");
            }
        }
    }
}
