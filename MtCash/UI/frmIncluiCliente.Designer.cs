﻿namespace MtCash.UI
{
    partial class frmIncluiCliente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRegistro = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabEndereco = new System.Windows.Forms.TabPage();
            this.btnAddEnd = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComplemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabContato = new System.Windows.Forms.TabPage();
            this.btnAddContato = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcao = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageRegistro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.tabContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageRegistro);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRegistro
            // 
            this.tabPageRegistro.Controls.Add(this.panel1);
            this.tabPageRegistro.Controls.Add(this.cmbTipoPessoa);
            this.tabPageRegistro.Controls.Add(this.label6);
            this.tabPageRegistro.Controls.Add(this.txtDataNasc);
            this.tabPageRegistro.Controls.Add(this.label5);
            this.tabPageRegistro.Controls.Add(this.txtCpf);
            this.tabPageRegistro.Controls.Add(this.label4);
            this.tabPageRegistro.Controls.Add(this.txtDocumento);
            this.tabPageRegistro.Controls.Add(this.label3);
            this.tabPageRegistro.Controls.Add(this.cmbTipoDocumento);
            this.tabPageRegistro.Controls.Add(this.label2);
            this.tabPageRegistro.Controls.Add(this.txtNome);
            this.tabPageRegistro.Controls.Add(this.label1);
            this.tabPageRegistro.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegistro.Name = "tabPageRegistro";
            this.tabPageRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistro.Size = new System.Drawing.Size(821, 366);
            this.tabPageRegistro.TabIndex = 0;
            this.tabPageRegistro.Text = "Registro";
            this.tabPageRegistro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Location = new System.Drawing.Point(6, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 224);
            this.panel1.TabIndex = 12;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabEndereco);
            this.tabControl2.Controls.Add(this.tabContato);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(803, 218);
            this.tabControl2.TabIndex = 0;
            // 
            // tabEndereco
            // 
            this.tabEndereco.Controls.Add(this.button1);
            this.tabEndereco.Controls.Add(this.btnAddEnd);
            this.tabEndereco.Controls.Add(this.txtCidade);
            this.tabEndereco.Controls.Add(this.label11);
            this.tabEndereco.Controls.Add(this.txtUf);
            this.tabEndereco.Controls.Add(this.label10);
            this.tabEndereco.Controls.Add(this.txtComplemento);
            this.tabEndereco.Controls.Add(this.label9);
            this.tabEndereco.Controls.Add(this.txtNumero);
            this.tabEndereco.Controls.Add(this.label8);
            this.tabEndereco.Controls.Add(this.txtEndereco);
            this.tabEndereco.Controls.Add(this.label7);
            this.tabEndereco.Controls.Add(this.dgvEndereco);
            this.tabEndereco.Location = new System.Drawing.Point(4, 22);
            this.tabEndereco.Name = "tabEndereco";
            this.tabEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tabEndereco.Size = new System.Drawing.Size(795, 192);
            this.tabEndereco.TabIndex = 0;
            this.tabEndereco.Text = "Endereço";
            this.tabEndereco.UseVisualStyleBackColor = true;
            // 
            // btnAddEnd
            // 
            this.btnAddEnd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddEnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddEnd.Location = new System.Drawing.Point(701, 37);
            this.btnAddEnd.Name = "btnAddEnd";
            this.btnAddEnd.Size = new System.Drawing.Size(88, 23);
            this.btnAddEnd.TabIndex = 12;
            this.btnAddEnd.Text = "Adicionar";
            this.btnAddEnd.UseVisualStyleBackColor = false;
            this.btnAddEnd.Click += new System.EventHandler(this.btnAddEnd_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.FormattingEnabled = true;
            this.txtCidade.Location = new System.Drawing.Point(152, 32);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(263, 21);
            this.txtCidade.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cidade";
            // 
            // txtUf
            // 
            this.txtUf.FormattingEnabled = true;
            this.txtUf.Location = new System.Drawing.Point(59, 32);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(43, 21);
            this.txtUf.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "UF";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(564, 6);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(225, 20);
            this.txtComplemento.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Complemento";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(446, 6);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(41, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nº";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(59, 6);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(356, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Endereço";
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.AllowUserToAddRows = false;
            this.dgvEndereco.AllowUserToDeleteRows = false;
            this.dgvEndereco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEndereco,
            this.colNumero,
            this.colComplemento,
            this.colUF,
            this.colCidade});
            this.dgvEndereco.Location = new System.Drawing.Point(6, 66);
            this.dgvEndereco.MultiSelect = false;
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEndereco.Size = new System.Drawing.Size(783, 120);
            this.dgvEndereco.TabIndex = 0;
            // 
            // colEndereco
            // 
            this.colEndereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Número";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 69;
            // 
            // colComplemento
            // 
            this.colComplemento.HeaderText = "Complemento";
            this.colComplemento.Name = "colComplemento";
            this.colComplemento.ReadOnly = true;
            this.colComplemento.Width = 96;
            // 
            // colUF
            // 
            this.colUF.HeaderText = "UF";
            this.colUF.Name = "colUF";
            this.colUF.ReadOnly = true;
            this.colUF.Width = 46;
            // 
            // colCidade
            // 
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            this.colCidade.Width = 65;
            // 
            // tabContato
            // 
            this.tabContato.Controls.Add(this.button2);
            this.tabContato.Controls.Add(this.btnAddContato);
            this.tabContato.Controls.Add(this.txtTelefone);
            this.tabContato.Controls.Add(this.label13);
            this.tabContato.Controls.Add(this.dgvContato);
            this.tabContato.Controls.Add(this.txtEmail);
            this.tabContato.Controls.Add(this.label12);
            this.tabContato.Location = new System.Drawing.Point(4, 22);
            this.tabContato.Name = "tabContato";
            this.tabContato.Padding = new System.Windows.Forms.Padding(3);
            this.tabContato.Size = new System.Drawing.Size(795, 192);
            this.tabContato.TabIndex = 1;
            this.tabContato.Text = "Contato";
            this.tabContato.UseVisualStyleBackColor = true;
            // 
            // btnAddContato
            // 
            this.btnAddContato.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddContato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddContato.Location = new System.Drawing.Point(592, 37);
            this.btnAddContato.Name = "btnAddContato";
            this.btnAddContato.Size = new System.Drawing.Size(88, 23);
            this.btnAddContato.TabIndex = 13;
            this.btnAddContato.Text = "Adicionar";
            this.btnAddContato.UseVisualStyleBackColor = false;
            this.btnAddContato.Click += new System.EventHandler(this.btnAddContato_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(504, 6);
            this.txtTelefone.Mask = "(00)00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(176, 20);
            this.txtTelefone.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(449, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Telefone";
            // 
            // dgvContato
            // 
            this.dgvContato.AllowUserToAddRows = false;
            this.dgvContato.AllowUserToDeleteRows = false;
            this.dgvContato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmail,
            this.colTelefone});
            this.dgvContato.Location = new System.Drawing.Point(6, 66);
            this.dgvContato.Name = "dgvContato";
            this.dgvContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContato.Size = new System.Drawing.Size(783, 120);
            this.dgvContato.TabIndex = 6;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colTelefone
            // 
            this.colTelefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.Width = 74;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(59, 7);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(384, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Email";
            // 
            // cmbTipoPessoa
            // 
            this.cmbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPessoa.FormattingEnabled = true;
            this.cmbTipoPessoa.Items.AddRange(new object[] {
            "Fisíca",
            "Jurídica"});
            this.cmbTipoPessoa.Location = new System.Drawing.Point(358, 83);
            this.cmbTipoPessoa.Name = "cmbTipoPessoa";
            this.cmbTipoPessoa.Size = new System.Drawing.Size(155, 21);
            this.cmbTipoPessoa.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo Pessoa";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(110, 83);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(163, 20);
            this.txtDataNasc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data Nasc.";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(593, 56);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(149, 20);
            this.txtCpf.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF/CNPJ";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(358, 56);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(155, 20);
            this.txtDocumento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(110, 56);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(163, 21);
            this.cmbTipoDocumento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Documento";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(110, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(632, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnAcao
            // 
            this.btnAcao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAcao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAcao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcao.Location = new System.Drawing.Point(310, 410);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(88, 23);
            this.btnAcao.TabIndex = 13;
            this.btnAcao.Text = "Incluir";
            this.btnAcao.UseVisualStyleBackColor = false;
            this.btnAcao.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNovo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNovo.Location = new System.Drawing.Point(92, 410);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(88, 23);
            this.btnNovo.TabIndex = 15;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(607, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(498, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmIncluiCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(853, 443);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAcao);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmIncluiCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIncluiCliente";
            this.Load += new System.EventHandler(this.frmIncluiCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRegistro.ResumeLayout(false);
            this.tabPageRegistro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabEndereco.ResumeLayout(false);
            this.tabEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.tabContato.ResumeLayout(false);
            this.tabContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRegistro;
        private System.Windows.Forms.ComboBox cmbTipoPessoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabEndereco;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.TabPage tabContato;
        private System.Windows.Forms.Button btnAddEnd;
        private System.Windows.Forms.ComboBox txtCidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtUf;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddContato;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}