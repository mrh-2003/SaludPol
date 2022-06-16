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
    public partial class RAfluencia : Form
    {
        private List<eCita> citas;
        private List<int> frecuencias;
        private List<string> turnos;
        public RAfluencia()
        {
            InitializeComponent();
            citas = (new nCita()).ListarCita();
            frecuencias = new List<int>(3) { 0, 0, 0 };
            turnos = new List<string>(3) { "Mañana", "Tarde", "Noche" };
        }
        
        void contarAfluencia()
        {
            foreach (eCita cita in citas)
            {
                if(cita.fecha.Month == Convert.ToInt32(cbxMes.Text))
                    if (cita.hora < (new TimeSpan(12, 00, 00)))
                        frecuencias[0]++;
                    else if (cita.hora < (new TimeSpan(18, 00, 00)))
                        frecuencias[1]++;
                    else 
                        frecuencias[2]++;
            }
        }

        private void ReporteAfluencia_Load(object sender, EventArgs e)
        {
            
        }

        private void cbxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            contarAfluencia();
            chartAfluencia.Series[0].Points.DataBindXY(turnos, frecuencias);
            for (int i = 0; i < frecuencias.Count; i++)
                frecuencias[i] = 0;
        }
    }
}
