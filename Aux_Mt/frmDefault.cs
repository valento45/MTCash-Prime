using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aux_Mt
{
    public partial class frmDefault : Form
    {
        public frmDefault()
        {
            InitializeComponent();
        }

        private void AjustarBotoes(Form frm)
        {
            //Form.ControlCollection controls = new ControlCollection(frm);
            //foreach(var control in controls.Owner.Controls)
            //{
            //    if(control is TextBox)
            //    {
            //        ((TextBox)control).BackColor = Color.MidnightBlue;

            //    }
            //}

        }

        private void GetAllControls(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).BackColor = Color.MidnightBlue;
                }
                else if (c is TextBox)
                {
                    ((TextBox)c).Font = new Font("Arial", 9, FontStyle.Regular);
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Font = new Font("Arial", 9, FontStyle.Regular);
                }
                else if (c is DataGridView)
                {
                    ((DataGridView)c).BackgroundColor = Color.White;
                }
                else
                    for (int i = 0; i < c.Controls.Count; i++)
                    {
                        GetAllControls(c.Controls[i]);
                    }
            }
        }
        private void frmDefault_Load(object sender, EventArgs e)
        {
            GetAllControls(this);
        }
    }
}
