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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnl = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAcao = new System.Windows.Forms.Button();
            this.pnlPeriodo = new System.Windows.Forms.Panel();
            this.txtAte = new System.Windows.Forms.MaskedTextBox();
            this.txtDe = new System.Windows.Forms.MaskedTextBox();
            this.lblAte = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.graficObj = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlFundo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficObj)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Controls.Add(this.tabControl1);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(1096, 618);
            this.pnlFundo.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1072, 594);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnl);
            this.tabPage1.Controls.Add(this.graficObj);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1064, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gráfico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnl
            // 
            this.pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl.Controls.Add(this.groupBox1);
            this.pnl.Location = new System.Drawing.Point(6, 6);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1052, 175);
            this.pnl.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAcao);
            this.groupBox1.Controls.Add(this.pnlPeriodo);
            this.groupBox1.Controls.Add(this.cmbFiltro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerar gráfico";
            // 
            // btAcao
            // 
            this.btAcao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcao.Location = new System.Drawing.Point(695, 73);
            this.btAcao.Name = "btAcao";
            this.btAcao.Size = new System.Drawing.Size(75, 23);
            this.btAcao.TabIndex = 12;
            this.btAcao.Text = "Gerar";
            this.btAcao.UseVisualStyleBackColor = false;
            this.btAcao.Click += new System.EventHandler(this.btAcao_Click);
            // 
            // pnlPeriodo
            // 
            this.pnlPeriodo.Controls.Add(this.txtAte);
            this.pnlPeriodo.Controls.Add(this.txtDe);
            this.pnlPeriodo.Controls.Add(this.lblAte);
            this.pnlPeriodo.Controls.Add(this.label2);
            this.pnlPeriodo.Location = new System.Drawing.Point(213, 44);
            this.pnlPeriodo.Name = "pnlPeriodo";
            this.pnlPeriodo.Size = new System.Drawing.Size(225, 71);
            this.pnlPeriodo.TabIndex = 2;
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(35, 41);
            this.txtAte.Mask = "00/00/0000";
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(100, 20);
            this.txtAte.TabIndex = 3;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(35, 16);
            this.txtDe.Mask = "00/00/0000";
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(100, 20);
            this.txtDe.TabIndex = 2;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(3, 44);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(26, 13);
            this.lblAte.TabIndex = 1;
            this.lblAte.Text = "Ate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "De:";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Periodo",
            "Específico"});
            this.cmbFiltro.Location = new System.Drawing.Point(63, 70);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(131, 21);
            this.cmbFiltro.TabIndex = 1;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar por";
            // 
            // graficObj
            // 
            this.graficObj.BorderSkin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.graficObj.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle3;
            chartArea1.Name = "ChartArea1";
            this.graficObj.ChartAreas.Add(chartArea1);
            this.graficObj.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Name = "Legend1";
            this.graficObj.Legends.Add(legend1);
            this.graficObj.Location = new System.Drawing.Point(6, 187);
            this.graficObj.Name = "graficObj";
            this.graficObj.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Gasto";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Ganho";
            this.graficObj.Series.Add(series1);
            this.graficObj.Series.Add(series2);
            this.graficObj.Size = new System.Drawing.Size(1055, 375);
            this.graficObj.TabIndex = 1;
            this.graficObj.Text = "chart1";
            title1.Name = "Gasto";
            title1.Text = "Análise de gastos e ganhos";
            this.graficObj.Titles.Add(title1);
            // 
            // frmRelatorioGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1096, 618);
            this.Controls.Add(this.pnlFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRelatorioGrafico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráfico estratégico";
            this.Load += new System.EventHandler(this.frmRelatorioGrafico_Load);
            this.pnlFundo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlPeriodo.ResumeLayout(false);
            this.pnlPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficObj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficObj;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlPeriodo;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDe;
        private System.Windows.Forms.MaskedTextBox txtAte;
        private System.Windows.Forms.Button btAcao;
    }
}