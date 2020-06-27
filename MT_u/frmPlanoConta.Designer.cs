namespace MT_u
{
    partial class frmPlanoConta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoPlano = new System.Windows.Forms.ComboBox();
            this.btAddCategoria = new System.Windows.Forms.Button();
            this.btAddSubCategoria = new System.Windows.Forms.Button();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.btSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlCampos);
            this.panel1.Controls.Add(this.btAddSubCategoria);
            this.panel1.Controls.Add(this.btAddCategoria);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 260);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.treeView);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 254);
            this.panel2.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(194, 248);
            this.treeView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(98, 14);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(180, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // cmbTipoPlano
            // 
            this.cmbTipoPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPlano.FormattingEnabled = true;
            this.cmbTipoPlano.Items.AddRange(new object[] {
            "Receita",
            "Despesa"});
            this.cmbTipoPlano.Location = new System.Drawing.Point(98, 40);
            this.cmbTipoPlano.Name = "cmbTipoPlano";
            this.cmbTipoPlano.Size = new System.Drawing.Size(178, 21);
            this.cmbTipoPlano.TabIndex = 4;
            // 
            // btAddCategoria
            // 
            this.btAddCategoria.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAddCategoria.Location = new System.Drawing.Point(209, 231);
            this.btAddCategoria.Name = "btAddCategoria";
            this.btAddCategoria.Size = new System.Drawing.Size(134, 23);
            this.btAddCategoria.TabIndex = 5;
            this.btAddCategoria.Text = "Adicionar categoria";
            this.btAddCategoria.UseVisualStyleBackColor = true;
            this.btAddCategoria.Click += new System.EventHandler(this.btAddCategoria_Click);
            // 
            // btAddSubCategoria
            // 
            this.btAddSubCategoria.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAddSubCategoria.Location = new System.Drawing.Point(349, 231);
            this.btAddSubCategoria.Name = "btAddSubCategoria";
            this.btAddSubCategoria.Size = new System.Drawing.Size(134, 23);
            this.btAddSubCategoria.TabIndex = 6;
            this.btAddSubCategoria.Text = "Adicionar sub categoria";
            this.btAddSubCategoria.UseVisualStyleBackColor = true;
            this.btAddSubCategoria.Click += new System.EventHandler(this.btAddSubCategoria_Click);
            // 
            // pnlCampos
            // 
            this.pnlCampos.Controls.Add(this.btSalvar);
            this.pnlCampos.Controls.Add(this.cmbTipoPlano);
            this.pnlCampos.Controls.Add(this.label1);
            this.pnlCampos.Controls.Add(this.txtDescricao);
            this.pnlCampos.Controls.Add(this.label2);
            this.pnlCampos.Location = new System.Drawing.Point(207, 6);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Size = new System.Drawing.Size(378, 115);
            this.pnlCampos.TabIndex = 7;
            this.pnlCampos.Visible = false;
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSalvar.Location = new System.Drawing.Point(116, 89);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(134, 23);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // frmPlanoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 284);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmPlanoConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plano de contas";
            this.Load += new System.EventHandler(this.frmPlanoConta_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoPlano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Button btAddSubCategoria;
        private System.Windows.Forms.Button btAddCategoria;
        private System.Windows.Forms.Button btSalvar;
    }
}