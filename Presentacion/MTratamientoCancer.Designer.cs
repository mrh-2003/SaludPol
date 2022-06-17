namespace Presentacion
{
    partial class MTratamientoCancer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId_tratamiento = new System.Windows.Forms.TextBox();
            this.textBoxPacientesCurados = new System.Windows.Forms.TextBox();
            this.textBoxNombreT = new System.Windows.Forms.TextBox();
            this.dataGridViewTratamientos = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_tratamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "# Pacientes curados";
            // 
            // txtId_tratamiento
            // 
            this.txtId_tratamiento.Location = new System.Drawing.Point(118, 39);
            this.txtId_tratamiento.Name = "txtId_tratamiento";
            this.txtId_tratamiento.ReadOnly = true;
            this.txtId_tratamiento.Size = new System.Drawing.Size(154, 20);
            this.txtId_tratamiento.TabIndex = 3;
            // 
            // textBoxPacientesCurados
            // 
            this.textBoxPacientesCurados.Location = new System.Drawing.Point(118, 84);
            this.textBoxPacientesCurados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPacientesCurados.Name = "textBoxPacientesCurados";
            this.textBoxPacientesCurados.Size = new System.Drawing.Size(154, 20);
            this.textBoxPacientesCurados.TabIndex = 4;
            // 
            // textBoxNombreT
            // 
            this.textBoxNombreT.Location = new System.Drawing.Point(123, 145);
            this.textBoxNombreT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombreT.Name = "textBoxNombreT";
            this.textBoxNombreT.Size = new System.Drawing.Size(154, 20);
            this.textBoxNombreT.TabIndex = 5;
            // 
            // dataGridViewTratamientos
            // 
            this.dataGridViewTratamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTratamientos.Location = new System.Drawing.Point(314, 39);
            this.dataGridViewTratamientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTratamientos.Name = "dataGridViewTratamientos";
            this.dataGridViewTratamientos.RowHeadersWidth = 51;
            this.dataGridViewTratamientos.RowTemplate.Height = 24;
            this.dataGridViewTratamientos.Size = new System.Drawing.Size(248, 132);
            this.dataGridViewTratamientos.TabIndex = 6;
            this.dataGridViewTratamientos.SelectionChanged += new System.EventHandler(this.dataGridViewTratamientos_SelectionChanged);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(28, 238);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(56, 19);
            this.buttonAgregar.TabIndex = 7;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(166, 238);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(56, 19);
            this.buttonModificar.TabIndex = 8;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(314, 238);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(56, 19);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre de Tratamiento";
            // 
            // MTratamientoCancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dataGridViewTratamientos);
            this.Controls.Add(this.textBoxNombreT);
            this.Controls.Add(this.textBoxPacientesCurados);
            this.Controls.Add(this.txtId_tratamiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MTratamientoCancer";
            this.Text = "MTratamientoCancer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId_tratamiento;
        private System.Windows.Forms.TextBox textBoxPacientesCurados;
        private System.Windows.Forms.TextBox textBoxNombreT;
        private System.Windows.Forms.DataGridView dataGridViewTratamientos;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label3;
    }
}