namespace MT_u
{
    partial class frmPesqDespesa
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
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.dgvDespesa = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.pnlPeriodo = new System.Windows.Forms.Panel();
            this.txtAte = new System.Windows.Forms.MaskedTextBox();
            this.txtDe = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.rdbPaga = new System.Windows.Forms.RadioButton();
            this.rdbPendente = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.colChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.pnlPeriodo.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFundo.Controls.Add(this.panel1);
            this.pnlFundo.Controls.Add(this.dgvDespesa);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(718, 318);
            this.pnlFundo.TabIndex = 0;
            // 
            // dgvDespesa
            // 
            this.dgvDespesa.AllowUserToAddRows = false;
            this.dgvDespesa.AllowUserToDeleteRows = false;
            this.dgvDespesa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDespesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDespesa.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colChk,
            this.colId,
            this.colDescricao,
            this.colDataVenc,
            this.colValor,
            this.colDesconto,
            this.colPaga,
            this.colObject});
            this.dgvDespesa.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDespesa.Location = new System.Drawing.Point(3, 153);
            this.dgvDespesa.Name = "dgvDespesa";
            this.dgvDespesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesa.Size = new System.Drawing.Size(712, 162);
            this.dgvDespesa.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlStatus);
            this.panel1.Controls.Add(this.pnlPeriodo);
            this.panel1.Controls.Add(this.pnlFiltro);
            this.panel1.Controls.Add(this.btPesquisar);
            this.panel1.Controls.Add(this.cmbFiltro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 144);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Código",
            "Descrição",
            "Período",
            "Status"});
            this.cmbFiltro.Location = new System.Drawing.Point(66, 55);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(53, 11);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(260, 20);
            this.txtFiltro.TabIndex = 3;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Location = new System.Drawing.Point(556, 55);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 12;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.label2);
            this.pnlFiltro.Controls.Add(this.txtFiltro);
            this.pnlFiltro.Location = new System.Drawing.Point(193, 44);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(326, 41);
            this.pnlFiltro.TabIndex = 13;
            this.pnlFiltro.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFiltro_Paint);
            // 
            // pnlPeriodo
            // 
            this.pnlPeriodo.Controls.Add(this.txtAte);
            this.pnlPeriodo.Controls.Add(this.txtDe);
            this.pnlPeriodo.Controls.Add(this.label6);
            this.pnlPeriodo.Controls.Add(this.label5);
            this.pnlPeriodo.Location = new System.Drawing.Point(196, 32);
            this.pnlPeriodo.Name = "pnlPeriodo";
            this.pnlPeriodo.Size = new System.Drawing.Size(200, 71);
            this.pnlPeriodo.TabIndex = 14;
            this.pnlPeriodo.Visible = false;
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(64, 35);
            this.txtAte.Mask = "00/00/0000";
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(100, 20);
            this.txtAte.TabIndex = 13;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(64, 12);
            this.txtDe.Mask = "00/00/0000";
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(100, 20);
            this.txtDe.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Até";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "De";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.rdbPendente);
            this.pnlStatus.Controls.Add(this.rdbPaga);
            this.pnlStatus.Location = new System.Drawing.Point(193, 36);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(200, 64);
            this.pnlStatus.TabIndex = 15;
            this.pnlStatus.Visible = false;
            // 
            // rdbPaga
            // 
            this.rdbPaga.AutoSize = true;
            this.rdbPaga.Location = new System.Drawing.Point(29, 11);
            this.rdbPaga.Name = "rdbPaga";
            this.rdbPaga.Size = new System.Drawing.Size(82, 17);
            this.rdbPaga.TabIndex = 0;
            this.rdbPaga.TabStop = true;
            this.rdbPaga.Text = "Status paga";
            this.rdbPaga.UseVisualStyleBackColor = true;
            // 
            // rdbPendente
            // 
            this.rdbPendente.AutoSize = true;
            this.rdbPendente.Location = new System.Drawing.Point(29, 36);
            this.rdbPendente.Name = "rdbPendente";
            this.rdbPendente.Size = new System.Drawing.Size(103, 17);
            this.rdbPendente.TabIndex = 1;
            this.rdbPendente.TabStop = true;
            this.rdbPendente.Text = "Status pendente";
            this.rdbPendente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(56, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(137, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(218, 336);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Exportar XML";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(652, 336);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // colChk
            // 
            this.colChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colChk.HeaderText = "      ";
            this.colChk.Name = "colChk";
            this.colChk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colChk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colChk.Width = 47;
            // 
            // colId
            // 
            this.colId.HeaderText = "Código";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colDataVenc
            // 
            this.colDataVenc.HeaderText = "Data venc.";
            this.colDataVenc.Name = "colDataVenc";
            this.colDataVenc.ReadOnly = true;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // colDesconto
            // 
            this.colDesconto.HeaderText = "Desconto";
            this.colDesconto.Name = "colDesconto";
            this.colDesconto.ReadOnly = true;
            // 
            // colPaga
            // 
            this.colPaga.HeaderText = "Paga";
            this.colPaga.Name = "colPaga";
            this.colPaga.ReadOnly = true;
            // 
            // colObject
            // 
            this.colObject.HeaderText = "obj";
            this.colObject.Name = "colObject";
            this.colObject.ReadOnly = true;
            this.colObject.Visible = false;
            // 
            // frmPesqDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 364);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlFundo);
            this.Name = "frmPesqDespesa";
            this.Text = "Pesquisar despesa";
            this.pnlFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.pnlPeriodo.ResumeLayout(false);
            this.pnlPeriodo.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.DataGridView dgvDespesa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Panel pnlPeriodo;
        private System.Windows.Forms.MaskedTextBox txtAte;
        private System.Windows.Forms.MaskedTextBox txtDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.RadioButton rdbPendente;
        private System.Windows.Forms.RadioButton rdbPaga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObject;
    }
}