using Aux_Mt;
using MTBE_u.EntitiesCash;
using MTBE_u.Gateway;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_u
{
    public partial class frmIncluiConta : frmDefault
    {
        private Conta Conta_ = null;
        private bool Alterar = false;
        private bool isReceita = false;
        string[] Periodo = null;
        List<Parcela> ParcelasList = new List<Parcela>();

        public frmIncluiConta()
        {
            InitializeComponent();
        }


        public frmIncluiConta(Conta conta, bool alterar = false)
        {
            InitializeComponent();
            Conta_ = conta;
            Alterar = alterar;

            if (Conta_ is Receita)
            {
                isReceita = true;
                this.Text = "Incluir Receita";
                this.lblTitulo.Text = "Receita";
            }
            else
            {
                isReceita = false;
                this.Text = "Incluir Despesa";
                this.lblTitulo.Text = "Despesa";
            }

            if (Conta_.Id > 0)
            {
                txtDespesa.Text = Conta_.Descricao;
                txtAte.Text = Conta_.DiaVencimento + "/" + conta.MesVencimento + "/" + conta.AnoVencimento;
                txtValor.Text = Conta_.Valor.ToString();
                txtDesconto.Text = Conta_.Desconto.ToString();
                rdbEspecificarPeriodo.Checked = pnlPeriodo.Visible = Conta_.Periodo.Length > 0;
                if (Conta_.Periodo.Length > 0)
                {
                    pnlPeriodo.Visible = true;
                    Periodo = Conta_.Periodo.Split(',');
                    txtDe.Text = Periodo[0].Trim();
                    txtAte.Text = Periodo[1].Trim();
                }
                if (Conta_.Status.Equals("True"))
                {
                    rdbPendente.Enabled = rdbPaga.Enabled = false;
                    rdbPaga.Checked = true;
                }
                else
                    rdbPendente.Checked = true;
            }

        }
        private void IsReceita()
        {
            this.Text = "Incluir Receita";
            this.lblTitulo.Text = "Receita";
            isReceita = true;
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
            Salvar();
        }
        private int TotalMeses(DateTime de, DateTime ate)
        {
            var time = ate.Subtract(de);
            double meses = time.Days / 30;
            meses = Math.Round(meses);
            return Convert.ToInt32(meses);
        }
        private void Salvar()
        {
            //FuncoesAuxiliaresAux.ColecaoAbstrataModelo();
            if (ValidaCampos())
                try
                {
                    bool periodo = false;
                    #region DESPESA
                    //se for DESPESA
                    if (!isReceita)
                    {
                        //se inclusao
                        if (!Alterar)
                        {
                            Conta_ = new Despesa();
                            Conta_.Descricao = txtDespesa.Text.Trim();
                            DateTime dtime = Convert.ToDateTime(txtDataVenc.Text);
                            Conta_.DiaVencimento = dtime.Day.ToString();
                            Conta_.MesVencimento = dtime.Month.ToString();
                            Conta_.AnoVencimento = dtime.Year.ToString();
                            Conta_.Valor = txtValor.Text.FormatMoney();
                            Conta_.Desconto = txtDesconto.Text.Length > 0 ? txtDesconto.Text.FormatMoney() : 0;
                            if (rdbEspecificarPeriodo.Checked)
                            {
                                if (txtDe.Text.Length < 10 && txtAte.Text.Length < 10)
                                {
                                    MessageBox.Show("Por favor especifique o período corretamente!", "Valida campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                Conta_.Periodo = txtDe.Text + ", " + txtAte.Text;
                                periodo = true;
                            }
                            Conta_.Status = rdbPaga.Checked.ToString();

                            //Insere
                            if (Conta_.Insert())
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
                            var obj = Conta_ as Despesa;
                            if (obj != null && obj.Id > 0)
                            {
                                obj.Descricao = txtDespesa.Text.Trim();
                                DateTime data = Convert.ToDateTime(txtAte.Text);
                                obj.DiaVencimento = data.Day.ToString();
                                obj.MesVencimento = data.Month.ToString();
                                obj.AnoVencimento = data.Year.ToString();
                                obj.Valor = txtValor.Text.FormatMoney();
                                obj.Desconto = txtDesconto.Text.Length > 0 ? txtDesconto.Text.FormatMoney() : 0;
                                if (rdbEspecificarPeriodo.Checked)
                                {
                                    if (txtDe.Text.Length < 10 && txtAte.Text.Length < 10)
                                    {
                                        MessageBox.Show("Por favor especifique o período corretamente!", "Valida campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                    obj.Periodo = txtDe.Text + ", " + txtAte.Text;
                                    periodo = true;
                                }
                                obj.Status = rdbPaga.Checked.ToString();

                                //atualizando
                                if (obj.Update())
                                {
                                    MessageBox.Show("Dados atualizados com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    MessageBox.Show("Os dados não foram salvos corretamente! Por favor, verifique.", "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    #endregion

                    #region RECEITA
                    //se receita
                    else
                    {
                        //se inclusao
                        if (!Alterar)
                        {
                            Conta_ = new Receita();
                            Conta_.Descricao = txtDespesa.Text.Trim();
                            DateTime data = Convert.ToDateTime(txtDataVenc.Text);
                            Conta_.DiaVencimento = data.Day.ToString();
                            Conta_.MesVencimento = data.Month.ToString();
                            Conta_.AnoVencimento = data.Year.ToString();
                            Conta_.Valor = txtValor.Text.FormatMoney();
                            Conta_.Desconto = txtDesconto.Text.Length > 0 ? txtDesconto.Text.FormatMoney() : 0;
                            if (rdbEspecificarPeriodo.Checked)
                            {
                                if (txtDe.Text.Length < 10 && txtAte.Text.Length < 10)
                                {
                                    MessageBox.Show("Por favor especifique o período corretamente!", "Valida campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                Conta_.Periodo = txtDe.Text + ", " + txtAte.Text;
                                periodo = true;
                            }
                            Conta_.Status = rdbPaga.Checked.ToString();

                            //Insere
                            if (Conta_.Insert())
                            {
                                if (periodo)
                                {
                                    int totalMeses = TotalMeses(DateTime.Parse(txtDe.Text), DateTime.Parse(txtAte.Text));
                                    DateTime date = (Convert.ToDateTime(txtDe.Text));
                                    for (int i = 0; i < totalMeses; i++)
                                    {
                                        Parcela parcela = new Parcela();
                                        parcela.Id_receita = Conta_.Id;
                                        parcela.Numero_parcela = i + 1;
                                        parcela.Total_parcelas = totalMeses;
                                        parcela.Valor_parcela = Conta_.Valor;
                                        parcela.Data_vencimento = date;
                                        parcela.Desconto = txtDesconto.Text.Trim().Length > 0 ? txtDesconto.Text.FormatMoney() : 0;
                                        parcela.Quitada = false;
                                        parcela.Insert();
                                        date = date.AddMonths(1);
                                        ParcelasList.Add(parcela);
                                    }
                                }
                                MessageBox.Show("Dados inseridos com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimparCampos();
                            }
                            else
                                MessageBox.Show("Os dados não foram salvos corretamente! Por favor, verifique.", "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        //senao, alteração
                        else
                        {
                            var obj = Conta_ as Receita;
                            if (obj != null && obj.Id > 0)
                            {
                                obj.Descricao = txtDespesa.Text.Trim();
                                DateTime data = Convert.ToDateTime(txtAte.Text);
                                obj.DiaVencimento = data.Day.ToString();
                                obj.MesVencimento = data.Month.ToString();
                                obj.AnoVencimento = data.Year.ToString();
                                obj.Valor = txtValor.Text.FormatMoney();
                                obj.Desconto = txtDesconto.Text.Length > 0 ? txtDesconto.Text.FormatMoney() : 0;
                                if (rdbEspecificarPeriodo.Checked)
                                {
                                    if (txtDe.Text.Length < 10 && txtAte.Text.Length < 10)
                                    {
                                        MessageBox.Show("Por favor especifique o período corretamente!", "Valida campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }

                                    obj.Periodo = txtDe.Text + ", " + txtAte.Text;
                                }
                                obj.Status = rdbPaga.Checked.ToString();

                                //altera
                                if (obj.Update())
                                {
                                    MessageBox.Show("Dados atualizados com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    MessageBox.Show("Os dados não foram salvos corretamente! Por favor, verifique.", "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    #endregion

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

        private void AjustarBotoes()
        {
            if (Alterar)
                btAcao.Text = "Alterar";
            else
                btAcao.Text = "Incluir";
        }

        private void frmIncluiDespesa_Shown(object sender, EventArgs e)
        {
            AjustarBotoes();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            //Printer printer = new Printer();
            //printer.ShowDialog();
            if (Conta_ != null && Conta_.Id > 0)
            {
                if (Conta_ is Despesa)
                {
                    PrintService<Despesa> printService = new PrintService<Despesa>();
                    printService.Print(Conta_ as Despesa);
                }
                else if (Conta_ is Receita)
                {
                    PrintService<Receita> printService = new PrintService<Receita>();
                    printService.Print(Conta_ as Receita);
                }
            }
        }
    }
}
