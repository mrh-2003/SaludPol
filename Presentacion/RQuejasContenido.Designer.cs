namespace Presentacion
{
    partial class RQuejasContenido
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
            this.cbxDoctor = new System.Windows.Forms.ComboBox();
            this.lsQuejas = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxDoctor
            // 
            this.cbxDoctor.FormattingEnabled = true;
            this.cbxDoctor.Location = new System.Drawing.Point(414, 63);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.Size = new System.Drawing.Size(121, 21);
            this.cbxDoctor.TabIndex = 0;
            this.cbxDoctor.SelectedIndexChanged += new System.EventHandler(this.cbxDoctor_SelectedIndexChanged);
            // 
            // lsQuejas
            // 
            this.lsQuejas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.lsQuejas.FormattingEnabled = true;
            this.lsQuejas.Location = new System.Drawing.Point(12, 92);
            this.lsQuejas.Name = "lsQuejas";
            this.lsQuejas.Size = new System.Drawing.Size(764, 238);
            this.lsQuejas.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(269, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "QUEJAS POR DOCTORES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Seleccione un doctor ";
            // 
            // RQuejasContenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lsQuejas);
            this.Controls.Add(this.cbxDoctor);
            this.DoubleBuffered = true;
            this.Name = "RQuejasContenido";
            this.Text = "RQuejasContenido";
            this.Load += new System.EventHandler(this.RQuejasContenido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDoctor;
        private System.Windows.Forms.ListBox lsQuejas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}