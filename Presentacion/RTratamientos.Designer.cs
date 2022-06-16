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
            ((System.ComponentModel.ISupportInitialize)(this.chartTratamientos)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTratamientos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTratamientos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTratamientos.Legends.Add(legend1);
            this.chartTratamientos.Location = new System.Drawing.Point(67, 46);
            this.chartTratamientos.Name = "chartTratamientos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTratamientos.Series.Add(series1);
            this.chartTratamientos.Size = new System.Drawing.Size(689, 583);
            this.chartTratamientos.TabIndex = 0;
            this.chartTratamientos.Text = "chart1";
            // 
            // FrmReporteTratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 737);
            this.Controls.Add(this.chartTratamientos);
            this.Name = "FrmReporteTratamientos";
            this.Text = "FrmReporteTratamientos";
            this.Load += new System.EventHandler(this.FrmReporteTratamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTratamientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTratamientos;
    }
}