﻿namespace Presentacion
{
    partial class RAfluencia
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
            this.chartAfluencia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartAfluencia)).BeginInit();
            this.SuspendLayout();
            // 
            // chartAfluencia
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAfluencia.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAfluencia.Legends.Add(legend2);
            this.chartAfluencia.Location = new System.Drawing.Point(23, 23);
            this.chartAfluencia.Name = "chartAfluencia";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAfluencia.Series.Add(series2);
            this.chartAfluencia.Size = new System.Drawing.Size(531, 401);
            this.chartAfluencia.TabIndex = 0;
            this.chartAfluencia.Text = "chart1";
            // 
            // cbxMes
            // 
            this.cbxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxMes.Location = new System.Drawing.Point(625, 74);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(121, 21);
            this.cbxMes.TabIndex = 1;
            this.cbxMes.SelectedIndexChanged += new System.EventHandler(this.cbxMes_SelectedIndexChanged);
            // 
            // ReporteAfluencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxMes);
            this.Controls.Add(this.chartAfluencia);
            this.Name = "ReporteAfluencia";
            this.Text = "ReporteAfluencia";
            this.Load += new System.EventHandler(this.ReporteAfluencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAfluencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartAfluencia;
        private System.Windows.Forms.ComboBox cbxMes;
    }
}