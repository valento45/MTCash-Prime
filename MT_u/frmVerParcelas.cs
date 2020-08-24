using MTBE_u;
using MTBE_u.EntitiesCash;
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
    public partial class frmVerParcelas : Form
    {
        public frmVerParcelas()
        {
            InitializeComponent();
        }
        
        private void PreencherGrid()
        {
            try
            {
                bool getById = false;
                bool getByDescricao = false;
                bool GridPreenchida = false;

                int id;
                if (int.TryParse(txtCodigo.Text.Trim().ToString(), out id))
                    getById = true;

                if (txtDescricao.Text.Trim().Length > 0)
                    getByDescricao = true;

                if (!getById && !getByDescricao)
                    return;

                if (getById)
                {
                    dgvParcelas.Rows.Clear();
                    foreach (Parcela parc in Parcela.GetByIdReceita(id))
                        dgvParcelas.Rows.Add(parc.Id, parc.Id_receita, parc.Numero_parcela, parc.Total_parcelas, parc.Valor_parcela, parc.Data_vencimento, parc.Desconto, parc.Quitada, parc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar pesquisar o registro.\r\n" + ex.Message, "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PreencherGrid();
        }
    }
}
