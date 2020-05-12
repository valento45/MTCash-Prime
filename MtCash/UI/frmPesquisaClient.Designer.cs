namespace MtCash.UI
{
    partial class frmPesquisaClient
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
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.pnlDocumento = new System.Windows.Forms.Panel();
            this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCpjCnpj = new System.Windows.Forms.Panel();
            this.txtCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlNome = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHistAlt = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportXml = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlFundo.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlDocumento.SuspendLayout();
            this.pnlCpjCnpj.SuspendLayout();
            this.pnlNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.Color.LightCyan;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundo.Controls.Add(this.pnlFilters);
            this.pnlFundo.Controls.Add(this.dgvClient);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(851, 346);
            this.pnlFundo.TabIndex = 0;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.btnPesquisar);
            this.pnlFilters.Controls.Add(this.cmbFiltro);
            this.pnlFilters.Controls.Add(this.pnlCpjCnpj);
            this.pnlFilters.Controls.Add(this.pnlDocumento);
            this.pnlFilters.Controls.Add(this.label1);
            this.pnlFilters.Controls.Add(this.pnlNome);
            this.pnlFilters.Location = new System.Drawing.Point(3, 22);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(843, 89);
            this.pnlFilters.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.LightCyan;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(683, 33);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 23);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(81, 37);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 2;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // pnlDocumento
            // 
            this.pnlDocumento.Controls.Add(this.txtDocumento);
            this.pnlDocumento.Controls.Add(this.label4);
            this.pnlDocumento.Location = new System.Drawing.Point(208, 12);
            this.pnlDocumento.Name = "pnlDocumento";
            this.pnlDocumento.Size = new System.Drawing.Size(393, 62);
            this.pnlDocumento.TabIndex = 5;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(95, 22);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(194, 20);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDocumento_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar";
            // 
            // pnlCpjCnpj
            // 
            this.pnlCpjCnpj.Controls.Add(this.txtCpfCnpj);
            this.pnlCpjCnpj.Controls.Add(this.label3);
            this.pnlCpjCnpj.Location = new System.Drawing.Point(205, 12);
            this.pnlCpjCnpj.Name = "pnlCpjCnpj";
            this.pnlCpjCnpj.Size = new System.Drawing.Size(393, 62);
            this.pnlCpjCnpj.TabIndex = 4;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(79, 23);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(181, 20);
            this.txtCpfCnpj.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cpf/Cpnj";
            // 
            // pnlNome
            // 
            this.pnlNome.Controls.Add(this.txtNome);
            this.pnlNome.Controls.Add(this.lblNome);
            this.pnlNome.Location = new System.Drawing.Point(208, 11);
            this.pnlNome.Name = "pnlNome";
            this.pnlNome.Size = new System.Drawing.Size(469, 65);
            this.pnlNome.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(44, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(370, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.BackgroundColor = System.Drawing.Color.White;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNome,
            this.colTipDoc,
            this.colCpf,
            this.colDataNasc,
            this.colTipoPessoa});
            this.dgvClient.Location = new System.Drawing.Point(3, 156);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(843, 185);
            this.dgvClient.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colTipDoc
            // 
            this.colTipDoc.HeaderText = "Tipo Documento";
            this.colTipDoc.Name = "colTipDoc";
            this.colTipDoc.ReadOnly = true;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "CPF/CNPJ";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colDataNasc
            // 
            this.colDataNasc.HeaderText = "Data nasc.";
            this.colDataNasc.Name = "colDataNasc";
            this.colDataNasc.ReadOnly = true;
            // 
            // colTipoPessoa
            // 
            this.colTipoPessoa.HeaderText = "Tipo pessoa";
            this.colTipoPessoa.Name = "colTipoPessoa";
            this.colTipoPessoa.ReadOnly = true;
            // 
            // btnHistAlt
            // 
            this.btnHistAlt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHistAlt.AutoEllipsis = true;
            this.btnHistAlt.BackColor = System.Drawing.Color.LightCyan;
            this.btnHistAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistAlt.Location = new System.Drawing.Point(684, 374);
            this.btnHistAlt.Name = "btnHistAlt";
            this.btnHistAlt.Size = new System.Drawing.Size(111, 23);
            this.btnHistAlt.TabIndex = 13;
            this.btnHistAlt.Text = "Hist. Alterações";
            this.btnHistAlt.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.AutoEllipsis = true;
            this.btnEdit.BackColor = System.Drawing.Color.LightCyan;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(164, 374);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.AutoEllipsis = true;
            this.btnPrint.BackColor = System.Drawing.Color.LightCyan;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(289, 374);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 23);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnExportXml
            // 
            this.btnExportXml.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExportXml.AutoEllipsis = true;
            this.btnExportXml.BackColor = System.Drawing.Color.LightCyan;
            this.btnExportXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportXml.Location = new System.Drawing.Point(399, 374);
            this.btnExportXml.Name = "btnExportXml";
            this.btnExportXml.Size = new System.Drawing.Size(88, 23);
            this.btnExportXml.TabIndex = 16;
            this.btnExportXml.Text = "Exportar XML";
            this.btnExportXml.UseVisualStyleBackColor = false;
            this.btnExportXml.Click += new System.EventHandler(this.btnExportXml_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExcluir.AutoEllipsis = true;
            this.btnExcluir.BackColor = System.Drawing.Color.LightCyan;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(524, 374);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 23);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmPesquisaClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(875, 409);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnExportXml);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHistAlt);
            this.Controls.Add(this.pnlFundo);
            this.Name = "frmPesquisaClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Client";
            this.Load += new System.EventHandler(this.frmPesquisaClient_Load);
            this.pnlFundo.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlDocumento.ResumeLayout(false);
            this.pnlDocumento.PerformLayout();
            this.pnlCpjCnpj.ResumeLayout(false);
            this.pnlCpjCnpj.PerformLayout();
            this.pnlNome.ResumeLayout(false);
            this.pnlNome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Panel pnlDocumento;
        private System.Windows.Forms.MaskedTextBox txtDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCpjCnpj;
        private System.Windows.Forms.MaskedTextBox txtCpfCnpj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Button btnHistAlt;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExportXml;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPessoa;
    }
}