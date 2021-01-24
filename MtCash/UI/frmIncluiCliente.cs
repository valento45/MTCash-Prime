using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTBE_u;
using MTBE_u.Entities;
using MtCash.BusinessEntities;
using Aux_Mt;
namespace MtCash.UI
{
    public partial class frmIncluiCliente : Form
    {
        Cliente Client_;
        bool alterar = false;
        public frmIncluiCliente()
        {
            InitializeComponent();
        }

        public frmIncluiCliente(Cliente cliente)
        {
            InitializeComponent();
            
            Client_ = cliente;
            if(Client_ != null)
            {
                DesabilitaHabilitaAlteracao();
                txtNome.Text = Client_.Nome;
                cmbTipoDocumento.SelectedText = Client_.Tipo_Documento;
                txtDocumento.Text = Client_.Documento;
                if((cmbTipoPessoa.SelectedText = Client_.Tipo_Pessoa) == "Física")
                {
                    txtCpf.Mask = "000.000.000-00";
                    txtCpf.Text = Client_.Cpf_Cnpj;
                }
                else if ((cmbTipoPessoa.SelectedText = Client_.Tipo_Pessoa) == "Jurídica")
                {
                    cmbTipoPessoa.SelectedText = Client_.Tipo_Pessoa;
                    txtCpf.Mask = "00.000.000/0000-00";
                    txtCpf.Text = Client_.Cpf_Cnpj;
                }
                txtDataNasc.Text = Client_.Data_Nascimento.ToString();
                FillGridEnderecoClient(Client_.Id_Pessoa);
                FillGridContatoClient(Client_.Id_Pessoa);
                btnNovo.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int chave = -1;
            if (!alterar)
            {
                if (ValidaCamposObrigatorios())
                    try
                    {
                        Cliente cliente = new Cliente();
                        EnderecoCliente enderecoCliente = new EnderecoCliente();
                        ContatoCliente contatoCliente = new ContatoCliente();
                        cliente.Nome = txtNome.Text.Trim();
                        cliente.Tipo_Documento = cmbTipoDocumento.Text;
                        cliente.Documento = txtDocumento.Text.Trim();
                        cliente.Cpf_Cnpj = txtCpf.Text;
                        cliente.Data_Nascimento = txtDataNasc.Text.Trim().Length > 9 ? DateTime.Parse(txtDataNasc.Text) : (DateTime?)null;
                        cliente.Tipo_Pessoa = cmbTipoPessoa.Text;

                        chave = Cliente.InsertClient(cliente);

                        if (chave > 0)
                        {
                            cliente.Id_Pessoa = chave;
                            if (dgvEndereco.RowCount > 0)

                                for (int i = 0; i < dgvEndereco.RowCount; i++)
                                {
                                    enderecoCliente.Endereco_ = dgvEndereco.Rows[i].Cells[colEndereco.Index].Value.ToString();
                                    enderecoCliente.Numero = Convert.ToInt32(dgvEndereco.Rows[i].Cells[colNumero.Index].Value);
                                    enderecoCliente.Complemento = dgvEndereco.Rows[i].Cells[colComplemento.Index].Value.ToString();
                                    enderecoCliente.Uf = dgvEndereco.Rows[i].Cells[colUF.Index].Value.ToString();
                                    enderecoCliente.Cidade = dgvEndereco.Rows[i].Cells[colCidade.Index].Value.ToString();

                                    EnderecoCliente.InsertEnderecoClient(enderecoCliente, cliente.Id_Pessoa);
                                }

                            if (dgvContato.RowCount > 0)
                                for (int i = 0; i < dgvContato.RowCount; i++)
                                {
                                    contatoCliente.Email = dgvContato.Rows[i].Cells[colEmail.Index].Value.ToString();
                                    contatoCliente.Telefone = dgvContato.Rows[i].Cells[colTelefone.Index].Value.ToString();

                                    ContatoCliente.Insert(contatoCliente, cliente.Id_Pessoa);
                                }
                            Client_ = cliente;
                        }
                        MessageBox.Show("Cliente registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DesabilitaHabilitaAlteracao();
                    }
                    catch (Exception ex)
                    {
                        LOG.Insert(ex, null);
                        MessageBox.Show(ex.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            else
            {
                if (ValidaCamposObrigatorios(alterar))
                    try
                    {
                        Client_.Nome = txtNome.Text.Trim();
                        Client_.Tipo_Documento = cmbTipoDocumento.Text;
                        Client_.Documento = txtDocumento.Text.Trim();
                        Client_.Cpf_Cnpj = txtCpf.Text;
                        Client_.Data_Nascimento = txtDataNasc.Text.Trim().Length > 9 ? DateTime.Parse(txtDataNasc.Text) : (DateTime?)null;
                        Client_.Tipo_Pessoa = cmbTipoPessoa.Text;

                        Cliente.UpdateClient(Client_);

                        EnderecoCliente.DeleteEnderecoClient(Client_.Id_Pessoa);
                        if (dgvEndereco.RowCount > 0)
                        {                            
                            EnderecoCliente enderecoCliente = new EnderecoCliente();                            
                            for (int i = 0; i < dgvEndereco.RowCount; i++)
                            {
                                enderecoCliente.Endereco_ = dgvEndereco.Rows[i].Cells[colEndereco.Index].Value.ToString();
                                enderecoCliente.Numero = Convert.ToInt32(dgvEndereco.Rows[i].Cells[colNumero.Index].Value);
                                enderecoCliente.Complemento = dgvEndereco.Rows[i].Cells[colComplemento.Index].Value.ToString();
                                enderecoCliente.Uf = dgvEndereco.Rows[i].Cells[colUF.Index].Value.ToString();
                                enderecoCliente.Cidade = dgvEndereco.Rows[i].Cells[colCidade.Index].Value.ToString();

                                EnderecoCliente.InsertEnderecoClient(enderecoCliente, Client_.Id_Pessoa);
                            }
                        }
                        ContatoCliente.DeleteContatoClient(Client_.Id_Pessoa);
                        if (dgvContato.RowCount > 0)
                        {                            
                            ContatoCliente contatoCliente = new ContatoCliente();
                            for (int i = 0; i < dgvContato.RowCount; i++)
                            {
                                contatoCliente.Email = dgvContato.Rows[i].Cells[colEmail.Index].Value.ToString();
                                contatoCliente.Telefone = dgvContato.Rows[i].Cells[colTelefone.Index].Value.ToString();

                                ContatoCliente.Insert(contatoCliente, Client_.Id_Pessoa);
                            }
                        }
                        MessageBox.Show("Dados do cliente atualizados com sucesso!\n\r\n\r\n\r" + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"), "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        LOG.Insert(ex, null);
                        MessageBox.Show(ex.Message, "Ocorreu um erro!\n\r\n\r\n\rÉ possível que as informações" +
                            " não tenham sido salvas corretamente!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
        }

        private void btnAddEnd_Click(object sender, EventArgs e)
        {
            if (ValidaEndereco())
                dgvEndereco.Rows.Add(txtEndereco.Text, txtNumero.Text, txtComplemento.Text, txtUf.Text, txtCidade.Text);
            else
                MessageBox.Show("Não foi possíve adicionar o Endereço!\r\n\r\n\r\nPreencha todos os campos!", "Valida Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool ValidaEndereco()
        {
            if (txtEndereco.Text.Trim().Length > 0 && txtNumero.Text.Trim().Length > 0 && txtUf.Text.Trim().Length > 0 && txtCidade.Text.Trim().Length > 0)
                return true;
            else
                return false;
        }
        private bool ValidaContato()
        {
            if (txtEmail.Text.Trim().Length > 0 || txtNumero.Text.Trim().Length > 0)
                return true;
            else
                return false;
        }

        private bool ValidaCamposObrigatorios(bool alterar = false)
        {
            if (alterar)
                if (Client_ != null && txtNome.Text.Trim().Length > 0)
                    if (Client_.Id_Pessoa > 0)
                        return true;

                    else return false;

            if (txtNome.Text.Trim().Length > 0)
                return true;
            else
                return false;
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            if (ValidaContato())
                dgvContato.Rows.Add(txtEmail.Text, txtTelefone.Text);
            else
                MessageBox.Show("Não foi possíve adicionar o Contato!\r\n\r\n\r\nPreencha todos os campos!", "Valida Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (Client_ != null)
                Cliente.ExportarXML(Client_);
        }

        //private void FillGridClient()
        //{
        //    dgvCliente.Rows.Clear();
        //    foreach (var row in Cliente.ListarClients().OrderBy(p => p.Nome))
        //        dgvCliente.Rows.Add(row.Id_Pessoa, row.Nome, row.Tipo_Documento, row.Documento, row.Cpf_Cnpj, row.Data_Nascimento, row.Tipo_Pessoa);
        //}

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    if (dgvCliente.RowCount > 0)
        //    {
        //        int id = Convert.ToInt32(dgvCliente.SelectedCells[colIdCliente.Index].Value);
        //        Client_ = Cliente.GetById(id);

        //        txtNome.Text = Client_.Nome;
        //        cmbTipoDocumento.SelectedText = Client_.Tipo_Pessoa;
        //        txtDocumento.Text = Client_.Documento;
        //        cmbTipoPessoa.Text = Client_.Tipo_Pessoa;
        //        txtCpf.Text = Client_.Cpf_Cnpj;
        //        txtDataNasc.Text = Client_.Data_Nascimento.ToString();
        //        FillGridEnderecoClient(Client_.Id_Pessoa);
        //        FillGridContatoClient(Client_.Id_Pessoa);
        //        btnAcao.Text = "Alterar";
        //        alterar = true;
        //        tabControl1.SelectedTab = tabPageRegistro;
        //    }
        //}
        private void FillGridEnderecoClient(int id)
        {
            dgvEndereco.Rows.Clear();
            foreach (var end in EnderecoCliente.GetListByIdClient(id).OrderBy(e => e.id_endereco_cliente).ToList())
                dgvEndereco.Rows.Add(end.Endereco_, end.Numero, end.Complemento, end.Uf, end.Cidade);
        }

        private void FillGridContatoClient(int id)
        {
            dgvContato.Rows.Clear();
            foreach (var end in ContatoCliente.GetByClient(id).OrderBy(e => e.Id_contato_cliente).ToList())
                dgvContato.Rows.Add(end.Email, end.Telefone);
        }
        private void DesabilitaHabilitaAlteracao()
        {
            if (alterar)
            {
                btnAcao.Text = "Incluir";
                alterar = false;
                return;
            }

            if (!alterar)
            {
                btnAcao.Text = "Alterar";
                alterar = true;
            }
        }
        private void frmIncluiCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Client_ = null;
            if (alterar)
                DesabilitaHabilitaAlteracao();
            NewClient();
        }

        private void NewClient()
        {
            Client_ = null;
            //registro
            txtNome.Clear();
            cmbTipoDocumento.SelectedIndex = -1;
            txtDocumento.Clear();
            txtCpf.Clear();
            txtDataNasc.Clear();
            cmbTipoPessoa.SelectedIndex = -1; 

            //endereco
            txtUf.Text = "";
            txtCidade.ResetText();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            dgvEndereco.Rows.Clear();

            //contato
            txtTelefone.Clear();
            txtEmail.Clear();
            dgvContato.Rows.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(dgvEndereco.RowCount > 0)
                dgvEndereco.Rows.Remove(dgvEndereco.SelectedRows[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dgvContato.RowCount > 0)
                dgvContato.Rows.Remove(dgvContato.SelectedRows[0]);
        }
    }
}
