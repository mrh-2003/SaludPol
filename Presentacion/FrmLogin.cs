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
    public partial class FrmLogin : Form
    {
        private nDoctor datosDoctor;
        private nPacientes datosPaciente;
        private nAdministrador datosAdministrador;

        private List<eDoctor> doctores;
        private List<eAdministrador> adminsitradores;
        private List<ePacientes> pacientes;
        public FrmLogin()
        {
            InitializeComponent();
            datosDoctor = new nDoctor();
            datosPaciente = new nPacientes();
            datosAdministrador = new nAdministrador();
            
            doctores = datosDoctor.ListarDoctores();
            adminsitradores = datosAdministrador.ListarAdministradores();
            pacientes = datosPaciente.ListarPacientes();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            cbxTipoUsuario.SelectedIndex = 0;
        }

        private void cbxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoUsuario.SelectedIndex == 0) {
                lbTipoUsuario.Text = "DNI : ";
                lbContra.Visible = txtContra.Visible = false;
            } else
            {
                lbContra.Visible = txtContra.Visible = true;
                if (cbxTipoUsuario.SelectedIndex == 1)
                    lbTipoUsuario.Text = "Colegiatura : ";
                else if (cbxTipoUsuario.SelectedIndex == 2)
                    lbTipoUsuario.Text = "Usuario : ";
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            switch (cbxTipoUsuario.Text)
            {
                case "Paciente":
                    if (pacientes.Exists(valor => valor.dnipaciente == Convert.ToInt32(txtUsuario.Text)))
                    {
                        (new FrmPacientes(Convert.ToInt32(txtUsuario.Text))).ShowDialog();
                    } else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                    break;
                case "Doctor": 
                    if (doctores.Exists(valor => valor.contra == txtContra.Text && valor.nrocolegiatura == Convert.ToInt32(txtUsuario.Text)))
                    {
                        (new FrmDoctor(Convert.ToInt32(txtUsuario.Text))).ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                    break;
                case "Administrador":
                    if (adminsitradores.Exists(valor => valor.contra == txtContra.Text && valor.usuario == txtUsuario.Text))
                    {
                        (new FrmAdministrador()).ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                    break;
            }
        }
    }
}
