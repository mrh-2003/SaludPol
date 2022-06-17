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
        public FrmQuejaPaciente(int dni)
        {

            InitializeComponent();
            dnipacienteregistrado = dni;
        }
        nCita negcita = new nCita();
        nDoctor negdoctor = new nDoctor();
        nPacientes negpacientes = new nPacientes();
        nQueja negqueja = new nQueja();
        private void FrmQuejaPaciente_Load(object sender, EventArgs e)
        {
            foreach (eDoctor doctor in negdoctor.ListarDoctores())
            {
                comboBoxnombredoctores.Items.Add(doctor);
            }
            
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
                bool quejavalida = false;
                eDoctor itemdoctor = (eDoctor)comboBoxnombredoctores.SelectedItem;
                foreach (eCita cita in negcita.ListarCita())
                {
                    if (cita.paciente.dnipaciente == dnipacienteregistrado && itemdoctor.nrocolegiatura == cita.doctorasignado.nrocolegiatura) quejavalida = true;
                }
                if (quejavalida == true)
                {
                    negqueja.insertarQueja(itemdoctor.nrocolegiatura, textBoxquejaaingresar.Text);
                    Limpiar();
                    MessageBox.Show("Se registro exitosamente la queja al doctor " + itemdoctor.nombre + " " + itemdoctor.apellido);
                }
                if (quejavalida == false)
                {
                    Limpiar();
                    MessageBox.Show("El sistema indica que no ha tenido ninguna cita con el médico, la queja no se ingresará");
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos necesarios para ingresar la queja");
            }
        }
    }
}
