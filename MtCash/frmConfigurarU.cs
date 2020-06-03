using MTBE_u;
using MTBE_u.Entities.Enums;
using MtCash;
using MtCash.BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aux_Mt;
namespace MT_u.Usuario
{
    public partial class frmConfigurarU : frmDefault
    {
        MTBE_u.Usuario user;
        bool alterar = false;
        public frmConfigurarU()
        {
            InitializeComponent();
            cmbUserAtv.SelectedIndex = cmbTipo.SelectedIndex = 0;
        }

        public frmConfigurarU(MTBE_u.Usuario user)
        {
            InitializeComponent();
            if (user != null)
            {
                cmbUserAtv.SelectedIndex = cmbTipo.SelectedIndex = 0;
                btnNovo.Enabled = btnSalvar.Enabled = Modulo.CanInclude(Login.User, Modulos.Usuario);
                btnEditPermissoes.Enabled = btnEditar.Enabled = Modulo.CanUpdate(Login.User, Modulos.Usuario);
                btnExcluir.Enabled = Modulo.CanExclude(Login.User, Modulos.Usuario);
                if (!btnSalvar.Enabled)
                    btnSalvar.Enabled = Modulo.CanUpdate(Login.User, Modulos.Usuario);                
            }
        }        

        private void PopularGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (var user in MTBE_u.Usuario.ListarUsuarios().OrderBy(n => n._Usuario).ThenBy(n => n.Id_Pessoa))
                dgv.Rows.Add(user.Id_Pessoa, user.Nome, user.Documento, user.Cpf_Cnpj, user.Data_Nascimento, user.Funcao, user.Modulos, user.User_atv, user.Tipo, user._Usuario, user.Senha);
        }

        private void btnEditPermissoes_Click(object sender, EventArgs e)
        {
            if (dgvPermissoesUsuario.RowCount > 0)
            {
                try
                {
                    user = MTBE_u.Usuario.GetById((int)dgvPermissoesUsuario.SelectedCells[colId.Index].Value);
                    if (user.Id_Pessoa > 0)
                    {
                        GridPermissoes();
                        var permission_user = MTBE_u.Usuario.GetPermissoesByUser(user);
                        lblUsuario.Text = user.Id_Pessoa + " - " + user._Usuario;

                        foreach (var y in permission_user)
                        {
                            for (int i = 0; i < dgvPermissoes.RowCount; i++)
                            {
                                if (y.Modulos_.Equals(Modulo.GetModulos[i]))
                                {
                                    if (Modulo.CanInclude(user, Modulo.GetModulos[i]))
                                        dgvPermissoes.Rows[i].Cells[colIncluir.Index].Value = true;

                                    if (Modulo.CanUpdate(user, Modulo.GetModulos[i]))
                                        dgvPermissoes.Rows[i].Cells[colAlterar.Index].Value = true;

                                    if (Modulo.CanExclude(user, Modulo.GetModulos[i]))
                                        dgvPermissoes.Rows[i].Cells[colExcluir.Index].Value = true;

                                    if (Modulo.CanRelatorio(user, Modulo.GetModulos[i]))
                                        dgvPermissoes.Rows[i].Cells[colRelatorio.Index].Value = true;
                                }
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    LOG.Insert(ex, null);
                    MessageBox.Show(ex.Message + "\n\r\n\r\n\r" + ex.StackTrace.Substring(0, 200), "Ops!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void NodeSelecionado()
        {
            if (treeView1.SelectedNode.Name == "NoUincluir")
            {
                pnlPermissoes.Visible = false;
                pnlIncluirEditar.Visible = true;
            }
            if (treeView1.SelectedNode.Name == "NoUPermissoes")
            {
                pnlIncluirEditar.Visible = false;
                pnlPermissoes.Visible = true;
                PopularGrid(dgvPermissoesUsuario);
            }
            ResetCampos();
            GridPermissoes();
        }

        private void ResetCampos()
        {
            alterar = false;
            txtNome.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            cmbTipo.SelectedIndex = 0;
            lblUsuario.Text = "";
            btnSalvar.Text = "Incluir";
            //checkedListBox1.Items.Clear();

            //for (int i = 0; i < Modulo.GetModulos.Length; i++)
            //    checkedListBox1.Items.Add(Modulo.GetModulos[i], false);

            if (user != null)
                user = null;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            NodeSelecionado();
        }

        private bool ValidaCampos()
        {
            bool sucesso;
            if (txtNome.Text.Length == 0 || txtUsuario.Text.Trim().Length == 0 || txtSenha.Text.Trim().Length == 0)
                sucesso = false;
            else
                sucesso = true;

            return sucesso;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool sucesso = false;
            try
            {
                if (ValidaCampos())
                {
                   // if (Modulo.CanUpdate(Login.User, Modulos.Usuario))
                        if (alterar)
                        {
                            if (user == null)
                                return;

                            user.Nome = txtNome.Text;
                            user.Documento = txtRg.Text;
                            user.Cpf_Cnpj = txtCpf.Text;
                            user.Tipo = cmbTipo.Text;
                            if (cmbUserAtv.SelectedIndex == 0)
                                user.User_atv = true;
                            else
                                user.User_atv = false;
                            user._Usuario = txtUsuario.Text;
                            user.Senha = Access.Encrypt(user._Usuario, txtSenha.Text);

                            user.Update_User(user);
                            sucesso = true;
                            ResetCampos();
                            //btnSalvar.Enabled = true;
                        }
                        else
                        {
                            if (user != null)
                                user = null;

                            if (user == null)
                                user = new MTBE_u.Usuario();

                            user.Nome = txtNome.Text;
                            user.Documento = txtRg.Text;
                            user.Cpf_Cnpj = txtCpf.Text;
                            user.Tipo = cmbTipo.Text;
                            if (cmbUserAtv.SelectedIndex == 0)
                                user.User_atv = true;
                            else
                                user.User_atv = false;
                            //user.Modulos = "ucfi";
                            user._Usuario = txtUsuario.Text;
                            user.Senha = Access.Encrypt(user._Usuario, txtSenha.Text);
                            int chave = user.Insert_User(user);
                            if (chave > 0)
                            {
                                Permissao_Modulo_Usuario.Insert_Permissao_Usuario(chave);
                                sucesso = true;
                            }
                        }
                    if (sucesso)
                    {
                        MessageBox.Show($"Usuário {(alterar ? "Atualizado" : "Cadastrado")} com sucesso! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetCampos();
                        PopularGrid(dgvUsuario);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir usuário! \nParamêtros: " + user.GetParametros + "\n\r\n\r\n\r" + ex.Message, "" +
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvarPermissoes_Click_1(object sender, EventArgs e)
        {
            if (user != null && dgvPermissoesUsuario.RowCount > 0)
            {
                Permissao_Modulo_Usuario permissao_usuario = new Permissao_Modulo_Usuario();
                permissao_usuario.Id_Usuario = user.Id_Pessoa;
                //string permissao = "";
                //for (int i = 0; i < checkedListBox1.Items.Count; i++)
                //    if (checkedListBox1.GetItemChecked(i))
                //        permissao += ((Char)Modulo.GetModulos[i]).ToString();

                //user.Modulos = permissao;
                //MTBE_u.Usuario.Update_Permissao(user);
                for (int i = 0; i < dgvPermissoes.RowCount; i++)
                {
                    permissao_usuario.Modulos_ = Modulo.GetModulos[i];
                    permissao_usuario.Permissoes_ = "";
                    for (int j = 0; j < dgvPermissoes.Columns.Count; j++)
                    {
                        if ((j + 1) < 5)
                            try
                            {
                                if (((bool)dgvPermissoes.Rows[i].Cells[j + 1].Value) == true)
                                    permissao_usuario.Permissoes_ += (Char)Modulo.GetPermissoesArray[j];
                            }
                            catch (NullReferenceException)
                            {
                                continue;
                            }
                    }
                    MTBE_u.Usuario.Update_Permissao(permissao_usuario);
                }

                MessageBox.Show("Permissões atualizadas com sucesso!\nAs alteração terão efeitos após o próximo login!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetCampos();
                GridPermissoes();
                PopularGrid(dgvPermissoesUsuario);
            }
        }

        private void frmConfigurarU_Load(object sender, EventArgs e)
        {
            PopularGrid(dgvUsuario);
            GridPermissoes();
        }
        private void GridPermissoes()
        {
            dgvPermissoes.Rows.Clear();
            foreach (var x in Modulo.GetModulos)
                dgvPermissoes.Rows.Add(x);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.RowCount > 0)
            {
                if (user != null)
                    user = null;

                if (user == null)
                    user = MTBE_u.Usuario.GetById((int)dgvUsuario.SelectedCells[colId1.Index].Value);

                if (user.Id_Pessoa > 0)
                {
                    txtNome.Text = user.Nome;
                    txtRg.Text = user.Documento;
                    txtCpf.Text = user.Cpf_Cnpj;
                    txtUsuario.Text = user._Usuario;
                    txtSenha.Text = Access.Decrypt(user._Usuario, user.Senha);
                    Alterar();

                    tabIncluirEditar.SelectedTab = pageIncluir;
                }
            }
        }
        private void Alterar()
        {
            alterar = true;
            btnSalvar.Text = "Alterar";
            if (!btnSalvar.Enabled)
                btnSalvar.Enabled = true;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (user != null)
                user = null;

            try
            {
                if (MessageBox.Show("Deseja excluir o usuário selecionado?", "Excluir usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    user = MTBE_u.Usuario.GetById((int)dgvUsuario.SelectedCells[0].Value);
                    user.Delete_User(user);
                    MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetCampos();
                    PopularGrid(dgvUsuario);
                    GridPermissoes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao excluir usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ResetCampos();
        }
    }
}
