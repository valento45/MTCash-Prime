using MTBE_u.Gateway;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTBE_u.EntitiesCash
{
    public class CalculoEntradaSaida
    {
        public List<Receita> ListReceita { get; set; } = new List<Receita>();
        public List<Despesa> ListDespesa { get; set; } = new List<Despesa>();
        public List<Conta> AllContas { get; set; } = new List<Conta>();
        public static CalculoEntradaSaida GetByMes(DateTime data)
        {
            CalculoEntradaSaida result = new CalculoEntradaSaida();
            SqlCommand cmd = new SqlCommand();
            try
            {
                string query = $"select * from mtcash.u_tb_receita where mes = '{data.Month}' AND ano = '{data.Year}' ;";
                cmd.CommandText = query;
                cmd.Connection = (SqlConnection)Access.GetConnection();

                if (cmd.Connection.State == ConnectionState.Closed)
                    cmd.Connection.Open();
                //Adicionand receita
                foreach (DataRow x in Access.ExecuteReader(cmd).Tables[0].Rows)
                {
                    result.ListReceita.Add(new Receita(x));
                    AddConta(result, new Receita(x));
                }

                //Adicionando Despesa 
                query = $"select * from mtcash.u_tb_despesa where mes = '{data.Month}' AND ano = '{data.Year}' ;";
                cmd.CommandText = query;

                foreach (DataRow x in Access.ExecuteReader(cmd).Tables[0].Rows)
                {
                    result.ListDespesa.Add(new Despesa(x));
                    AddConta(result, new Despesa(x));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "OPS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NetworkLog.Insert(ex, "CalculoEntradaSaida.cs in Method GetByMesPendente");
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
            return result;
        }

        public static void AddConta(CalculoEntradaSaida calculaEntrada, Conta conta)
        {
            if (calculaEntrada.AllContas != null)
            {
                if (conta is Receita)
                {
                    Receita value = conta as Receita;
                    if (!calculaEntrada.AllContas.Contains(value))
                        calculaEntrada.AllContas.Add(value);
                }
                else
                {
                    Despesa value = conta as Despesa;
                    if (!calculaEntrada.AllContas.Contains(value))
                        calculaEntrada.AllContas.Add(value);
                }
            }
        }

        public decimal GetTotalReceitaMes(DateTime mes)
        {
            decimal result = 0;
            foreach (var x in ListReceita)
            {
                if (x.MesVencimento.GetHashCode() == mes.Month.GetHashCode())
                    if (x.MesVencimento.Equals(mes.Month))
                        result += x.Valor;
            }
            return result;
        }


        public decimal GetTotalDespesaMes(DateTime mes)
        {
            decimal result = 0;
            foreach (var x in ListDespesa)
            {
                if (x.MesVencimento.GetHashCode() == mes.Month.GetHashCode())
                    if (x.MesVencimento.Equals(mes.Month) && x.AnoVencimento == mes.Year.ToString())
                        result += x.Valor;
            }
            return result;
        }

        public string GastoPorcentagemByMes(DateTime mes)
        {
            decimal gasto = GetTotalDespesaMes(mes);
            decimal ganho = GetTotalReceitaMes(mes);
            decimal result = (gasto / ganho) * 100;

            return result + "%";
        }

    }
}
