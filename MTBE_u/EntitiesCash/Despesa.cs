using Aux_Mt;
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


        //public bool UpdateDespesa()
        //{
        //    SqlCommand cmd = new SqlCommand("update mtcash.u_tb_despesa set descricao = @descricao, valor_despesa = @valor_despesa, data_vencimento = @data_vencimento, periodo = @periodo, desconto = @desconto, paga = @paga where id_despesa = @id_despesa;");
        //    cmd.Parameters.AddWithValue(@"id_despesa", Id);
        //    cmd.Parameters.AddWithValue(@"descricao", Descricao);
        //    cmd.Parameters.AddWithValue(@"valor_despesa", Valor);
        //    cmd.Parameters.AddWithValue(@"data_vencimento", Data_Vencimento);
        //    cmd.Parameters.AddWithValue(@"periodo", Periodo);
        //    cmd.Parameters.AddWithValue(@"desconto", Desconto);
        //    cmd.Parameters.AddWithValue(@"paga", Status);
        //    return Access.ExecuteNonQuery(cmd);
        //}

        public override bool Update()
        {
            SqlCommand cmd = new SqlCommand("update mtcash.u_tb_despesa set descricao = @descricao, valor_despesa = @valor_despesa, data_vencimento = @data_vencimento, periodo = @periodo, desconto = @desconto, paga = @paga where id_despesa = @id_despesa;");
            cmd.Parameters.AddWithValue(@"id_despesa", Id);
            cmd.Parameters.AddWithValue(@"descricao", Descricao);
            cmd.Parameters.AddWithValue(@"valor_despesa", Valor);
            cmd.Parameters.AddWithValue(@"data_vencimento", Data_Vencimento);
            cmd.Parameters.AddWithValue(@"periodo", Periodo);
            cmd.Parameters.AddWithValue(@"desconto", Desconto);
            cmd.Parameters.AddWithValue(@"paga", Status);
            return Access.ExecuteNonQuery(cmd);
        }

        public static bool Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from mtcash.u_tb_despesa where id_despesa = " + id);
            return Access.ExecuteNonQuery(cmd);
        }
        public override bool Delete()
        {
            SqlCommand cmd = new SqlCommand("delete from mtcash.u_tb_despesa where id_despesa = " + Id);
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


        public static List<Despesa> GetByDescricao(string descricao, bool apenaspendentes, bool todas = false)
        {
            List<Despesa> result = new List<Despesa>();
            string query = "select * from mtcash.u_tb_despesa WHERE descricao like " + $"'{descricao}%'";

            if (apenaspendentes)
                query += " AND paga = False";
            else if (!apenaspendentes && !todas)
                query += " AND paga = True";

            SqlCommand cmd = new SqlCommand(query);

            foreach (DataRow x in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Despesa(x));

            return result;
        }

        public static List<Despesa> GetByID(int id, bool apenaspendentes, bool todas = false)
        {
            List<Despesa> result = new List<Despesa>();
            string query = "select * from mtcash.u_tb_despesa WHERE id_despesa = " + $"'{id}'";

            if (apenaspendentes)
                query += " AND paga = False";
            else if (!apenaspendentes && !todas)
                query += " AND paga = True";

            SqlCommand cmd = new SqlCommand(query);

            foreach (DataRow x in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Despesa(x));

            return result;
        }

        public static List<Despesa> GetByPeriodo(string de, string ate, bool apenaspendentes, bool todas = false)
        {
            List<Despesa> result = new List<Despesa>();
            string query = "select * from mtcash.u_tb_despesa WHERE data_vencimento >= " + $"'{de} 00:00:00' AND data_vencimento <= '{ate} 23:59:59'";

            if (apenaspendentes)
                query += " AND paga = False";
            else if (!apenaspendentes && !todas)
                query += " AND paga = True";

            SqlCommand cmd = new SqlCommand(query);

            foreach (DataRow x in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Despesa(x));

            return result;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("\n\r\n\rDespesa -");
            str.AppendLine("ID: " + Id);
            str.AppendLine("Despesa: " + Descricao);
            str.AppendLine("Valor: " + Valor);
            str.AppendLine("Vencimento: " + Data_Vencimento);
            str.AppendLine("Status: " + Status);
            if (Periodo.Length > 0)
                str.AppendLine("Período: " + Periodo);
            if (Desconto > 0)
                str.AppendLine("Desconto: " + Desconto);

            return str.ToString();
        }
    }
}
