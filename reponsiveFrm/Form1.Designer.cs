namespace reponsiveFrm
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.productoXcategoriaChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.productoPreferidoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.productoXcategoriaChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoPreferidoChart)).BeginInit();
            this.SuspendLayout();
            // 
            // productoXcategoriaChart
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            this.productoXcategoriaChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.productoXcategoriaChart.Legends.Add(legend1);
            this.productoXcategoriaChart.Location = new System.Drawing.Point(23, 142);
            this.productoXcategoriaChart.Name = "productoXcategoriaChart";
            this.productoXcategoriaChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.productoXcategoriaChart.Series.Add(series1);
            this.productoXcategoriaChart.Size = new System.Drawing.Size(300, 300);
            this.productoXcategoriaChart.TabIndex = 0;
            this.productoXcategoriaChart.Text = "chart1";
            // 
            // productoPreferidoChart
            // 
            chartArea2.Name = "ChartArea1";
            this.productoPreferidoChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.productoPreferidoChart.Legends.Add(legend2);
            this.productoPreferidoChart.Location = new System.Drawing.Point(514, 142);
            this.productoPreferidoChart.Name = "productoPreferidoChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.productoPreferidoChart.Series.Add(series2);
            this.productoPreferidoChart.Size = new System.Drawing.Size(300, 300);
            this.productoPreferidoChart.TabIndex = 1;
            this.productoPreferidoChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.productoPreferidoChart);
            this.Controls.Add(this.productoXcategoriaChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoXcategoriaChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoPreferidoChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart productoXcategoriaChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart productoPreferidoChart;
    }
}

