using MTBE_u.Gateway;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtCash
{
    public partial class FrmErro : Form
    {
        Exception Ex;
        string Obs;
        public FrmErro(Exception ex, string observacoes)
        {
            InitializeComponent();
            Ex = ex;
            Obs = observacoes;
            txtErro.Text = "Ocorreu um erro inesperado! \r\n\r" + ex.Message + "\n\r" + Obs;
            lblContato.Text = "Por favor entre em contato com nosso suporte através do número (11)96610-2618";
        }

        private void FrmErro_Load(object sender, EventArgs e)
        {

        }
        public static void Exception_(Exception ex, string parametro)
        {
            NetworkLog.Insert(ex, parametro);
            FrmErro erro = new FrmErro(ex, parametro);
            erro.ShowDialog();
        }
    }
}
