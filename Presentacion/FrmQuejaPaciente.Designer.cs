﻿namespace Presentacion
{
    partial class FrmQuejaPaciente
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
            this.comboBoxnombredoctores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxquejaaingresar = new System.Windows.Forms.TextBox();
            this.buttonqueja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxnombredoctores
            // 
            this.comboBoxnombredoctores.FormattingEnabled = true;
            this.comboBoxnombredoctores.Location = new System.Drawing.Point(154, 53);
            this.comboBoxnombredoctores.Name = "comboBoxnombredoctores";
            this.comboBoxnombredoctores.Size = new System.Drawing.Size(202, 21);
            this.comboBoxnombredoctores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de doctores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese su queja";
            // 
            // textBoxquejaaingresar
            // 
            this.textBoxquejaaingresar.Location = new System.Drawing.Point(154, 129);
            this.textBoxquejaaingresar.Multiline = true;
            this.textBoxquejaaingresar.Name = "textBoxquejaaingresar";
            this.textBoxquejaaingresar.Size = new System.Drawing.Size(374, 95);
            this.textBoxquejaaingresar.TabIndex = 3;
            // 
            // buttonqueja
            // 
            this.buttonqueja.Location = new System.Drawing.Point(423, 277);
            this.buttonqueja.Name = "buttonqueja";
            this.buttonqueja.Size = new System.Drawing.Size(105, 23);
            this.buttonqueja.TabIndex = 4;
            this.buttonqueja.Text = "Ingresar queja";
            this.buttonqueja.UseVisualStyleBackColor = true;
            this.buttonqueja.Click += new System.EventHandler(this.buttonqueja_Click);
            // 
            // FrmQuejaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 361);
            this.Controls.Add(this.buttonqueja);
            this.Controls.Add(this.textBoxquejaaingresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxnombredoctores);
            this.Name = "FrmQuejaPaciente";
            this.Text = "FrmQuejaPaciente";
            this.Load += new System.EventHandler(this.FrmQuejaPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxnombredoctores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxquejaaingresar;
        private System.Windows.Forms.Button buttonqueja;
    }
}