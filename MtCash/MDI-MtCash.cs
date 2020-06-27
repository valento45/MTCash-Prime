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
using MT_u;
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
            {
                UsuarioLogado = user;
                Permissoes_Usuario();
                AjustarIcons();
                    
            }
        }

        private void AjustarIcons()
        {
            this.BackColor = Color.White;
            this.BackgroundImage = Image.FromFile(@"C:\Users\MRX\Pictures\Images\84d.jpg");
        }
        private void Permissoes_Usuario()
        {
            usuarioConfigurarToolStripMenuItem.Visible = Modulo.CanAccess(Modulos.Usuario);
            financeiroToolStripMenuItem.Visible = Modulo.CanAccess(Modulos.Financeiro);
            clienteToolStripMenuItem.Visible = Modulo.CanAccess(Modulos.Cliente);
            investimentosToolStripMenuItem.Visible = Modulo.CanAccess(Modulos.Investimento);
            estoqueToolStripMenuItem.Visible = Modulo.CanAccess(Modulos.Estoque);
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

        private void incluirToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (Modulo.CanInclude(Login.User, Modulos.Cliente))
            {
                UI.frmIncluiCliente frm = new UI.frmIncluiCliente();
                frm.MdiParent = this;
                if (frm.Visible)
                    frm.Focus();
                else
                    frm.Show();
            }
            else
                MessageBox.Show("Acesso negado! \n\r\n\rVocê não possui permissão para prosseguir!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MDI_MtCash_Load(object sender, EventArgs e)
        {

        }

        private void pesquisarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            UI.frmPesquisaClient frm = new UI.frmPesquisaClient();
            frm.MdiParent = this;

            if (frm.Visible)
                frm.Focus();
            else
                frm.Show();
        }

        private void planoDeContaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void incluirToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmIncluiDespesa frmIDespesa = new frmIncluiDespesa();
            frmIDespesa.MdiParent = this;
            if (frmIDespesa.Visible)
                frmIDespesa.Focus();
            else
                frmIDespesa.Show();
        }
    }
}
