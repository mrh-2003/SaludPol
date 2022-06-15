namespace Presentacion
{
    partial class FrmLogin
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
            this.cbxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbTipoUsuario = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lbContra = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxTipoUsuario
            // 
            this.cbxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoUsuario.FormattingEnabled = true;
            this.cbxTipoUsuario.Items.AddRange(new object[] {
            "Paciente",
            "Doctor",
            "Administrador"});
            this.cbxTipoUsuario.Location = new System.Drawing.Point(507, 41);
            this.cbxTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTipoUsuario.Name = "cbxTipoUsuario";
            this.cbxTipoUsuario.Size = new System.Drawing.Size(267, 24);
            this.cbxTipoUsuario.TabIndex = 0;
            this.cbxTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cbxTipoUsuario_SelectedIndexChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(507, 86);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(267, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // lbTipoUsuario
            // 
            this.lbTipoUsuario.AutoSize = true;
            this.lbTipoUsuario.Location = new System.Drawing.Point(401, 90);
            this.lbTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTipoUsuario.Name = "lbTipoUsuario";
            this.lbTipoUsuario.Size = new System.Drawing.Size(44, 16);
            this.lbTipoUsuario.TabIndex = 3;
            this.lbTipoUsuario.Text = "label1";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(507, 139);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(267, 22);
            this.txtContra.TabIndex = 2;
            // 
            // lbContra
            // 
            this.lbContra.AutoSize = true;
            this.lbContra.Location = new System.Drawing.Point(401, 148);
            this.lbContra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContra.Name = "lbContra";
            this.lbContra.Size = new System.Drawing.Size(82, 16);
            this.lbContra.TabIndex = 4;
            this.lbContra.Text = "Contraseña :";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(507, 197);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(268, 28);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 256);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lbContra);
            this.Controls.Add(this.lbTipoUsuario);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cbxTipoUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLogin";
            this.Text = "SaludPol";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipoUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbTipoUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lbContra;
        private System.Windows.Forms.Button btnIngresar;
    }
}

