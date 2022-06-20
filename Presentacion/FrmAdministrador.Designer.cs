namespace Presentacion
{
    partial class FrmAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quejasPorCadaMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afluenciaDePacientesPorPeríodoDeTiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosConMayorCantidadDeCitasAtendidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctoresPorCadaEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnósticosMásComunesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eficaciaDeTratamientosEnPacientesConCáncerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicosToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.especialidadToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.medicosToolStripMenuItem.Text = "Medicos";
            this.medicosToolStripMenuItem.Click += new System.EventHandler(this.medicosToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.citasToolStripMenuItem.Text = "Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            this.especialidadToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.especialidadToolStripMenuItem.Text = "Especialidad";
            this.especialidadToolStripMenuItem.Click += new System.EventHandler(this.especialidadToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quejasPorCadaMédicoToolStripMenuItem,
            this.afluenciaDePacientesPorPeríodoDeTiempoToolStripMenuItem,
            this.médicosConMayorCantidadDeCitasAtendidasToolStripMenuItem,
            this.doctoresPorCadaEspecialidadToolStripMenuItem,
            this.diagnósticosMásComunesToolStripMenuItem,
            this.eficaciaDeTratamientosEnPacientesConCáncerToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // quejasPorCadaMédicoToolStripMenuItem
            // 
            this.quejasPorCadaMédicoToolStripMenuItem.Name = "quejasPorCadaMédicoToolStripMenuItem";
            this.quejasPorCadaMédicoToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.quejasPorCadaMédicoToolStripMenuItem.Text = "Quejas por cada médico";
            this.quejasPorCadaMédicoToolStripMenuItem.Click += new System.EventHandler(this.quejasPorCadaMédicoToolStripMenuItem_Click);
            // 
            // afluenciaDePacientesPorPeríodoDeTiempoToolStripMenuItem
            // 
            this.afluenciaDePacientesPorPeríodoDeTiempoToolStripMenuItem.Name = "afluenciaDePacientesPorPeríodoDeTiempoToolStripMenuItem";
            this.afluenciaDePacientesPorPeríodoDeTiempoToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.afluenciaDePacientesPorPeríodoDeTiempoToolStripMenuItem.Text = "Afluencia de pacientes por período de tiempo";
            this.afluenciaDePacientesPorPeríodoDeTiempoToolStripMenuItem.Click += new System.EventHandler(this.afluenciaDePacientesPorPeríodoDeTiempoToolStripMenuItem_Click);
            // 
            // médicosConMayorCantidadDeCitasAtendidasToolStripMenuItem
            // 
            this.médicosConMayorCantidadDeCitasAtendidasToolStripMenuItem.Name = "médicosConMayorCantidadDeCitasAtendidasToolStripMenuItem";
            this.médicosConMayorCantidadDeCitasAtendidasToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.médicosConMayorCantidadDeCitasAtendidasToolStripMenuItem.Text = "Médicos con mayor cantidad de citas atendidas";
            this.médicosConMayorCantidadDeCitasAtendidasToolStripMenuItem.Click += new System.EventHandler(this.médicosConMayorCantidadDeCitasAtendidasToolStripMenuItem_Click);
            // 
            // doctoresPorCadaEspecialidadToolStripMenuItem
            // 
            this.doctoresPorCadaEspecialidadToolStripMenuItem.Name = "doctoresPorCadaEspecialidadToolStripMenuItem";
            this.doctoresPorCadaEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.doctoresPorCadaEspecialidadToolStripMenuItem.Text = "Doctores por cada especialidad";
            this.doctoresPorCadaEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.doctoresPorCadaEspecialidadToolStripMenuItem_Click);
            // 
            // diagnósticosMásComunesToolStripMenuItem
            // 
            this.diagnósticosMásComunesToolStripMenuItem.Name = "diagnósticosMásComunesToolStripMenuItem";
            this.diagnósticosMásComunesToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.diagnósticosMásComunesToolStripMenuItem.Text = "Diagnósticos más comunes";
            this.diagnósticosMásComunesToolStripMenuItem.Click += new System.EventHandler(this.diagnósticosMásComunesToolStripMenuItem_Click);
            // 
            // eficaciaDeTratamientosEnPacientesConCáncerToolStripMenuItem
            // 
            this.eficaciaDeTratamientosEnPacientesConCáncerToolStripMenuItem.Name = "eficaciaDeTratamientosEnPacientesConCáncerToolStripMenuItem";
            this.eficaciaDeTratamientosEnPacientesConCáncerToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.eficaciaDeTratamientosEnPacientesConCáncerToolStripMenuItem.Text = "Eficacia de tratamientos en pacientes con cáncer";
            this.eficaciaDeTratamientosEnPacientesConCáncerToolStripMenuItem.Click += new System.EventHandler(this.eficaciaDeTratamientosEnPacientesConCáncerToolStripMenuItem_Click);
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 260);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdministrador";
            this.Text = "FrmAdministrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quejasPorCadaMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afluenciaDePacientesPorPeríodoDeTiempoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosConMayorCantidadDeCitasAtendidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctoresPorCadaEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnósticosMásComunesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eficaciaDeTratamientosEnPacientesConCáncerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem;
    }
}