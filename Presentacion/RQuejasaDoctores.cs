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
        List<string> ListaNombresDoctores = new List<string>();
        List<string> CantidadQuejas = new List<string>();

        public RQuejasaDoctores()
        {
            InitializeComponent();
        }

        private void RQuejasaDoctores_Load(object sender, EventArgs e)
        {
            foreach (eDoctor doctor in negdoctor.ListarDoctores())
            {
                ListaNombresDoctores.Add(doctor.nombre);
                CantidadQuejas.Add(doctor.nroquejas.ToString());
            }
            chart1.Titles.Add("Numero de quejas de cada doctor");
            chart1.Series[0].Points.DataBindXY(ListaNombresDoctores, CantidadQuejas);
        }
    }
}
