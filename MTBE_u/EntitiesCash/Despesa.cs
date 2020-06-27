using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MTBE_u.EntitiesCash
{
    public class Despesa : Conta
    {
        public Despesa() { }
        public Despesa(DataRow dr)
        {
            Id = Convert.ToInt32(dr["id_despesa"]);
            Descricao = dr["descricao"].ToString();
            Valor = Convert.ToDecimal(dr["valor_despesa"]);
            Data_Vencimento = dr["data_vencimento"] != null ? Convert.ToDateTime(dr["data_vencimento"]) : (DateTime?)null;
            Periodo = dr["periodo"].ToString();
            Desconto = dr["desconto"] != null ? Convert.ToDecimal(dr["desconto"]) : 0;
            Status = dr["paga"].ToString();
        }

        public bool InsertDespesa()
        {
            SqlCommand cmd = new SqlCommand("insert into mtcash.u_tb_despesa (descricao, valor_despesa, data_vencimento, periodo, desconto, paga) values (" +
                "" +
                $"'{Descricao}','{Valor}','{Data_Vencimento}','{Periodo}','{Desconto}', '{Status}');");
            return Access.ExecuteNonQuery(cmd);
        }

        public bool UpdateDespesa()
        {
            SqlCommand cmd = new SqlCommand("update mtcash.u_tb_despesa set descricao = " +
                $"'{Descricao}', valor_despesa = '{Valor}', data_vencimento = '{Data_Vencimento}', periodo = '{Periodo}', desconto = '{Desconto}', paga = '{Status}' where id_despesa = '{Id}';");           
            return Access.ExecuteNonQuery(cmd);
        }

        public static bool Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from mtcash.u_tb_despesa where id_despesa = " + id);
            return Access.ExecuteNonQuery(cmd);
        }

        public static List<Despesa> GetDespesas(bool apenaspendentes, bool todas = false)
        {
            List<Despesa> result = new List<Despesa>();
            string query = "select * from mtcash.u_tb_despesa";

            if (apenaspendentes)
                query += " where paga = False";
            else if (!apenaspendentes && !todas)
                query += " where paga = True";

            SqlCommand cmd = new SqlCommand(query);

            foreach (DataRow x in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Despesa(x));

            return result;
        }
    }
}
