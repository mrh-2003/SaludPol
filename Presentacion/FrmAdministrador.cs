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
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDoctor frm = new MDoctor();
            frm.ShowDialog();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MCita frmci = new MCita();
            frmci.ShowDialog();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MPacientes frmpaci = new MPacientes();
            frmpaci.ShowDialog();
        }

        private void quejasPorCadaMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RQuejasaDoctores frmque = new RQuejasaDoctores();
            frmque.ShowDialog();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MEspecialidad frmespec = new MEspecialidad();
            frmespec.ShowDialog();
        }

        private void afluenciaDePacientesPorPeríodoDeTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAfluencia frmafl = new RAfluencia();
            frmafl.ShowDialog();
        }

        private void médicosConMayorCantidadDeCitasAtendidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RMedicosMasActivos frm = new RMedicosMasActivos();
            frm.ShowDialog();
        }

        private void doctoresPorCadaEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RListaDoctoresxEspecialidad frmespxcada = new RListaDoctoresxEspecialidad();
            frmespxcada.ShowDialog();
        }

        private void diagnósticosMásComunesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RDiagnosticosMasComunes rdiag = new RDiagnosticosMasComunes();
            rdiag.ShowDialog();
        }

        private void eficaciaDeTratamientosEnPacientesConCáncerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTratamientos retra = new RTratamientos();
            retra.ShowDialog();
        }
    }
}
