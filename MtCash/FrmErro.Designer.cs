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
            this.lblContato = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pctErro = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctErro)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.lblContato);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 132);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pctErro);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 96);
            this.panel2.TabIndex = 0;
            // 
            // pctErro
            // 
            this.pctErro.BackgroundImage = global::MtCash.Properties.Resources.close;
            this.pctErro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pctErro.Location = new System.Drawing.Point(12, 16);
            this.pctErro.Name = "pctErro";
            this.pctErro.Size = new System.Drawing.Size(68, 66);
            this.pctErro.TabIndex = 1;
            this.pctErro.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copiar Erro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enviar Email";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblErro);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(90, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 90);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ocorreu um erro inesperado!";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.Location = new System.Drawing.Point(5, 22);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(166, 15);
            this.lblErro.TabIndex = 1;
            this.lblErro.Text = "Ocorreu um erro inesperado!";
            // 
            // FrmErro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(494, 183);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.PictureBox pctErro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErro;
    }
}