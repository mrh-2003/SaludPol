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
    public partial class RMedicosMasActivos : Form
    {
        List<eCita> ListaCitas;
        List<eDoctor> ListaDoctores;
        List<string> nombreDoctores;
        int[] frecuencias;
        
        public RMedicosMasActivos()
        {
            InitializeComponent();
            ListaCitas = (new nCita()).ListarCita();
            ListaDoctores = (new nDoctor()).ListarDoctores();
            frecuencias = new int[ListaDoctores.Count];
            nombreDoctores = new List<string>();
        }

        void ordenar()
        {
            int auxF;
            eDoctor auxD;
            for (int i = 0; i < frecuencias.Length - 1; i++)
                for (int j = i + 1; j < frecuencias.Length; j++)
                    if (frecuencias[i] > frecuencias[j])
                    {
                        auxF = frecuencias[i];
                        frecuencias[i] = frecuencias[j];
                        frecuencias[j] = auxF;
                        auxD = ListaDoctores[i];
                        ListaDoctores[i] = ListaDoctores[j];
                        ListaDoctores[j] = auxD;
                    }
        }

        private void RMedicosMasActivos_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < frecuencias.Length; i++)
                frecuencias[i] = 0;
            for (int i = 0; i < ListaDoctores.Count; i++)
                frecuencias[i] = ListaCitas.FindAll(value => value.doctorasignado.nrocolegiatura == ListaDoctores[i].nrocolegiatura).Count;
            ordenar();
            foreach (var item in ListaDoctores)
                nombreDoctores.Add(item.nombre);
            graficaMedicos.Series[0].Points.DataBindXY(nombreDoctores, frecuencias);
        }
    }
}
