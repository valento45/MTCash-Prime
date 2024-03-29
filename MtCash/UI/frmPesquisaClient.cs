﻿using Aux_Mt;
using MTBE_u;
using MTBE_u.Entities;
using MTBE_u.Entities.Enums;
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

namespace MtCash.UI
{
    public partial class frmPesquisaClient : Form
    {
        public frmPesquisaClient()
        {
            InitializeComponent();

            if (Login.User != null)
            {
                btnEdit.Enabled = Modulo.CanUpdate(Login.User, Modulos.Cliente);
                btnExcluir.Enabled = Modulo.CanExclude(Login.User, Modulos.Cliente);
                btnExportXml.Enabled = btnPrint.Enabled = Modulo.CanRelatorio(Login.User, Modulos.Cliente);
            }
            
            //cmbFiltro.SelectedItem = Enum.Parse(typeof(FuncoesAuxiliares.Filtro), "Documento");/*Conversão String Para Enum*/
        }

        private void frmPesquisaClient_Load(object sender, EventArgs e)
        {

        }

        private void txtDocumento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClient.RowCount > 0)
            {
                int codigo = Convert.ToInt32(dgvClient.SelectedCells[colCodigo.Index].Value);
                var x = Cliente.GetById(codigo);

                if (x.Id_Pessoa > 0)
                {
                    frmIncluiCliente frm = new frmIncluiCliente(x);
                    frm.MdiParent = MdiParent;
                    if (frm.Visible)
                        frm.Focus();
                    else
                        frm.Show();
                }
            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlFilter();
        }

        private void ControlFilter()
        {
            if (cmbFiltro.SelectedIndex > -1)
            {
                if ((FuncoesAuxiliares.Filtro)cmbFiltro.SelectedItem == FuncoesAuxiliares.Filtro.Nome)
                {
                    pnlDocumento.Visible = pnlCpjCnpj.Visible = false;
                    pnlNome.Visible = true;
                }
                if ((FuncoesAuxiliares.Filtro)cmbFiltro.SelectedItem == FuncoesAuxiliares.Filtro.Documento)
                {
                    pnlCpjCnpj.Visible = pnlNome.Visible = false;
                    pnlDocumento.Visible = true;
                }
                if ((FuncoesAuxiliares.Filtro)cmbFiltro.SelectedItem == FuncoesAuxiliares.Filtro.Cpf)
                {
                    pnlNome.Visible = pnlDocumento.Visible = false;
                    pnlCpjCnpj.Visible = true;
                    txtCpfCnpj.Mask = "000.000.000-00";
                }
                if ((FuncoesAuxiliares.Filtro)cmbFiltro.SelectedItem == FuncoesAuxiliares.Filtro.Cnpj)
                {
                    pnlNome.Visible = pnlDocumento.Visible = false;
                    pnlCpjCnpj.Visible = true;
                    txtCpfCnpj.Mask = FuncoesAuxiliaresAux.GetMaskCnpj();
                }
            }
        }

        private void FillGridClient()
        {
            dgvClient.Rows.Clear();
            foreach (Cliente client in Cliente.ListarClients().OrderBy(x => x.Nome).ToList())
                dgvClient.Rows.Add(client.Id_Pessoa, client.Nome, client.Tipo_Documento, client.Documento, client.Cpf_Cnpj, client.Data_Nascimento, client.Tipo_Pessoa);
        }

        private void btnExportXml_Click(object sender, EventArgs e)
        {
            if(dgvClient.RowCount > 0)
            {
                Cliente cliente = Cliente.GetById((Convert.ToInt32(dgvClient.SelectedCells[colCodigo.Index].Value)));
                if (cliente.Id_Pessoa > 0)
                    Cliente.ExportarXML(cliente);
            }            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(dgvClient.RowCount > 0)
            {
                if(MessageBox.Show("Deseja excluir o cliente " +                    
                    "" + (dgvClient.SelectedCells[colNome.Index].Value.ToString()), "" +
                    "Excluir cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cliente.DeleteClient((Convert.ToInt32(dgvClient.SelectedCells[colCodigo.Index].Value)));
                    dgvClient.Rows.Remove(dgvClient.SelectedRows[colCodigo.Index]);
                }
            }
        }

        private void frmPesquisaClient_Shown(object sender, EventArgs e)
        {
            //T x;
            //var filters = FuncoesAuxiliares.FiltroGetValuesEnum(x);
            //foreach (var item in filters )
            //    cmbFiltro.Items.Add(item);

           // cmbFiltro.SelectedIndex = 0;
            FillGridClient();
            ControlFilter();
        }
    }
}
