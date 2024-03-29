﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MTBE_u.EntitiesCash
{
    public class Categoria
    {
        public int id_categoria { get; set; }
        public string categoria { get; set; }
        public string tipo_categoria { get; set; }
        public int entidade_pai { get;  set; }

        public Categoria()
        {

        }

        public Categoria(DataRow row)
        {
            id_categoria = Convert.ToInt32(row["id_categoria"]);
            categoria = row["categoria"].ToString();
            tipo_categoria = row["tipo_categoria"].ToString();
            entidade_pai = row["entidade_pai"] != null ? Convert.ToInt32(row["entidade_pai"]) : -1;
        }

        public  void InsertCategoria()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO mtcash.u_tb_categoria (categoria, tipo_categoria, entidade_pai) values (@categoria, @tipo_categoria, @entidade_pai)");
            cmd.Parameters.AddWithValue(@"categoria", categoria);
            cmd.Parameters.AddWithValue(@"tipo_categoria", tipo_categoria);
            cmd.Parameters.AddWithValue(@"entidade_pai", entidade_pai > 0 ? entidade_pai : int.MinValue);
            Access.ExecuteNonQuery(cmd);
        }
        public static void DeleteCategoria(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from mtcash.u_tb_categoria where id_categoria ="+ id);
            Access.ExecuteNonQuery(cmd);
        }

        public static List<Categoria> GetAllCateogiras()
        {
            List<Categoria> result = new List<Categoria>();
            SqlCommand cmd = new SqlCommand("select * from mtcash.u_tb_categoria");
            foreach (DataRow dr in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Categoria(dr));
            return result;
        }

        public static List<Categoria> GetSubCateogiras(int cod)
        {
            List<Categoria> result = new List<Categoria>();
            SqlCommand cmd = new SqlCommand("select * from mtcash.u_tb_categoria where entidade_pai=" + cod);
            foreach (DataRow dr in Access.ExecuteReader(cmd).Tables[0].Rows)
                result.Add(new Categoria(dr));
            return result;
        }
    }
}
