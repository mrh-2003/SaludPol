namespace Presentacion
{
    partial class FrmDoctor
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
            this.pnlCancer = new System.Windows.Forms.Panel();
            this.cbxTratamientos = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxPacienteCurado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDiag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataCita = new System.Windows.Forms.DataGridView();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxDiagnos = new System.Windows.Forms.ComboBox();
            this.btnRegistrarDiag = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxMinutos = new System.Windows.Forms.ComboBox();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCancer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCita)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCancer
            // 
            this.pnlCancer.BackColor = System.Drawing.Color.Transparent;
            this.pnlCancer.Controls.Add(this.cbxTratamientos);
            this.pnlCancer.Controls.Add(this.btnRegistrar);
            this.pnlCancer.Controls.Add(this.label7);
            this.pnlCancer.Controls.Add(this.cbxPacienteCurado);
            this.pnlCancer.Controls.Add(this.label8);
            this.pnlCancer.Location = new System.Drawing.Point(13, 13);
            this.pnlCancer.Name = "pnlCancer";
            this.pnlCancer.Size = new System.Drawing.Size(275, 155);
            this.pnlCancer.TabIndex = 0;
            // 
            // cbxTratamientos
            // 
            this.cbxTratamientos.FormattingEnabled = true;
            this.cbxTratamientos.Location = new System.Drawing.Point(137, 17);
            this.cbxTratamientos.Name = "cbxTratamientos";
            this.cbxTratamientos.Size = new System.Drawing.Size(121, 21);
            this.cbxTratamientos.TabIndex = 90;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(78, 109);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 94;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Nombre tratamiento";
            // 
            // cbxPacienteCurado
            // 
            this.cbxPacienteCurado.FormattingEnabled = true;
            this.cbxPacienteCurado.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbxPacienteCurado.Location = new System.Drawing.Point(137, 55);
            this.cbxPacienteCurado.Name = "cbxPacienteCurado";
            this.cbxPacienteCurado.Size = new System.Drawing.Size(121, 21);
            this.cbxPacienteCurado.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "Paciente curado";
            // 
            // btnDiag
            // 
            this.btnDiag.Location = new System.Drawing.Point(474, 439);
            this.btnDiag.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiag.Name = "btnDiag";
            this.btnDiag.Size = new System.Drawing.Size(234, 67);
            this.btnDiag.TabIndex = 69;
            this.btnDiag.Text = "Mantenimiento de Diagnostico";
            this.btnDiag.UseVisualStyleBackColor = true;
            this.btnDiag.Click += new System.EventHandler(this.btnDiag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "falta poner que el doctor registre diagnostico de pacientes ";
            // 
            // dataCita
            // 
            this.dataCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCita.Location = new System.Drawing.Point(440, 252);
            this.dataCita.Margin = new System.Windows.Forms.Padding(2);
            this.dataCita.Name = "dataCita";
            this.dataCita.RowHeadersWidth = 51;
            this.dataCita.RowTemplate.Height = 24;
            this.dataCita.Size = new System.Drawing.Size(313, 160);
            this.dataCita.TabIndex = 89;
            this.dataCita.SelectionChanged += new System.EventHandler(this.dataPaciente_SelectionChanged);
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.textBoxApellidos.Location = new System.Drawing.Point(567, 99);
            this.textBoxApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.ReadOnly = true;
            this.textBoxApellidos.Size = new System.Drawing.Size(141, 20);
            this.textBoxApellidos.TabIndex = 85;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.textBoxNombres.Location = new System.Drawing.Point(567, 64);
            this.textBoxNombres.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.ReadOnly = true;
            this.textBoxNombres.Size = new System.Drawing.Size(141, 20);
            this.textBoxNombres.TabIndex = 84;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.textBoxDNI.Location = new System.Drawing.Point(567, 19);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.ReadOnly = true;
            this.textBoxDNI.Size = new System.Drawing.Size(141, 20);
            this.textBoxDNI.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(441, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(441, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Nombres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(441, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "DNI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbxDiagnos);
            this.panel1.Controls.Add(this.btnRegistrarDiag);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(13, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 144);
            this.panel1.TabIndex = 96;
            // 
            // cbxDiagnos
            // 
            this.cbxDiagnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDiagnos.FormattingEnabled = true;
            this.cbxDiagnos.Location = new System.Drawing.Point(127, 61);
            this.cbxDiagnos.Name = "cbxDiagnos";
            this.cbxDiagnos.Size = new System.Drawing.Size(128, 21);
            this.cbxDiagnos.TabIndex = 95;
            // 
            // btnRegistrarDiag
            // 
            this.btnRegistrarDiag.Location = new System.Drawing.Point(91, 103);
            this.btnRegistrarDiag.Name = "btnRegistrarDiag";
            this.btnRegistrarDiag.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarDiag.TabIndex = 94;
            this.btnRegistrarDiag.Text = "Registrar";
            this.btnRegistrarDiag.UseVisualStyleBackColor = true;
            this.btnRegistrarDiag.Click += new System.EventHandler(this.btnRegistrarDiag_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Nombre tratamiento";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(567, 139);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(141, 20);
            this.dtpFecha.TabIndex = 100;
            // 
            // cbxMinutos
            // 
            this.cbxMinutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.cbxMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinutos.FormattingEnabled = true;
            this.cbxMinutos.Items.AddRange(new object[] {
            "0",
            "30"});
            this.cbxMinutos.Location = new System.Drawing.Point(648, 176);
            this.cbxMinutos.Name = "cbxMinutos";
            this.cbxMinutos.Size = new System.Drawing.Size(60, 21);
            this.cbxMinutos.TabIndex = 98;
            // 
            // cbxHora
            // 
            this.cbxHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
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
            this.cbxHora.Location = new System.Drawing.Point(567, 176);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(60, 21);
            this.cbxHora.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(441, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(441, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 102;
            this.label5.Text = "Hora";
            // 
            // FrmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbxMinutos);
            this.Controls.Add(this.cbxHora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCita);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.textBoxNombres);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDiag);
            this.Controls.Add(this.pnlCancer);
            this.DoubleBuffered = true;
            this.Name = "FrmDoctor";
            this.Text = "FrmDoctor";
            this.Load += new System.EventHandler(this.FrmDoctor_Load);
            this.pnlCancer.ResumeLayout(false);
            this.pnlCancer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCita)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCancer;
        private System.Windows.Forms.Button btnDiag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbxPacienteCurado;
        private System.Windows.Forms.ComboBox cbxTratamientos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataCita;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrarDiag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxDiagnos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxMinutos;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}