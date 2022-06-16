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
        private nDiagnostico nDiagnostico = new nDiagnostico();
        int valorMasRepetido = -1;
        private nCita ncita = new nCita();
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
                foreach (eCita cita in ncita.ListarCita())
                {
                    if (cita.diagnostico.nombre == diagnos.nombre)
                    {
                        diagnos.CantidadRepeticion++;
                    }
                }

            }
            foreach (eDiagnostico diag in nDiagnostico.ListarTodo())
            {
                if (valorMasRepetido < diag.CantidadRepeticion)
                {
                    valorMasRepetido = diag.CantidadRepeticion;
                }
            }
            foreach (eDiagnostico diag in nDiagnostico.ListarTodo())
            {
                if (valorMasRepetido == diag.CantidadRepeticion)
                {
                    Nombres.Add(diag.nombre);

                }

            }
            Valores.Add(valorMasRepetido);
            chart1.Titles.Add("Diagnosticos más comunes");
            chart1.Series[0].Points.DataBindXY(Nombres, Valores);
        }

    }
}
