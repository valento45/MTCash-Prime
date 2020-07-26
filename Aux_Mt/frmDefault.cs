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

        private void GetAllControls(Control container)
        {
            #region OLD
            //foreach (Control c in container.Controls)
            //{
            //    if (c is Button)
            //    {
            //        ((Button)c).BackColor = Color.MidnightBlue;
            //    }
            //    else if (c is TextBox)
            //    {
            //        ((TextBox)c).Font = new Font("Arial", 9, FontStyle.Regular);
            //    }
            //    else if (c is MaskedTextBox)
            //    {
            //        ((MaskedTextBox)c).Font = new Font("Arial", 9, FontStyle.Regular);
            //    }
            //    else if (c is DataGridView)
            //    {
            //        ((DataGridView)c).BackgroundColor = Color.White;
            //    }
            //    else
            //        for (int i = 0; i < c.Controls.Count; i++)
            //        {
            //            GetAllControls(c.Controls[i]);
            //        }
            //}
            #endregion

            AplicarThemes(container);
            for (int i = 0; i < container.Controls.Count; i++)
            {
                GetAllControls(container.Controls[i]);
            }
        }

        private void AplicarThemes(Control container)
        {
            if (container is Button)
            {
                ((Button)container).BackColor = Color.White;
            }
            else if (container is TextBox)
            {
                ((TextBox)container).Font = new Font("Arial", 9, FontStyle.Regular);
            }
            else if (container is MaskedTextBox)
            {
                ((MaskedTextBox)container).Font = new Font("Arial", 9, FontStyle.Regular);
            }
            else if (container is DataGridView)
            {
                ((DataGridView)container).BackgroundColor = Color.White;
            }
        }

        private void frmDefault_Load(object sender, EventArgs e)
        {
            GetAllControls(this);
            
        }
    }
}
