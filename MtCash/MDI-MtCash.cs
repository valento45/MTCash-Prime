using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aux_Mt;
using MT_u;
using MT_u.Usuario;
using MTBE_u;
using MTBE_u.Entities;
using MTBE_u.Entities.Enums;
using MTBE_u.EntitiesCash;
using MtCash.BusinessEntities;

namespace MtCash
{
    public partial class MDI_MtCash : Form
    {
        private System.Threading.Timer EmitirAlertaContas;
        Usuario UsuarioLogado;
        public MDI_MtCash(Usuario user)
        {
            InitializeComponent();

            if (user != null && user.Id_Pessoa > 0)
            {
                UsuarioLogado = user;
                Permissoes_Usuario();
                AjustarIcons();
                //FuncoesAuxiliares.IOCreateLogAcesso(Login.User._Usuario);
            }
        }

        private void AjustarIcons()
        {
            this.BackColor = Color.White;
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
                frmIncluiConta frm = new frmIncluiConta(new MTBE_u.EntitiesCash.Receita());
                frm.MdiParent = this;
                if (frm.Visible)
                    frm.Focus();
                else
                    frm.Show();
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
           // Thread thread = new Thread(_ => ThreadStart)
        }


        private void IniciarAlertaContas()
        {
            EmitirAlertaContas = new System.Threading.Timer(_ => EmiteAlertaContas(), null, 0, 1000);
        }

        private void EmiteAlertaContas()
        {
            List<Despesa> despesas = new List<Despesa>();

            despesas = Despesa.GetDespesas(true).Where(x => x.DiaVencimento.StringToInt() + 7 <= DateTime.Now.Day).ToList();
            if (despesas.Count > 0)
            {
                this.Invoke(new Action(() =>
                    {
                        lbtitAvisoContas.Text = "ATENÇÃO. Verificar as despesas próximas do vencimento.";
                        lbMessageAvisoContas.Text = "Existem contas vencidas ou próximas do vencimento.\r\n\r\n";
                        foreach (var item in despesas)
                        {
                            lbMessageAvisoContas.Text += "Conta: " + item.Descricao + " Vencimento: " + $"{item.DiaVencimento}/{item.MesVencimento}/{item.AnoVencimento}" + " Valor: " + decimal.Round(item.Valor);
                        }

                        btnCloseAvisoEstoqueMin.Click += btnCloseAvisoEstoqueMin_Click;
                        pnlAlertaAvisoContas.Visible = true;
                    }));
            }

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
            frmIncluiConta frmIDespesa = new frmIncluiConta(new Despesa());
            frmIDespesa.MdiParent = this;
            if (frmIDespesa.Visible)
                frmIDespesa.Focus();
            else
                frmIDespesa.Show();
        }

        private void pesquisarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmPesqConta pesqDespesa = new frmPesqConta("Despesa");
            pesqDespesa.MdiParent = this;
            if (pesqDespesa.Visible)
                pesqDespesa.Focus();
            else
                pesqDespesa.Show();
        }

        private void logDeAcessosEmTelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncoesAuxiliares.ImprimeLogAcessoFinanceiro(DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void pesquisarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPesqConta s = new frmPesqConta("Receita");
            s.ShowDialog();
        }

        private void gráficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Modulo.CanAccess(Modulos.Financeiro)))
            {
                MessageBox.Show("Você não possui permissão para prosseguir!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmRelatorioGrafico frmGrafic = new frmRelatorioGrafico();
            frmGrafic.ShowDialog();
        }

        private void btnCloseAvisoEstoqueMin_Click(object sender, EventArgs e)
        {
            pnlAlertaAvisoContas.Visible = false;
        }

        private void MDI_MtCash_Shown(object sender, EventArgs e)
        {
            IniciarAlertaContas();
        }
    }
}
