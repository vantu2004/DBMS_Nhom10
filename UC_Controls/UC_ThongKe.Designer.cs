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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_BieuDoTron = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_SanPhamBanChay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BieuDoTron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SanPhamBanChay)).BeginInit();
            this.SuspendLayout();
            // 
            // chartThongKe
            // 
            chartArea1.AxisX.Title = "Ngày";
            chartArea1.AxisY.Title = "Giá trị";
            chartArea1.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea1);
            this.chartThongKe.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend1);
            this.chartThongKe.Location = new System.Drawing.Point(0, 0);
            this.chartThongKe.Name = "chartThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "tongThu";
            this.chartThongKe.Series.Add(series1);
            this.chartThongKe.Size = new System.Drawing.Size(1147, 1055);
            this.chartThongKe.TabIndex = 1;
            this.chartThongKe.Text = "chart1";
            // 
            // chart_BieuDoTron
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_BieuDoTron.ChartAreas.Add(chartArea2);
            this.chart_BieuDoTron.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart_BieuDoTron.Legends.Add(legend2);
            this.chart_BieuDoTron.Location = new System.Drawing.Point(1147, 0);
            this.chart_BieuDoTron.Name = "chart_BieuDoTron";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "khachHang";
            this.chart_BieuDoTron.Series.Add(series2);
            this.chart_BieuDoTron.Size = new System.Drawing.Size(527, 527);
            this.chart_BieuDoTron.TabIndex = 2;
            this.chart_BieuDoTron.Text = "chart1";
            // 
            // chart_SanPhamBanChay
            // 
            chartArea3.AxisX.Title = "Tên điện thoại";
            chartArea3.AxisY.Title = "Số lượng";
            chartArea3.Name = "ChartArea1";
            this.chart_SanPhamBanChay.ChartAreas.Add(chartArea3);
            this.chart_SanPhamBanChay.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart_SanPhamBanChay.Legends.Add(legend3);
            this.chart_SanPhamBanChay.Location = new System.Drawing.Point(1147, 527);
            this.chart_SanPhamBanChay.Name = "chart_SanPhamBanChay";
            this.chart_SanPhamBanChay.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "soLuong";
            this.chart_SanPhamBanChay.Series.Add(series3);
            this.chart_SanPhamBanChay.Size = new System.Drawing.Size(527, 528);
            this.chart_SanPhamBanChay.TabIndex = 3;
            this.chart_SanPhamBanChay.Text = "chart1";
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart_SanPhamBanChay);
            this.Controls.Add(this.chart_BieuDoTron);
            this.Controls.Add(this.chartThongKe);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1674, 1055);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BieuDoTron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SanPhamBanChay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_BieuDoTron;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SanPhamBanChay;
    }
}
