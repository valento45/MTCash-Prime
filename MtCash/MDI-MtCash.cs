using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MT_u.Usuario;
using MTBE_u;
using MTBE_u.Entities;
using MTBE_u.Entities.Enums;

namespace MtCash
{
    public partial class MDI_MtCash : Form
    {
        Usuario UsuarioLogado;
        public MDI_MtCash(Usuario user)
        {
            InitializeComponent();

            if (user.Id_Pessoa > 0)
                UsuarioLogado = user;

            Permissoes_Usuario();
        }
        private void Permissoes_Usuario()
        {
            usuarioConfigurarToolStripMenuItem.Visible = Modulo.CanAccess(Modulos.Usuario);
        }

        private void ordemServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void incluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Modulo.CanInclude(Login.User, Modulos.Investimento))
            {

            }
            else
            {
                MessageBox.Show("\n\rAcesso negado! \n\r\n\r\n\rVocê não possui permissão para prosseguir!", "Acesso negado" +
                       "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void incluirToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Modulo.CanInclude(Login.User, Modulos.Financeiro))
            {

            }
            else
            {
                MessageBox.Show("\n\rAcesso negado! \n\r\n\r\n\rVocê não possui permissão para prosseguir!", "Acesso negado" +
                       "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void incluirAlterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigurarU frm = new frmConfigurarU(Login.User);
            if (frm.Visible)
                frm.Focus();
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
