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
    public partial class RQuejasContenido : Form
    {
        nDoctor negdoc;
        nQueja negqueja;
        public RQuejasContenido()
        {
            InitializeComponent();
            negdoc = new nDoctor();
            negqueja = new nQueja();
        }

        private void RQuejasContenido_Load(object sender, EventArgs e)
        {
            cbxDoctor.DataSource = negdoc.ListarDoctores();
        }

        private void cbxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            eDoctor doctor = (eDoctor)cbxDoctor.SelectedItem;
            lsQuejas.DataSource = negqueja.listarQuejas().FindAll(x => x.nrocolegiatura == doctor.nrocolegiatura);
        }
    }
}
