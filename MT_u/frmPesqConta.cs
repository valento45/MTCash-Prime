using Aux_Mt;
using MTBE_u.EntitiesCash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_u
{
    public partial class frmPesqConta : Form
    {
        private bool isReceita = false;
        public frmPesqConta(string tipoConta)
        {
            InitializeComponent();
            if (tipoConta.Equals("Despesa"))
                AjustaDespesa();

            else
                AjustaReceita();
        }

        private void pnlFiltro_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AjustaDespesa()
        {
            this.Text = "Pesquisar despesa";
            isReceita = false;
        }
        private void AjustaReceita()
        {
            this.Text = "Pesquisar receita";
            isReceita = true;
        }
        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == 0 || cmbFiltro.SelectedIndex == 1)
            {
                pnlFiltro.Visible = true;
                pnlPeriodo.Visible = !pnlFiltro.Visible;
            }
            else if (cmbFiltro.SelectedIndex == 2)
            {
                pnlPeriodo.Visible = true;
                pnlFiltro.Visible = !pnlPeriodo.Visible;
            }
            else
            {
                pnlStatus.Visible = true;
                pnlFiltro.Visible = pnlPeriodo.Visible = !pnlStatus.Visible;
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            PopulaGrid();
        }

        private void PopulaGrid()
        {
            if (!isReceita)
            {
                if (cmbFiltro.SelectedIndex == 0 && txtFiltro.Text.Length > 0)
                {
                    dgvDespesa.Rows.Clear();
                    foreach (var x in Despesa.GetByID(Convert.ToInt32(txtFiltro.Text), rdbPendente.Checked, rdbPaga.Checked))
                    {
                        string data = $"{x.DiaVencimento}/{x.MesVencimento}/{x.AnoVencimento}";
                        dgvDespesa.Rows.Add(false, x.Id, x.Descricao, Convert.ToDateTime(data), x.Valor, x.Desconto, x.Status, x);
                    }
               
                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    dgvDespesa.Rows.Clear();
                    foreach (var x in Despesa.GetByDescricao(txtFiltro.Text, rdbPendente.Checked, rdbPaga.Checked))
                    {
                        string data = $"{x.DiaVencimento}/{x.MesVencimento}/{x.AnoVencimento}";
                        dgvDespesa.Rows.Add(false, x.Id, x.Descricao, Convert.ToDateTime(data), x.Valor, x.Desconto, x.Status, x);
                    }
                }
                else if (cmbFiltro.SelectedIndex == 2 && txtDe.Text.Length == 10 && txtAte.Text.Length == 10)
                {
                    dgvDespesa.Rows.Clear();
                    foreach (var x in Despesa.GetByPeriodo(txtDe.Text, txtAte.Text, rdbPendente.Checked, rdbPaga.Checked))
                    {
                        string data = $"{x.DiaVencimento}/{x.MesVencimento}/{x.AnoVencimento}";
                        dgvDespesa.Rows.Add(false, x.Id, x.Descricao, Convert.ToDateTime(data), x.Valor, x.Desconto, x.Status, x);
                    }
                }
                //else if (cmbFiltro.SelectedIndex == 3 && (rdbPaga.Checked || rdbPendente.Checked))
                //{
                //    dgvDespesa.Rows.Clear();
                //    foreach (var x in Despesa.GetDespesas(rdbPendente.Checked))
                //    {
                //        dgvDespesa.Rows.Add(false, x.Id, x.Descricao, x.Data_Vencimento, x.Valor, x.Desconto, x.Status, x);
                //    }
                //}
            }
            else
            {
                if (cmbFiltro.SelectedIndex == 0 && txtFiltro.Text.Length > 0)
                {
                    dgvDespesa.Rows.Clear();
                    foreach (var x in Receita.GetByID(Convert.ToInt32(txtFiltro.Text), rdbPendente.Checked, rdbPaga.Checked))
                    {
                        string data = $"{x.DiaVencimento}/{x.MesVencimento}/{x.AnoVencimento}";
                        dgvDespesa.Rows.Add(false, x.Id, x.Descricao, Convert.ToDateTime(data), x.Valor, x.Desconto, x.Status, x);
                    }

                }
                else if (cmbFiltro.SelectedIndex == 1)
                {
                    dgvDespesa.Rows.Clear();
                    foreach (var x in Receita.GetByDescricao(txtFiltro.Text, rdbPendente.Checked, rdbPaga.Checked))
                    {
                        string data = $"{x.DiaVencimento}/{x.MesVencimento}/{x.AnoVencimento}";
                        dgvDespesa.Rows.Add(false, x.Id, x.Descricao, Convert.ToDateTime(data), x.Valor, x.Desconto, x.Status, x);
                    }                    
                }
                else if (cmbFiltro.SelectedIndex == 2 && txtDe.Text.Length == 10 && txtAte.Text.Length == 10)
                {
                    dgvDespesa.Rows.Clear();
                    foreach (var x in Receita.GetByPeriodo(txtDe.Text, txtAte.Text, rdbPendente.Checked, rdbPaga.Checked))
                    {
                        string data = $"{x.DiaVencimento}/{x.MesVencimento}/{x.AnoVencimento}";
                        dgvDespesa.Rows.Add(false, x.Id, x.Descricao, Convert.ToDateTime(data), x.Valor, x.Desconto, x.Status, x);
                    }
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dgvDespesa.RowCount > 0)
            {
                if (!isReceita)
                {
                    Despesa obj = ((Despesa)dgvDespesa.SelectedCells[colObject.Index].Value);
                    frmIncluiConta frm = new frmIncluiConta(obj, true);
                    frm.ShowDialog();
                }
                else
                {
                    Receita obj = ((Receita)dgvDespesa.SelectedCells[colObject.Index].Value);
                    frmIncluiConta frm = new frmIncluiConta(obj, true);
                    frm.ShowDialog();
                }
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgvDespesa.RowCount > 0)
            {
                if (isReceita)
                {
                    Receita objctReceita = ((Receita)dgvDespesa.SelectedCells[colObject.Index].Value);
                    if (MessageBox.Show($"Deseja realmente excluir a receita {objctReceita.Descricao} ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (objctReceita.Delete())
                            dgvDespesa.Rows.Remove(dgvDespesa.SelectedRows[0]);
                    }
                }
                else
                {
                    Despesa obj = ((Despesa)dgvDespesa.SelectedCells[colObject.Index].Value);
                    if (MessageBox.Show("Deseja excluir a despesa " + obj.Descricao + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (obj.Delete())
                            dgvDespesa.Rows.Remove(dgvDespesa.SelectedRows[0]);
                    }
                }
            }
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {

            if (dgvDespesa.RowCount > 0)
            {
                if (!isReceita)
                {
                    PrintService<Despesa> printService = new PrintService<Despesa>();
                    for (int i = 0; i < dgvDespesa.RowCount; i++)
                    {
                        if ((bool)dgvDespesa.Rows[i].Cells[colChk.Index].Value)
                        {
                            Despesa despesa = (Despesa)dgvDespesa.Rows[i].Cells[colObject.Index].Value;
                            printService.AddValue(despesa);
                        }
                    }

                    if (printService.Count() > 0)
                        printService.Print();
                }
            }
        }
    }
}
