using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
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
    }
}
