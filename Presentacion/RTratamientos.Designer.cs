namespace Presentacion
{
    partial class RTratamientos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTratamientos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTratamientos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTratamientos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTratamientos.Legends.Add(legend1);
            this.chartTratamientos.Location = new System.Drawing.Point(25, 34);
            this.chartTratamientos.Margin = new System.Windows.Forms.Padding(2);
            this.chartTratamientos.Name = "chartTratamientos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTratamientos.Series.Add(series1);
            this.chartTratamientos.Size = new System.Drawing.Size(517, 474);
            this.chartTratamientos.TabIndex = 0;
            this.chartTratamientos.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "TRATAMIENTOS MAS EFECTIVOS";
            // 
            // RTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 549);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chartTratamientos);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RTratamientos";
            this.Text = "FrmReporteTratamientos";
            this.Load += new System.EventHandler(this.FrmReporteTratamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTratamientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTratamientos;
        private System.Windows.Forms.Label label6;
    }
}