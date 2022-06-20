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
            this.SuspendLayout();
            // 
            // cbxDoctor
            // 
            this.cbxDoctor.FormattingEnabled = true;
            this.cbxDoctor.Location = new System.Drawing.Point(334, 26);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.Size = new System.Drawing.Size(121, 21);
            this.cbxDoctor.TabIndex = 0;
            this.cbxDoctor.SelectedIndexChanged += new System.EventHandler(this.cbxDoctor_SelectedIndexChanged);
            // 
            // lsQuejas
            // 
            this.lsQuejas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.lsQuejas.FormattingEnabled = true;
            this.lsQuejas.Location = new System.Drawing.Point(24, 69);
            this.lsQuejas.Name = "lsQuejas";
            this.lsQuejas.Size = new System.Drawing.Size(764, 368);
            this.lsQuejas.TabIndex = 1;
            // 
            // RQuejasContenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsQuejas);
            this.Controls.Add(this.cbxDoctor);
            this.DoubleBuffered = true;
            this.Name = "RQuejasContenido";
            this.Text = "RQuejasContenido";
            this.Load += new System.EventHandler(this.RQuejasContenido_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDoctor;
        private System.Windows.Forms.ListBox lsQuejas;
    }
}