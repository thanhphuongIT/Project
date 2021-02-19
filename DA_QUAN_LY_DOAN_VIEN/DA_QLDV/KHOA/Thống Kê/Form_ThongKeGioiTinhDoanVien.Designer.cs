namespace DA_QLDV
{
    partial class Form_ThongKeGioiTinhDoanVien
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
            this.ChartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ChartPie)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartPie
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartPie.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartPie.Legends.Add(legend1);
            this.ChartPie.Location = new System.Drawing.Point(196, 135);
            this.ChartPie.Name = "ChartPie";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Biểu Đồ";
            this.ChartPie.Series.Add(series1);
            this.ChartPie.Size = new System.Drawing.Size(698, 532);
            this.ChartPie.TabIndex = 0;
            this.ChartPie.Text = "chart1";
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("UVN Hong Ha Hep", 36F, System.Drawing.FontStyle.Bold);
            this.reflectionLabel1.ForeColor = System.Drawing.Color.Red;
            this.reflectionLabel1.Location = new System.Drawing.Point(229, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(651, 117);
            this.reflectionLabel1.TabIndex = 1;
            this.reflectionLabel1.Text = "THỐNG KÊ GIỚI TÍNH ĐOÀN VIÊN";
            // 
            // Form_ThongKeGioiTinhDoanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 698);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.ChartPie);
            this.Font = new System.Drawing.Font("UVN Cat Bien Nhe", 10.8F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_ThongKeGioiTinhDoanVien";
            this.Text = "Form_QuanLyKyLuat";
            this.Load += new System.EventHandler(this.Form_ThongKeGioiTinhDoanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartPie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartPie;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
    }
}