namespace Personel_Kayit
{
    partial class FrmGrafikler
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
            this.chart_ortMaas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_MeslekSayisi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ortMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MeslekSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_ortMaas
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_ortMaas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_ortMaas.Legends.Add(legend1);
            this.chart_ortMaas.Location = new System.Drawing.Point(12, 63);
            this.chart_ortMaas.Name = "chart_ortMaas";
            this.chart_ortMaas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "OrtMaas";
            this.chart_ortMaas.Series.Add(series1);
            this.chart_ortMaas.Size = new System.Drawing.Size(631, 367);
            this.chart_ortMaas.TabIndex = 0;
            this.chart_ortMaas.Text = "OrtMaas";
            // 
            // chart_MeslekSayisi
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_MeslekSayisi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_MeslekSayisi.Legends.Add(legend2);
            this.chart_MeslekSayisi.Location = new System.Drawing.Point(729, 63);
            this.chart_MeslekSayisi.Name = "chart_MeslekSayisi";
            this.chart_MeslekSayisi.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Meslek";
            this.chart_MeslekSayisi.Series.Add(series2);
            this.chart_MeslekSayisi.Size = new System.Drawing.Size(603, 367);
            this.chart_MeslekSayisi.TabIndex = 1;
            this.chart_MeslekSayisi.Text = "\"";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 621);
            this.Controls.Add(this.chart_MeslekSayisi);
            this.Controls.Add(this.chart_ortMaas);
            this.Name = "FrmGrafikler";
            this.Text = "FrmGrafikler";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_ortMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_MeslekSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ortMaas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_MeslekSayisi;
    }
}