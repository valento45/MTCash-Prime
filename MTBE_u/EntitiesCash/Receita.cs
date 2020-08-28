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
        private const string Type_ = "Receita";
        private List<Parcela> PrivateParcelas = new List<Parcela>();

        public List<Parcela> Parcelas
        {
            get
            {
                if (this.PrivateParcelas == null || this.PrivateParcelas.Count == 0)
                {
                    if (Id > 0)
                        return Parcela.GetByIdReceita(Id);
                    else return new List<Parcela>();
                }
                else
                    return PrivateParcelas;
            }
            set
            {
                PrivateParcelas = value;
            }
        }

        public Receita() { }
        public Receita(DataRow dr)
        {           
            Id = Convert.ToInt32(dr["id_receita"]);
            Descricao = dr["descricao"].ToString();
            Valor = Convert.ToDecimal(dr["valor_receita"]);
            DiaVencimento = dr["dia"].ToString();
            MesVencimento = dr["mes"].ToString();
            AnoVencimento = dr["ano"].ToString();
            Periodo = dr["periodo"] != null ? dr["periodo"].ToString() : "";
            Desconto = dr["desconto"] != null ? Convert.ToDecimal(dr["desconto"]) : 0;
            Status = dr["paga"] != null ? dr["paga"].ToString() : "";
            //Desconto = Convert.ToDecimal(dr["desconto"]);
            Tipo = Type_;
            Parcelas = Parcela.GetByIdReceita(Id);
        }
        public override bool Insert()
        {
            SqlCommand cmd = new SqlCommand("insert into mtcash.u_tb_receita (descricao, valor_receita, dia, mes, ano, periodo, desconto, paga) values (@descricao, @valor_receita, @dia, @mes, @ano, @periodo, @desconto, @paga);SELECT SCOPE_IDENTITY();");
            cmd.Parameters.AddWithValue(@"descricao", Descricao);
            cmd.Parameters.AddWithValue(@"valor_receita", Valor);
            cmd.Parameters.AddWithValue(@"dia", DiaVencimento);
            cmd.Parameters.AddWithValue(@"mes", MesVencimento);
            cmd.Parameters.AddWithValue(@"ano", AnoVencimento);
            cmd.Parameters.AddWithValue(@"periodo", Periodo);
            cmd.Parameters.AddWithValue(@"desconto", Desconto);
            cmd.Parameters.AddWithValue(@"paga", Status);
            Id = Access.ExecuteScalar(cmd);
            return Id > 0;

        }

        public override bool Update()
        {
            SqlCommand cmd = new SqlCommand("update mtcash.u_tb_receita set descricao = @descricao, valor_receita = @valor_receita, dia = @dia, mes = @mes, ano = @ano, periodo = @periodo, desconto = @desconto where id_receita = @id_receita");
            cmd.Parameters.AddWithValue(@"id_receita", Id);
            cmd.Parameters.AddWithValue(@"descricao", Descricao);
            cmd.Parameters.AddWithValue(@"valor_receita", Valor);
            cmd.Parameters.AddWithValue(@"dia", DiaVencimento);
            cmd.Parameters.AddWithValue(@"mes", MesVencimento);
            cmd.Parameters.AddWithValue(@"ano", AnoVencimento);
            cmd.Parameters.AddWithValue(@"periodo", Periodo);
            cmd.Parameters.AddWithValue(@"desconto", Desconto);
            //cmd.Parameters.AddWithValue(@"desconto", Desconto);
            return Access.ExecuteNonQuery(cmd);
        }
        public static List<Receita> GetByID(int id, bool apenaspendentes, bool todas = false)
        {
            List<Receita> result = new List<Receita>();
            string query = "select * from mtcash.u_tb_receita WHERE id_receita = " + $"'{id}'";

            if (apenaspendentes)
                query += " AND paga = False";
            else if (!apenaspendentes && !todas)
                query += " AND paga = True";

            SqlCommand cmd = new SqlCommand(query);

            foreach (DataRow x in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Receita(x));

            return result;
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
        public override bool Delete()
        {
            SqlCommand cmd = new SqlCommand("delete from mtcash.u_tb_receita where id_receita = " + Id);
            return Access.ExecuteNonQuery(cmd);
        }


        public static bool Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from mtcash.u_tb_receita where id_receita = " + id);
            return Access.ExecuteNonQuery(cmd);
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

        public static List<Receita> GetByDescricao(string descricao, bool apenaspendentes, bool todas = false)
        {
            List<Receita> result = new List<Receita>();
            string query = "select * from mtcash.u_tb_receita WHERE descricao like " + $"'{descricao}%'";

            if (apenaspendentes)
                query += " AND paga = 'False'";
            else if (!apenaspendentes && !todas)
                query += " AND paga = 'True'";

            SqlCommand cmd = new SqlCommand(query);

            foreach (DataRow x in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Receita(x));

            return result;
        }

        public static List<Receita> GetByPeriodo(string de, string ate, bool apenaspendentes, bool todas = false)
        {
            List<Receita> result = new List<Receita>();
            string query = "select * from mtcash.u_tb_receita WHERE data_vencimento >= " + $"'{de} 00:00:00' AND data_vencimento <= '{ate} 23:59:59'";

            if (apenaspendentes)
                query += " AND paga = False";
            else if (!apenaspendentes && !todas)
                query += " AND paga = True";

            SqlCommand cmd = new SqlCommand(query);

            foreach (DataRow x in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Receita(x));

            return result;
        }

        //public override List<T> ParcelasAbstract<T>(int id)
        //{
        //    return Parcelas as List<T>;
        //}
    }
}
