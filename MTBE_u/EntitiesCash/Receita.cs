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
            Data_Inicio = dr["data_inicio"] != null ? (DateTime?)dr["data_inicio"] : (DateTime?)null;
            Data_Vecimento = dr["data_recibo"] != null ? (DateTime?)dr["data_recibo"] : (DateTime?)null;
            Favorecido_Pagante = dr["pagante"].ToString();
            Valor = Convert.ToDecimal(dr["valor_receita"]);
            //Desconto = Convert.ToDecimal(dr["desconto"]);
        }
        public override void Insert()
        {
            SqlCommand cmd = new SqlCommand("insert into mtcash.u_tb_receita (descricao, data_inicio, data_recibo, pagante, valor_receita) values (" +
                $"'{Descricao}', '{Data_Inicio}', '{Data_Vecimento}', '{Valor}';");
            Access.ExecuteNonQuery(cmd);
        }

        public override void Update(Conta conta)
        {
            SqlCommand cmd = new SqlCommand("update mtcash.u_tb_receita set descricao = @descricao, data_inicio = @data_inicio, data_recibo = @data_recibo, pagante = @pagante, valor_receita = @valor_receita where id_receita = @id_receita");
            cmd.Parameters.AddWithValue(@"id_receita", Id);
            cmd.Parameters.AddWithValue(@"descricao", Descricao);
            cmd.Parameters.AddWithValue(@"data_inicio", Data_Inicio);
            cmd.Parameters.AddWithValue(@"data_vencimento", Data_Vecimento);
            cmd.Parameters.AddWithValue(@"pagante", Favorecido_Pagante);
            cmd.Parameters.AddWithValue(@"valor_receita", Valor);
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
        public override void Delete(Conta receita)
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
