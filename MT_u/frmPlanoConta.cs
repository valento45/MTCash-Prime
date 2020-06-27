using Aux_Mt;
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
    public partial class frmPlanoConta : frmDefault
    {
        private string tipo = "";
        private int Entidade_pai = -1;
        public frmPlanoConta()
        {
            InitializeComponent();
        }

        private void btAddCategoria_Click(object sender, EventArgs e)
        {
            PreparaAddCategoria();
        }

        private void PreparaAddCategoria()
        {
            ShowCampos(true);
            tipo = "categoria";
        }

        private void PreparaAddSub()
        {
            ShowCampos(true);
            tipo = "subcategoria";
        }

        private void btAddSubCategoria_Click(object sender, EventArgs e)
        {
            PreparaAddSub();
            Entidade_pai = Convert.ToInt32(treeView.SelectedNode.Text.Substring(0, 1));
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                Categoria categoria = new Categoria();
                categoria.categoria = txtDescricao.Text;
                categoria.tipo_categoria = cmbTipoPlano.Text;

                if (tipo == "subcategoria")
                    categoria.entidade_pai = Entidade_pai;

                categoria.InsertCategoria();
                MessageBox.Show(tipo == "categoria" ? "Categoria inserida!" : "Sub Categoria inserida!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowCampos(false);
                PreencherNodes();
            }
        }

        private void ShowCampos(bool visible)
        {
            txtDescricao.Clear();
            cmbTipoPlano.SelectedIndex = -1;
            pnlCampos.Visible = visible;
        }

        private bool ValidaCampos()
        {
            if (txtDescricao.Text.Trim() != "" && cmbTipoPlano.SelectedIndex != -1)
                return true;
            else
                return false;
        }

        private void PreencherNodes()
        {
            treeView.Nodes.Clear();
            List<Categoria> categorias = Categoria.GetAllCateogiras().OrderBy(order => order.id_categoria).ToList();
            for (int x = 0; x < categorias.Count; x++)
                if (categorias[x].entidade_pai < 0)
                {
                    treeView.Nodes.Add(categorias[x].id_categoria + " - " + categorias[x].categoria);
                    foreach (Categoria y in Categoria.GetSubCateogiras(categorias[x].id_categoria))
                        if (y.entidade_pai > 0)
                            treeView.Nodes[x].Nodes[x].Nodes.Add(y.id_categoria + " - " + y.categoria);
                }
        }

        private void frmPlanoConta_Load(object sender, EventArgs e)
        {
            PreencherNodes();
        }
    }
}
