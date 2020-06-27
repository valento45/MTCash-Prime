using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MTBE_u.EntitiesCash
{
    public class Receita : Conta
    {
        public Receita() { }
        public Receita(DataRow dr)
        {
            Id = Convert.ToInt32(dr["id_receita"]);
            Descricao = dr["descricao"].ToString();
            Valor = Convert.ToDecimal(dr["valor_receita"]);
            Data_Vencimento = Convert.ToDateTime(dr["data_vencimento"]);
            Periodo = dr["periodo"] != null ? dr["periodo"].ToString() : "";
            Desconto = dr["desconto"] != null ? Convert.ToDecimal(dr["desconto"]) : 0;
            //Desconto = Convert.ToDecimal(dr["desconto"]);
        }
        public void Insert(Receita receita)
        {
            SqlCommand cmd = new SqlCommand("insert into mtcash.u_tb_receita (descricao, valor_receita, data_vencimento, periodo, desconto) values (" +
                $"'{receita.Descricao}', '{receita.Valor}', '{receita.Data_Vencimento}', '{receita.Periodo}', '{receita.Desconto}';");
            Access.ExecuteNonQuery(cmd);
        }

        public void Update(Receita receita)
        {
            SqlCommand cmd = new SqlCommand("update mtcash.u_tb_receita set descricao = @descricao, valor_receita = @valor_receita, data_vencimento = @data_vencimento, periodo = @periodo, desconto = @desconto where id_receita = @id_receita");
            cmd.Parameters.AddWithValue(@"id_receita", receita.Id);
            cmd.Parameters.AddWithValue(@"descricao", receita.Descricao);
            cmd.Parameters.AddWithValue(@"valor_receita", receita.Valor);
            cmd.Parameters.AddWithValue(@"data_vencimento", receita.Data_Vencimento);
            //cmd.Parameters.AddWithValue(@"desconto", Desconto);
            Access.ExecuteNonQuery(cmd);

        }

        public static Receita GetById(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from mtcash.u_tb_receita where id_receita =" + id);
            DataTable dt = Access.ExecuteReader(cmd).Tables[0];

            if (dt.Rows.Count > 0)
                return new Receita(dt.Rows[0]);
            else
                return new Receita();
        }
        public void Delete(Receita receita)
        {
            SqlCommand cmd = new SqlCommand("delete from mtcash.u_tb_receita where id_receita = " + receita.Id);
            Access.ExecuteNonQuery(cmd);
        }

        public static List<Receita> ListarReceitas()
        {
            List<Receita> result = new List<Receita>();
            SqlCommand cmd = new SqlCommand("select * from mtcash.u_tb_receita");
            foreach (DataRow row in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Receita(row));

            if (result.Count > 0)
                return result;
            else
                return new List<Receita>();
        }
    }
}
