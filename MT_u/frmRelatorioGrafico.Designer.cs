namespace MT_u
{
    partial class frmRelatorioGrafico
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
            this.pnlGraficoMensal = new System.Windows.Forms.Panel();
            this.graficMensal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlGraficoMensal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficMensal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGraficoMensal
            // 
            this.pnlGraficoMensal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGraficoMensal.Controls.Add(this.graficMensal);
            this.pnlGraficoMensal.Location = new System.Drawing.Point(12, 12);
            this.pnlGraficoMensal.Name = "pnlGraficoMensal";
            this.pnlGraficoMensal.Size = new System.Drawing.Size(726, 305);
            this.pnlGraficoMensal.TabIndex = 0;
            // 
            // graficMensal
            // 
            chartArea1.Name = "ChartArea1";
            this.graficMensal.ChartAreas.Add(chartArea1);
            this.graficMensal.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.graficMensal.Legends.Add(legend1);
            this.graficMensal.Location = new System.Drawing.Point(0, 54);
            this.graficMensal.Name = "graficMensal";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficMensal.Series.Add(series1);
            this.graficMensal.Size = new System.Drawing.Size(724, 249);
            this.graficMensal.TabIndex = 0;
            this.graficMensal.Text = "chart1";
            // 
            // frmRelatorioGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 329);
            this.Controls.Add(this.pnlGraficoMensal);
            this.Name = "frmRelatorioGrafico";
            this.Text = "frmRelatorioGrafico";
            this.pnlGraficoMensal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graficMensal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGraficoMensal;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficMensal;
    }
}