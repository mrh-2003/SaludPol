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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTratamientos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTratamientos
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTratamientos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTratamientos.Legends.Add(legend2);
            this.chartTratamientos.Location = new System.Drawing.Point(50, 37);
            this.chartTratamientos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartTratamientos.Name = "chartTratamientos";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTratamientos.Series.Add(series2);
            this.chartTratamientos.Size = new System.Drawing.Size(517, 474);
            this.chartTratamientos.TabIndex = 0;
            this.chartTratamientos.Text = "chart1";
            // 
            // RTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 599);
            this.Controls.Add(this.chartTratamientos);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RTratamientos";
            this.Text = "FrmReporteTratamientos";
            this.Load += new System.EventHandler(this.FrmReporteTratamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTratamientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTratamientos;
    }
}