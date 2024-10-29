namespace Nhom11
{
    partial class UC_ThongKe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_ThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_ThongKe
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_ThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_ThongKe.Legends.Add(legend1);
            this.chart_ThongKe.Location = new System.Drawing.Point(3, 3);
            this.chart_ThongKe.Name = "chart_ThongKe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_ThongKe.Series.Add(series1);
            this.chart_ThongKe.Size = new System.Drawing.Size(1098, 720);
            this.chart_ThongKe.TabIndex = 1;
            this.chart_ThongKe.Text = "chart1";
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart_ThongKe);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1104, 726);
            ((System.ComponentModel.ISupportInitialize)(this.chart_ThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ThongKe;
    }
}
