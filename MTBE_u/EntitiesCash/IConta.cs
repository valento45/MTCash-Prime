using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTBE_u.EntitiesCash
{
    public class Conta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string DiaVencimento { get; set; }
        public string MesVencimento { get; set; }
        public string AnoVencimento { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }
        public string Periodo { get; set; }
        public string Status { get; set; }
        public string Tipo { get; set; }
        //public virtual string GetString(Conta conta)
        //{
        //    StringBuilder str = new StringBuilder();
        //    str.Append((conta.Descricao.Length > 0 ? conta.Descricao.Trim() : ""));
        //    str.Append((str.Length > 0 ? ", " : "") + (conta.Data_Inicio.HasValue ? conta.Data_Inicio.ToString().Substring(0, 10) : ""));
        //    str.Append((str.Length > 0 ? ", " : "") + (conta.Data_Vecimento.HasValue ? conta.Data_Vecimento.ToString().Substring(0, 10) : ""));
        //    str.Append((str.Length > 0 ? ", " : "") + (conta.Favorecido_Pagante.Length > 0 ? conta.Favorecido_Pagante.ToString() : ""));
        //    str.Append((str.Length > 0 ? ", " : "") + (conta.Valor.ToString().Length > 0 ? conta.Valor.ToString() : ""));
        //    str.Append((str.Length > 0 ? ", " : "") + (conta.Desconto.ToString().Length > 0 ? conta.Desconto.ToString() : ""));

        //    if (str.Length > 0)
        //        return str.ToString();
        //    else
        //        return "";
        //}
        public virtual bool Update()
        {
            throw new ArgumentException("Nenhum valor passado para o método atualizar!");
        }

        public virtual bool Insert()
        {
            throw new ArgumentException("Nenhum valor atribuído para o objeto que chama o método Insert");
        }

        public virtual bool Delete()
        {
            throw new ArgumentException("Nenhum valor passado para o método excluir!");
        }

        public virtual List<T> ParcelasAbstract<T>(int id)
        {
            throw new ArgumentException("");
        }
    }

    public class Parcela
    {
        public int Id { get; set; }
        public int Id_receita { get; set; }
        public int Numero_parcela { get; set; }
        public int Total_parcelas { get; set; }
        public decimal Valor_parcela { get; set; }
        public DateTime? Data_vencimento { get; set; }
        public decimal Desconto { get; set; }
        public bool Quitada { get; set; }

        public Parcela() { }
        public Parcela(DataRow dr)
        {
            Id = Convert.ToInt32(dr["id_parcela"]);
            Id_receita = Convert.ToInt32(dr["id_receita"]);
            Numero_parcela = Convert.ToInt32(dr["numero_parcela"]);
            Total_parcelas = Convert.ToInt32(dr["total_parcelas"]);
            Valor_parcela = Convert.ToDecimal(dr["valor_parcela"]);
            Data_vencimento = (DateTime?)(dr["data_vencimento"] != null ? dr["data_vencimento"] : null);
            Desconto = Convert.ToDecimal(dr["desconto"]);
            Quitada = Convert.ToBoolean(dr["quitada"]);
        }

        public void Insert()
        {
            string query = "insert into mtcash.u_parcela_receita_tb (id_receita, numero_parcela, total_parcelas, valor_parcela, data_vencimento, desconto, quitada) values (" +
                $"'{Id_receita}', '{Numero_parcela}', '{Total_parcelas}', '{Valor_parcela}', '{Data_vencimento}', '{Desconto}', '{Quitada}');SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query);
            Id = Access.ExecuteScalar(cmd);
        }

        public static List<Parcela> GetByIdReceita(int id)
        {
            List<Parcela> result = new List<Parcela>();
            if (id > 0)
            {
                string query = "select * from mtcash.u_parcela_receita_tb where id_receita = " + id;
                SqlCommand cmd = new SqlCommand(query);

                foreach (DataRow dr in Access.ExecuteReader(cmd).Tables[0].Rows)
                    result.Add(new Parcela(dr));
            }
            return result;
        }

    }
}
