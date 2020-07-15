﻿using Aux_Mt;
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
    public partial class frmIncluiDespesa : frmDefault
    {
        private Conta Conta_ = null;
        private bool Alterar = false;
        private bool Receita = false;

        string[] Periodo = null;


        public frmIncluiDespesa()
        {
            InitializeComponent();
        }

        
        public frmIncluiDespesa(Conta conta, bool alterar = false)
        {
            InitializeComponent();
            Conta_ = conta;
            Alterar = alterar;

            if (Conta_ is Receita)
            {
                this.Text = "Incluir Receita";
                this.lblTitulo.Text = "Receita";
                Receita = true;
            }
            else
            {
                Receita = false;
                this.Text = "Incluir Despesa";
                this.lblTitulo.Text = "Despesa";
            }

            if (Conta_.Id > 0)
            {
                txtDespesa.Text = Conta_.Descricao;
                txtDataVenc.Text = Conta_.Data_Vencimento.ToString();
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


        //public frmIncluiDespesa(Despesa despesa, bool alterar)
        //{
        //    InitializeComponent();

        //    Conta_ = despesa;
        //    Alterar = alterar;

        //    if (Conta_.Id > 0)
        //    {
        //        txtDespesa.Text = Conta_.Descricao;
        //        txtDataVenc.Text = Conta_.Data_Vencimento.ToString();
        //        txtValor.Text = Conta_.Valor.ToString();
        //        txtDesconto.Text = Conta_.Desconto.ToString();
        //        rdbEspecificarPeriodo.Checked = pnlPeriodo.Visible = Conta_.Periodo.Length > 0;
        //        if (Conta_.Periodo.Length > 0)
        //        {
        //            pnlPeriodo.Visible = true;
        //            Periodo = Conta_.Periodo.Split(',');
        //            txtDe.Text = Periodo[0];
        //            txtAte.Text = Periodo[1];
        //        }
        //        if (Conta_.Status.Equals("True"))
        //        {
        //            rdbPendente.Enabled = rdbPaga.Enabled = false;
        //            rdbPaga.Checked = true;
        //        }
        //        else
        //            rdbPendente.Checked = true;
        //    }
        //}

        private void IsReceita()
        {
            this.Text = "Incluir Receita";
            this.lblTitulo.Text = "Receita";
            Receita = true;
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
            if (!Receita)
                SalvarDespesa();
            else
                SalvarReceita();
        }

        private void SalvarReceita()
        {
            if (ValidaCampos())
                try
                {
                    //se inclusao
                    if (!Alterar)
                    {
                        Conta_ = new Receita();
                        Conta_.Descricao = txtDespesa.Text.Trim();
                        Conta_.Data_Vencimento = Convert.ToDateTime(txtDataVenc.Text);
                        Conta_.Valor = txtValor.Text.FormatMoney();
                        Conta_.Desconto = txtDesconto.Text.Length > 0 ? txtDesconto.Text.FormatMoney() : 0;
                        if (rdbEspecificarPeriodo.Checked)
                        {
                            if (txtDe.Text.Length < 10 && txtAte.Text.Length < 10)
                            {
                                MessageBox.Show("Por favor especifique o período corretamente!", "Valida campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                                Conta_.Periodo = rdbEspecificarPeriodo.Checked ? txtDe.Text + ", " + txtAte.Text : "";
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
                        var obj = Conta_ as Receita;
                        if (obj != null && obj.Id > 0)
                        {
                            obj.Descricao = txtDespesa.Text.Trim();
                            obj.Data_Vencimento = Convert.ToDateTime(txtDataVenc.Text);
                            obj.Valor = txtValor.Text.FormatMoney();
                            obj.Desconto = txtDesconto.Text.Length > 0 ? txtDesconto.Text.FormatMoney() : 0;
                            if (rdbEspecificarPeriodo.Checked)
                            {
                                if (txtDe.Text.Length < 10 && txtAte.Text.Length < 10)
                                {
                                    MessageBox.Show("Por favor especifique o período corretamente!", "Valida campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                else
                                    obj.Periodo = rdbEspecificarPeriodo.Checked ? txtDe.Text + ", " + txtAte.Text : "";
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
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

        }

        private void SalvarDespesa()
        {
            //FuncoesAuxiliaresAux.ColecaoAbstrataModelo();
            if (ValidaCampos())
                try
                {
                    //se inclusao
                    if (!Alterar)
                    {
                        Conta_ = new Despesa();
                        Conta_.Descricao = txtDespesa.Text.Trim();
                        Conta_.Data_Vencimento = Convert.ToDateTime(txtDataVenc.Text);
                        Conta_.Valor = txtValor.Text.FormatMoney();
                        Conta_.Desconto = txtDesconto.Text.Length > 0 ? txtDesconto.Text.FormatMoney() : 0;
                        if (rdbEspecificarPeriodo.Checked)
                        {
                            if (txtDe.Text.Length < 10 && txtAte.Text.Length < 10)
                            {
                                MessageBox.Show("Por favor especifique o período corretamente!", "Valida campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                                Conta_.Periodo = rdbEspecificarPeriodo.Checked ? txtDe.Text + ", " + txtAte.Text : "";
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
                            obj.Data_Vencimento = Convert.ToDateTime(txtDataVenc.Text);
                            obj.Valor = txtValor.Text.FormatMoney();
                            obj.Desconto = txtDesconto.Text.Length > 0 ? txtDesconto.Text.FormatMoney() : 0;
                            if (rdbEspecificarPeriodo.Checked)
                            {
                                if (txtDe.Text.Length < 10 && txtAte.Text.Length < 10)
                                {
                                    MessageBox.Show("Por favor especifique o período corretamente!", "Valida campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                else
                                    obj.Periodo = rdbEspecificarPeriodo.Checked ? txtDe.Text + ", " + txtAte.Text : "";
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
            if (Conta_ != null)
            {
                PrintService<Despesa> printService = new PrintService<Despesa>();
                printService.Print(Conta_ as Despesa);
            }
        }
    }
}
