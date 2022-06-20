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
    public partial class RDiagnosticosMasComunes : Form
    {
        private nCita ncita = new nCita();
        private nDiagnostico nDiagnostico = new nDiagnostico();
        List<string> Nombres = new List<string>();
        List<int> Valores = new List<int>();

        public RDiagnosticosMasComunes()
        {
            InitializeComponent();
        }

        private void FrmDiagnosticosMasComunes_Load(object sender, EventArgs e)
        {
            foreach (eDiagnostico diagnos in nDiagnostico.ListarTodo())
            {
                diagnos.CantidadRepeticion = ncita.ListarCita().FindAll(x => x.diagnostico.iddiagnostico == diagnos.iddiagnostico).Count;
                if (diagnos.CantidadRepeticion > 0)
                {
                    Nombres.Add(diagnos.nombre);
                    Valores.Add(diagnos.CantidadRepeticion);
                }
            }
            chart1.Titles.Add("Diagnosticos más comunes");
            chart1.Series[0].Points.DataBindXY(Nombres, Valores);
        }

    }
}
