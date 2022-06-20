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
    public partial class RTratamientos : Form
    {
        private nTratamientoCancer nTratamiento = new nTratamientoCancer();
        List<string> nombreTrata = new List<string>();
        List<int> numeropacientes = new List<int>();
        public RTratamientos()
        {

            InitializeComponent();

        }

        private void FrmReporteTratamientos_Load(object sender, EventArgs e)
        {
            foreach (eTratamientoCancer tratamiento in nTratamiento.ListarTratamientos())
            {
                if (tratamiento.nropaccurados > 0)
                {
                    nombreTrata.Add(tratamiento.nombre);
                    numeropacientes.Add(tratamiento.nropaccurados);
                }
            }

            chartTratamientos.Titles.Add("Eficacia de los tratamientos");
            chartTratamientos.Series[0].Points.DataBindXY(nombreTrata, numeropacientes);
        }
    }
}
