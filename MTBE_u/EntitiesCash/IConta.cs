using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
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
    }
}
