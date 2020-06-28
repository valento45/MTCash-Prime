using Aux_Mt;
using MTBE_u.EntitiesCash;
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

namespace MT_u
{
    public partial class frmIncluiDespesa : frmDefault
    {
        private bool Alterar = false;
        private Despesa Despesa = null;
        string[] Periodo = null;
        public frmIncluiDespesa()
        {
            InitializeComponent();
        }

        public frmIncluiDespesa(Despesa despesa, bool alterar)
        {
            InitializeComponent();

            Despesa = despesa;
            Alterar = alterar;

            if (Despesa.Id > 0)
            {
                txtDespesa.Text = Despesa.Descricao;
                txtDataVenc.Text = Despesa.Data_Vencimento.ToString();
                txtValor.Text = Despesa.Valor.ToString();
                txtDesconto.Text = Despesa.Desconto.ToString();
                rdbEspecificarPeriodo.Checked = pnlPeriodo.Visible = Despesa.Periodo.Length > 0;
                if (pnlPeriodo.Visible)
                {
                    Periodo = Despesa.Periodo.Split(',');
                    txtDe.Text = Periodo[0];
                    txtAte.Text = Periodo[1];
                }
                if (Despesa.Status.Equals("True"))
                    rdbPaga.Checked = true;
                else
                    rdbPendente.Checked = true;

            }
        }

        private bool ValidaCampos()
        {
            string campos = "";
            if (!(txtDespesa.Text.Length > 0 && txtDataVenc.Text.Length == 10 && txtValor.Text.Length > 0 && (rdbPaga.Checked || rdbPendente.Checked)))
            {
                campos += txtDespesa.Text.Length <= 0 ? "Despesa" : "";
                campos += txtDataVenc.Text.Length < 10 ? (campos.Length > 0 ? "\n " : "") + "Data vencimento" : "";
                campos += txtValor.Text.Length <= 0 ? (campos.Length > 0 ? "\n " : "") + "Valor" : "";
                campos += !rdbPaga.Checked || !rdbPendente.Checked ? (campos.Length > 0 ? "\n " : "") + "Status pgto" : "";
                MessageBox.Show("Verifique o preenchimento dos campos: \n\r\n" + campos, "Valida Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
                try
                {
                    //se inclusao
                    if (!Alterar)
                    {
                        Despesa = new Despesa();
                        Despesa.Descricao = txtDespesa.Text.Trim();
                        Despesa.Data_Vencimento = Convert.ToDateTime(txtDataVenc.Text);
                        Despesa.Valor = Convert.ToDecimal(txtValor.Text);
                        Despesa.Desconto = txtDesconto.Text.Length > 0 ? Convert.ToDecimal(txtDesconto.Text) : 0;
                        if (rdbEspecificarPeriodo.Checked)
                        {
                            if (txtDe.Text.Length < 10 && txtAte.Text.Length < 10)
                            {
                                MessageBox.Show("Por favor especifique o período corretamente!", "Valida campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                                Despesa.Periodo = rdbEspecificarPeriodo.Checked ? txtDe.Text + ", " + txtAte.Text : "";
                        }
                        Despesa.Status = rdbPaga.Checked.ToString();

                        //Inserindo
                        if (Despesa.InsertDespesa())
                        {
                            MessageBox.Show("Dados inseridos com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparCampos();
                        }
                        else
                            MessageBox.Show("Os dados não foram salvos corretamente! Por favor, verifique.", "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //senao, alteração
                    else
                    {
                        if (Despesa != null && Despesa.Id > 0)
                        {
                            Despesa.Descricao = txtDespesa.Text.Trim();
                            Despesa.Data_Vencimento = Convert.ToDateTime(txtDataVenc.Text);
                            Despesa.Valor = Convert.ToDecimal(txtValor.Text);
                            Despesa.Desconto = txtDesconto.Text.Length > 0 ? Convert.ToDecimal(txtDesconto.Text) : 0;
                            if (rdbEspecificarPeriodo.Checked)
                            {
                                if (txtDe.Text.Length < 10 && txtAte.Text.Length < 10)
                                {
                                    MessageBox.Show("Por favor especifique o período corretamente!", "Valida campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                else
                                    Despesa.Periodo = rdbEspecificarPeriodo.Checked ? txtDe.Text + ", " + txtAte.Text : "";
                            }
                            Despesa.Status = rdbPaga.Checked.ToString();

                            //atualizando
                            if (Despesa.UpdateDespesa())
                            {
                                MessageBox.Show("Dados atualizados com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimparCampos();
                            }
                            else
                                MessageBox.Show("Os dados não foram salvos corretamente! Por favor, verifique.", "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }            
        }

        private void rdbEspecificarPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            pnlPeriodo.Visible = rdbEspecificarPeriodo.Checked;
        }
        private void LimparCampos()
        {
            Alterar = false;
            txtDespesa.Clear();
            txtDataVenc.Clear();
            txtValor.Clear();
            txtDespesa.Clear();
            txtAte.Clear();
            txtDe.Clear();
            rdbUnico.Checked = true;
            rdbPaga.Checked = false;
            rdbPendente.Checked = false;            
        }
    }
}
