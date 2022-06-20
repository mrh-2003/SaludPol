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
    public partial class RQuejasaDoctores : Form
    {
        nDoctor negdoctor = new nDoctor();
        nQueja negqueja = new nQueja();
        List<string> ListaNombresDoctores = new List<string>();
        List<int> CantidadQuejas = new List<int>();

        public RQuejasaDoctores()
        {
            InitializeComponent();
        }

        private void RQuejasaDoctores_Load(object sender, EventArgs e)
        {
            foreach (eDoctor doctor in negdoctor.ListarDoctores())
            {
                ListaNombresDoctores.Add(doctor.nombre);
                CantidadQuejas.Add(negqueja.listarQuejas().FindAll(x => x.nrocolegiatura == doctor.nrocolegiatura).Count);
            }
            chart1.Titles.Add("Numero de quejas de cada doctor");
            chart1.Series[0].Points.DataBindXY(ListaNombresDoctores, CantidadQuejas);
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            (new RQuejasContenido()).ShowDialog();
        }
    }
}
