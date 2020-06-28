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
    public partial class frmPesqDespesa : frmDefault
    {
        public frmPesqDespesa()
        {
            InitializeComponent();
        }

        private void pnlFiltro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedIndex == 0 || cmbFiltro.SelectedIndex == 1)
            {
                pnlFiltro.Visible = true;
                pnlStatus.Visible = pnlPeriodo.Visible = !pnlFiltro.Visible;
            }
            else if (cmbFiltro.SelectedIndex == 2)
            {
                pnlPeriodo.Visible = true;
                pnlFiltro.Visible = pnlStatus.Visible = !pnlPeriodo.Visible;
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
            if (cmbFiltro.SelectedIndex == 0 && txtFiltro.Text.Length > 0)
            {
                dgvDespesa.Rows.Clear();
                foreach (var x in Despesa.GetByID(Convert.ToInt32(txtFiltro.Text), false, true))
                {
                    dgvDespesa.Rows.Add(false, x.Id, x.Descricao, x.Data_Vencimento, x.Valor, x.Desconto, x.Status, x);
                }

            }
            else if (cmbFiltro.SelectedIndex == 1)
            {
                dgvDespesa.Rows.Clear();
                foreach (var x in Despesa.GetByDescricao(txtFiltro.Text, false, true))
                {
                    dgvDespesa.Rows.Add(false, x.Id, x.Descricao, x.Data_Vencimento, x.Valor, x.Desconto, x.Status, x);
                }
            }
            else if (cmbFiltro.SelectedIndex == 2 && txtDe.Text.Length == 10 && txtAte.Text.Length == 10)
            {
                dgvDespesa.Rows.Clear();
                foreach (var x in Despesa.GetByPeriodo(txtDe.Text, txtAte.Text, false, true))
                {
                    dgvDespesa.Rows.Add(false, x.Id, x.Descricao, x.Data_Vencimento, x.Valor, x.Desconto, x.Status, x);
                }
            }
            else if (cmbFiltro.SelectedIndex == 3 && (rdbPaga.Checked || rdbPendente.Checked))
            {
                dgvDespesa.Rows.Clear();
                foreach (var x in Despesa.GetDespesas(rdbPendente.Checked))
                {
                    dgvDespesa.Rows.Add(false, x.Id, x.Descricao, x.Data_Vencimento, x.Valor, x.Desconto, x.Status, x);
                }
            }

        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if(dgvDespesa.RowCount > 0)
            {
                Despesa obj = ((Despesa)dgvDespesa.SelectedCells[colObject.Index].Value);
                frmIncluiDespesa frm = new frmIncluiDespesa(obj, true);

                if(frm.ShowDialog() == DialogResult.OK)
                {

                }
                
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Despesa obj = ((Despesa)dgvDespesa.SelectedCells[colObject.Index].Value);
            if(MessageBox.Show("Deseja excluir a despesa " + obj.Descricao + "?" , "Atenção",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(Despesa.Delete(obj.Id))
                    dgvDespesa.Rows.Remove(dgvDespesa.SelectedRows[0]);
            }
        }
    }
}
