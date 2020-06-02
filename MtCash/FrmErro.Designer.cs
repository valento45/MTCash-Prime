namespace MtCash
{
    partial class FrmErro
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
            this.txtErro = new System.Windows.Forms.RichTextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.pctErro = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctErro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.lblContato);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 142);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pctErro);
            this.panel2.Controls.Add(this.txtErro);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 96);
            this.panel2.TabIndex = 0;
            // 
            // txtErro
            // 
            this.txtErro.BackColor = System.Drawing.Color.White;
            this.txtErro.Location = new System.Drawing.Point(95, 3);
            this.txtErro.Name = "txtErro";
            this.txtErro.ReadOnly = true;
            this.txtErro.Size = new System.Drawing.Size(366, 90);
            this.txtErro.TabIndex = 0;
            this.txtErro.Text = "";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(3, 102);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(35, 13);
            this.lblContato.TabIndex = 1;
            this.lblContato.Text = "label1";
            // 
            // pctErro
            // 
            this.pctErro.BackgroundImage = global::MtCash.Properties.Resources.close;
            this.pctErro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctErro.Location = new System.Drawing.Point(3, 3);
            this.pctErro.Name = "pctErro";
            this.pctErro.Size = new System.Drawing.Size(86, 90);
            this.pctErro.TabIndex = 1;
            this.pctErro.TabStop = false;
            // 
            // FrmErro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(494, 166);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmErro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erro";
            this.Load += new System.EventHandler(this.FrmErro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctErro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtErro;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.PictureBox pctErro;
    }
}