namespace Aux_Mt
{
    partial class Printer
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
            this.txtcontrol = new TXTextControl.TextControl();
            this.SuspendLayout();
            // 
            // txtcontrol
            // 
            this.txtcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcontrol.Font = new System.Drawing.Font("Arial", 10F);
            this.txtcontrol.Location = new System.Drawing.Point(0, 0);
            this.txtcontrol.Name = "txtcontrol";
            this.txtcontrol.PageMargins.Bottom = 78.75D;
            this.txtcontrol.PageMargins.Left = 78.75D;
            this.txtcontrol.PageMargins.Right = 78.75D;
            this.txtcontrol.PageMargins.Top = 78.75D;
            this.txtcontrol.PageSize.Height = 1169.31D;
            this.txtcontrol.PageSize.Width = 826.81D;
            this.txtcontrol.Size = new System.Drawing.Size(768, 351);
            this.txtcontrol.TabIndex = 5;
            this.txtcontrol.Text = "textControl1";
            this.txtcontrol.UserNames = null;
            // 
            // Printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 351);
            this.Controls.Add(this.txtcontrol);
            this.Name = "Printer";
            this.Text = "Printer";
            this.ResumeLayout(false);

        }

        #endregion
        private TXTextControl.TextControl txtcontrol;
    }
}