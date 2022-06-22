namespace Presentacion
{
    partial class FrmPacientes
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
            this.btnQueja = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxMinutos = new System.Windows.Forms.ComboBox();
            this.cbxNCole = new System.Windows.Forms.ComboBox();
            this.cbxDoctor = new System.Windows.Forms.ComboBox();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDcita = new System.Windows.Forms.TextBox();
            this.dgvListarCitas = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQueja
            // 
            this.btnQueja.Location = new System.Drawing.Point(456, 319);
            this.btnQueja.Name = "btnQueja";
            this.btnQueja.Size = new System.Drawing.Size(120, 35);
            this.btnQueja.TabIndex = 18;
            this.btnQueja.Text = "Insertar queja";
            this.btnQueja.UseVisualStyleBackColor = true;
            this.btnQueja.Click += new System.EventHandler(this.btnQueja_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(116, 281);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 32);
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(145, 199);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(145, 20);
            this.dtpFecha.TabIndex = 17;
            // 
            // cbxMinutos
            // 
            this.cbxMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMinutos.FormattingEnabled = true;
            this.cbxMinutos.Items.AddRange(new object[] {
            "0",
            "30"});
            this.cbxMinutos.Location = new System.Drawing.Point(221, 241);
            this.cbxMinutos.Name = "cbxMinutos";
            this.cbxMinutos.Size = new System.Drawing.Size(69, 21);
            this.cbxMinutos.TabIndex = 9;
            // 
            // cbxNCole
            // 
            this.cbxNCole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNCole.FormattingEnabled = true;
            this.cbxNCole.Location = new System.Drawing.Point(145, 121);
            this.cbxNCole.Name = "cbxNCole";
            this.cbxNCole.Size = new System.Drawing.Size(145, 21);
            this.cbxNCole.TabIndex = 12;
            this.cbxNCole.SelectedIndexChanged += new System.EventHandler(this.cbxNCole_SelectedIndexChanged);
            // 
            // cbxDoctor
            // 
            this.cbxDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.cbxDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoctor.FormattingEnabled = true;
            this.cbxDoctor.Items.AddRange(new object[] {
            ""});
            this.cbxDoctor.Location = new System.Drawing.Point(145, 159);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.Size = new System.Drawing.Size(145, 21);
            this.cbxDoctor.TabIndex = 13;
            this.cbxDoctor.SelectedIndexChanged += new System.EventHandler(this.cbxDoctor_SelectedIndexChanged);
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
            this.cbxHora.Location = new System.Drawing.Point(145, 241);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(69, 21);
            this.cbxHora.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 180);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Cita :\r\n\r\nN° Colegiatura :\r\n\r\nDoctor : \r\n\r\nFecha :\r\n\r\nHora :";
            // 
            // txtIDcita
            // 
            this.txtIDcita.Location = new System.Drawing.Point(145, 87);
            this.txtIDcita.Name = "txtIDcita";
            this.txtIDcita.ReadOnly = true;
            this.txtIDcita.Size = new System.Drawing.Size(145, 20);
            this.txtIDcita.TabIndex = 7;
            // 
            // dgvListarCitas
            // 
            this.dgvListarCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarCitas.Location = new System.Drawing.Point(336, 83);
            this.dgvListarCitas.Name = "dgvListarCitas";
            this.dgvListarCitas.ReadOnly = true;
            this.dgvListarCitas.Size = new System.Drawing.Size(377, 230);
            this.dgvListarCitas.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(481, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "LISTA DE MIS CITAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "RESERVAR UNA CITA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 80;
            this.label3.Text = "PACIENTE";
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnQueja);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbxMinutos);
            this.Controls.Add(this.cbxNCole);
            this.Controls.Add(this.cbxDoctor);
            this.Controls.Add(this.cbxHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDcita);
            this.Controls.Add(this.dgvListarCitas);
            this.DoubleBuffered = true;
            this.Name = "FrmPacientes";
            this.Text = "FrmPacientes";
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarCitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQueja;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxMinutos;
        private System.Windows.Forms.ComboBox cbxNCole;
        private System.Windows.Forms.ComboBox cbxDoctor;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDcita;
        private System.Windows.Forms.DataGridView dgvListarCitas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}