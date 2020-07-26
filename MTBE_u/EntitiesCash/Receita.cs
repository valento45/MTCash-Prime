﻿using System;
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
            Status = dr["paga"] != null ? dr["paga"].ToString() : "";
            //Desconto = Convert.ToDecimal(dr["desconto"]);
        }
        public override bool Insert()
        {
            SqlCommand cmd = new SqlCommand("insert into mtcash.u_tb_receita (descricao, valor_receita, data_vencimento, periodo, desconto, paga) values (@descricao, @valor_receita, @data_vencimento, @periodo, @desconto, @paga)");
            cmd.Parameters.AddWithValue(@"descricao", Descricao);
            cmd.Parameters.AddWithValue(@"valor_receita", Valor);
            cmd.Parameters.AddWithValue(@"data_vencimento", Data_Vencimento);
            cmd.Parameters.AddWithValue(@"periodo", Periodo);
            cmd.Parameters.AddWithValue(@"desconto", Desconto);
            cmd.Parameters.AddWithValue(@"paga", Status);
            return Access.ExecuteNonQuery(cmd);
        }

        public override bool Update()
        {
            SqlCommand cmd = new SqlCommand("update mtcash.u_tb_receita set descricao = @descricao, valor_receita = @valor_receita, data_vencimento = @data_vencimento, periodo = @periodo, desconto = @desconto where id_receita = @id_receita");
            cmd.Parameters.AddWithValue(@"id_receita", Id);
            cmd.Parameters.AddWithValue(@"descricao", Descricao);
            cmd.Parameters.AddWithValue(@"valor_receita", Valor);
            cmd.Parameters.AddWithValue(@"data_vencimento", Data_Vencimento);
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
    }
}
