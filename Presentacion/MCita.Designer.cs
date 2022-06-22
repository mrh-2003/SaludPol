namespace Presentacion
{
    partial class MCita
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
            this.dgvListarCitas = new System.Windows.Forms.DataGridView();
            this.txtIDcita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMinutos = new System.Windows.Forms.ComboBox();
            this.cbxDiagnos = new System.Windows.Forms.ComboBox();
            this.cbxIDdiag = new System.Windows.Forms.ComboBox();
            this.cbxDoctor = new System.Windows.Forms.ComboBox();
            this.cbxNCole = new System.Windows.Forms.ComboBox();
            this.cbxDNIPac = new System.Windows.Forms.ComboBox();
            this.cbxPaci = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListarCitas
            // 
            this.dgvListarCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarCitas.Location = new System.Drawing.Point(408, 83);
            this.dgvListarCitas.Name = "dgvListarCitas";
            this.dgvListarCitas.ReadOnly = true;
            this.dgvListarCitas.Size = new System.Drawing.Size(628, 389);
            this.dgvListarCitas.TabIndex = 0;
            this.dgvListarCitas.SelectionChanged += new System.EventHandler(this.dgvListarCitas_SelectionChanged);
            // 
            // txtIDcita
            // 
            this.txtIDcita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.txtIDcita.Location = new System.Drawing.Point(191, 85);
            this.txtIDcita.Name = "txtIDcita";
            this.txtIDcita.ReadOnly = true;
            this.txtIDcita.Size = new System.Drawing.Size(178, 20);
            this.txtIDcita.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 340);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Cita :\r\n\r\nDNI Paciente : \r\n\r\nPaciente :\r\n\r\nN° Colegiatura :\r\n\r\nDoctor : \r\n\r\nFe" +
    "cha :\r\n\r\nHora :\r\n\r\nID Diagnostico :\r\n\r\nDiagnostico :";
            // 
            // cbxHora
            // 
            this.cbxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cbxHora.Location = new System.Drawing.Point(191, 324);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(83, 21);
            this.cbxHora.TabIndex = 3;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(191, 282);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(178, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(38, 449);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(74, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(295, 449);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(209, 449);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(74, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(404, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "MANTENIMIENTO CITA";
            // 
            // cbxMinutos
            // 
            this.cbxMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinutos.FormattingEnabled = true;
            this.cbxMinutos.Items.AddRange(new object[] {
            "0",
            "30"});
            this.cbxMinutos.Location = new System.Drawing.Point(286, 324);
            this.cbxMinutos.Name = "cbxMinutos";
            this.cbxMinutos.Size = new System.Drawing.Size(83, 21);
            this.cbxMinutos.TabIndex = 3;
            // 
            // cbxDiagnos
            // 
            this.cbxDiagnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDiagnos.FormattingEnabled = true;
            this.cbxDiagnos.Location = new System.Drawing.Point(191, 402);
            this.cbxDiagnos.Name = "cbxDiagnos";
            this.cbxDiagnos.Size = new System.Drawing.Size(178, 21);
            this.cbxDiagnos.TabIndex = 3;
            this.cbxDiagnos.SelectedIndexChanged += new System.EventHandler(this.cbxDiagnos_SelectedIndexChanged);
            // 
            // cbxIDdiag
            // 
            this.cbxIDdiag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDdiag.FormattingEnabled = true;
            this.cbxIDdiag.Location = new System.Drawing.Point(191, 364);
            this.cbxIDdiag.Name = "cbxIDdiag";
            this.cbxIDdiag.Size = new System.Drawing.Size(178, 21);
            this.cbxIDdiag.TabIndex = 3;
            this.cbxIDdiag.SelectedIndexChanged += new System.EventHandler(this.cbxIDdiag_SelectedIndexChanged);
            // 
            // cbxDoctor
            // 
            this.cbxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoctor.FormattingEnabled = true;
            this.cbxDoctor.Items.AddRange(new object[] {
            ""});
            this.cbxDoctor.Location = new System.Drawing.Point(191, 242);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.Size = new System.Drawing.Size(178, 21);
            this.cbxDoctor.TabIndex = 3;
            this.cbxDoctor.SelectedIndexChanged += new System.EventHandler(this.cbxDoctor_SelectedIndexChanged);
            // 
            // cbxNCole
            // 
            this.cbxNCole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNCole.FormattingEnabled = true;
            this.cbxNCole.Location = new System.Drawing.Point(191, 204);
            this.cbxNCole.Name = "cbxNCole";
            this.cbxNCole.Size = new System.Drawing.Size(178, 21);
            this.cbxNCole.TabIndex = 3;
            this.cbxNCole.SelectedIndexChanged += new System.EventHandler(this.cbxNCole_SelectedIndexChanged);
            // 
            // cbxDNIPac
            // 
            this.cbxDNIPac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDNIPac.FormattingEnabled = true;
            this.cbxDNIPac.Location = new System.Drawing.Point(191, 124);
            this.cbxDNIPac.Name = "cbxDNIPac";
            this.cbxDNIPac.Size = new System.Drawing.Size(178, 21);
            this.cbxDNIPac.TabIndex = 3;
            this.cbxDNIPac.SelectedIndexChanged += new System.EventHandler(this.cbxDNIPac_SelectedIndexChanged);
            // 
            // cbxPaci
            // 
            this.cbxPaci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaci.FormattingEnabled = true;
            this.cbxPaci.Location = new System.Drawing.Point(191, 163);
            this.cbxPaci.Name = "cbxPaci";
            this.cbxPaci.Size = new System.Drawing.Size(178, 21);
            this.cbxPaci.TabIndex = 3;
            this.cbxPaci.SelectedIndexChanged += new System.EventHandler(this.cbxPaci_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(124, 449);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(74, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // MCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbxMinutos);
            this.Controls.Add(this.cbxDNIPac);
            this.Controls.Add(this.cbxPaci);
            this.Controls.Add(this.cbxNCole);
            this.Controls.Add(this.cbxDoctor);
            this.Controls.Add(this.cbxIDdiag);
            this.Controls.Add(this.cbxDiagnos);
            this.Controls.Add(this.cbxHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDcita);
            this.Controls.Add(this.dgvListarCitas);
            this.DoubleBuffered = true;
            this.Name = "MCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCita";
            this.Load += new System.EventHandler(this.MCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarCitas;
        private System.Windows.Forms.TextBox txtIDcita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMinutos;
        private System.Windows.Forms.ComboBox cbxDiagnos;
        private System.Windows.Forms.ComboBox cbxIDdiag;
        private System.Windows.Forms.ComboBox cbxDoctor;
        private System.Windows.Forms.ComboBox cbxNCole;
        private System.Windows.Forms.ComboBox cbxDNIPac;
        private System.Windows.Forms.ComboBox cbxPaci;
        private System.Windows.Forms.Button btnLimpiar;
    }
}