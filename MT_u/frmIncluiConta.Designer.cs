namespace MT_u
{
    partial class frmIncluiConta
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.rdbPendente = new System.Windows.Forms.RadioButton();
            this.rdbPaga = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlPeriodo = new System.Windows.Forms.Panel();
            this.txtAte = new System.Windows.Forms.MaskedTextBox();
            this.txtDe = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbEspecificarPeriodo = new System.Windows.Forms.RadioButton();
            this.rdbUnico = new System.Windows.Forms.RadioButton();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.txtDataVenc = new System.Windows.Forms.MaskedTextBox();
            this.btAcao = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btEnviarEmail = new System.Windows.Forms.Button();
            this.grpStatus.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlPeriodo.SuspendLayout();
            this.pnlFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(20, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Despesa";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(75, 11);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(412, 20);
            this.txtDespesa.TabIndex = 1;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(222, 37);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(98, 20);
            this.txtValor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data venc.";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(385, 37);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(102, 20);
            this.txtDesconto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Desconto";
            // 
            // grpStatus
            // 
            this.grpStatus.Controls.Add(this.rdbPendente);
            this.grpStatus.Controls.Add(this.rdbPaga);
            this.grpStatus.Location = new System.Drawing.Point(50, 63);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(113, 69);
            this.grpStatus.TabIndex = 8;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status pgto.";
            // 
            // rdbPendente
            // 
            this.rdbPendente.AutoSize = true;
            this.rdbPendente.Location = new System.Drawing.Point(6, 42);
            this.rdbPendente.Name = "rdbPendente";
            this.rdbPendente.Size = new System.Drawing.Size(71, 17);
            this.rdbPendente.TabIndex = 6;
            this.rdbPendente.TabStop = true;
            this.rdbPendente.Text = "Pendente";
            this.rdbPendente.UseVisualStyleBackColor = true;
            // 
            // rdbPaga
            // 
            this.rdbPaga.AutoSize = true;
            this.rdbPaga.Location = new System.Drawing.Point(6, 19);
            this.rdbPaga.Name = "rdbPaga";
            this.rdbPaga.Size = new System.Drawing.Size(50, 17);
            this.rdbPaga.TabIndex = 5;
            this.rdbPaga.TabStop = true;
            this.rdbPaga.Text = "Paga";
            this.rdbPaga.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlPeriodo);
            this.groupBox2.Controls.Add(this.rdbEspecificarPeriodo);
            this.groupBox2.Controls.Add(this.rdbUnico);
            this.groupBox2.Location = new System.Drawing.Point(171, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 69);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Período a receber";
            // 
            // pnlPeriodo
            // 
            this.pnlPeriodo.Controls.Add(this.txtAte);
            this.pnlPeriodo.Controls.Add(this.txtDe);
            this.pnlPeriodo.Controls.Add(this.label6);
            this.pnlPeriodo.Controls.Add(this.label5);
            this.pnlPeriodo.Location = new System.Drawing.Point(83, 11);
            this.pnlPeriodo.Name = "pnlPeriodo";
            this.pnlPeriodo.Size = new System.Drawing.Size(229, 54);
            this.pnlPeriodo.TabIndex = 3;
            this.pnlPeriodo.Visible = false;
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(33, 28);
            this.txtAte.Mask = "00/00/0000";
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(100, 20);
            this.txtAte.TabIndex = 10;
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(33, 5);
            this.txtDe.Mask = "00/00/0000";
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(100, 20);
            this.txtDe.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Até";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "De";
            // 
            // rdbEspecificarPeriodo
            // 
            this.rdbEspecificarPeriodo.AutoSize = true;
            this.rdbEspecificarPeriodo.Location = new System.Drawing.Point(6, 42);
            this.rdbEspecificarPeriodo.Name = "rdbEspecificarPeriodo";
            this.rdbEspecificarPeriodo.Size = new System.Drawing.Size(77, 17);
            this.rdbEspecificarPeriodo.TabIndex = 8;
            this.rdbEspecificarPeriodo.Text = "Especificar";
            this.rdbEspecificarPeriodo.UseVisualStyleBackColor = true;
            this.rdbEspecificarPeriodo.CheckedChanged += new System.EventHandler(this.rdbEspecificarPeriodo_CheckedChanged);
            // 
            // rdbUnico
            // 
            this.rdbUnico.AutoSize = true;
            this.rdbUnico.Checked = true;
            this.rdbUnico.Location = new System.Drawing.Point(6, 19);
            this.rdbUnico.Name = "rdbUnico";
            this.rdbUnico.Size = new System.Drawing.Size(53, 17);
            this.rdbUnico.TabIndex = 7;
            this.rdbUnico.TabStop = true;
            this.rdbUnico.Text = "Único";
            this.rdbUnico.UseVisualStyleBackColor = true;
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFundo.Controls.Add(this.lblTitulo);
            this.pnlFundo.Controls.Add(this.groupBox2);
            this.pnlFundo.Controls.Add(this.txtDespesa);
            this.pnlFundo.Controls.Add(this.grpStatus);
            this.pnlFundo.Controls.Add(this.label2);
            this.pnlFundo.Controls.Add(this.txtDesconto);
            this.pnlFundo.Controls.Add(this.txtValor);
            this.pnlFundo.Controls.Add(this.label4);
            this.pnlFundo.Controls.Add(this.label3);
            this.pnlFundo.Controls.Add(this.txtDataVenc);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(501, 175);
            this.pnlFundo.TabIndex = 10;
            // 
            // txtDataVenc
            // 
            this.txtDataVenc.Location = new System.Drawing.Point(75, 37);
            this.txtDataVenc.Mask = "00/00/0000";
            this.txtDataVenc.Name = "txtDataVenc";
            this.txtDataVenc.Size = new System.Drawing.Size(100, 20);
            this.txtDataVenc.TabIndex = 2;
            // 
            // btAcao
            // 
            this.btAcao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btAcao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcao.Location = new System.Drawing.Point(153, 193);
            this.btAcao.Name = "btAcao";
            this.btAcao.Size = new System.Drawing.Size(75, 23);
            this.btAcao.TabIndex = 11;
            this.btAcao.Text = "Incluir";
            this.btAcao.UseVisualStyleBackColor = false;
            this.btAcao.Click += new System.EventHandler(this.btAcao_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btImprimir.Location = new System.Drawing.Point(234, 193);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(75, 23);
            this.btImprimir.TabIndex = 12;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btEnviarEmail
            // 
            this.btEnviarEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btEnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnviarEmail.Location = new System.Drawing.Point(315, 193);
            this.btEnviarEmail.Name = "btEnviarEmail";
            this.btEnviarEmail.Size = new System.Drawing.Size(75, 23);
            this.btEnviarEmail.TabIndex = 13;
            this.btEnviarEmail.Text = "Enviar email";
            this.btEnviarEmail.UseVisualStyleBackColor = false;
            // 
            // frmIncluiConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(524, 220);
            this.Controls.Add(this.btEnviarEmail);
            this.Controls.Add(this.pnlFundo);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btAcao);
            this.MaximizeBox = false;
            this.Name = "frmIncluiConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir Despesa";
            this.Shown += new System.EventHandler(this.frmIncluiDespesa_Shown);
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlPeriodo.ResumeLayout(false);
            this.pnlPeriodo.PerformLayout();
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton rdbPendente;
        private System.Windows.Forms.RadioButton rdbPaga;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbEspecificarPeriodo;
        private System.Windows.Forms.RadioButton rdbUnico;
        private System.Windows.Forms.Panel pnlPeriodo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtAte;
        private System.Windows.Forms.MaskedTextBox txtDe;
        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Button btAcao;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btEnviarEmail;
        private System.Windows.Forms.MaskedTextBox txtDataVenc;
    }
}