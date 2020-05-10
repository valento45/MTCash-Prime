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

namespace MtCash.UI
{
    public partial class frmIncluiCliente : Form
    {
        Cliente client_;
        bool alterar = false;
        public frmIncluiCliente()
        {
            InitializeComponent();
        }

        public frmIncluiCliente(Cliente cliente)
        {
            InitializeComponent();
            alterar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chave = -1;
            if (!alterar)
                if (ValidaCamposObrigatorios())
                    try
                    {
                        Cliente cliente = new Cliente();
                        EnderecoCliente enderecoCliente = new EnderecoCliente();
                        cliente.Nome = txtNome.Text.Trim();
                        cliente.Tipo_Documento = cmbTipoDocumento.Text;
                        cliente.Documento = txtDocumento.Text.Trim();
                        cliente.Cpf_Cnpj = txtCpf.Text;
                        cliente.Data_Nascimento = txtDataNasc.Text.Trim().Length >  9 ? DateTime.Parse(txtDataNasc.Text) : (DateTime?)null;
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
                            client_ = cliente;
                        }                        
                        MessageBox.Show("Cliente registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        LOG.Insert(ex.Message + (ex.InnerException != null ? "\r\n\r\n\r" + ex.InnerException.Message : ""), ex.StackTrace.ToString(), DateTime.Now);
                        MessageBox.Show(ex.Message, "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
        }

        private void btnAddEnd_Click(object sender, EventArgs e)
        {
            if (ValidaEndereco())
                dgvEndereco.Rows.Add(txtEndereco.Text, txtNumero.Text, txtComplemento.Text, txtUf.Text, txtCidade.Text);
            else
                MessageBox.Show("Não foi possíve adicional o Endereço!\r\n\r\n\r\nPreencha todos os campos!", "Valida Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private bool ValidaCamposObrigatorios()
        {
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
                MessageBox.Show("Não foi possíve adicional o Endereço!\r\n\r\n\r\nPreencha todos os campos!", "Valida Campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Cliente.ExportarXML(client_);               
        }
    }
}
