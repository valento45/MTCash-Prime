using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTBE_u.EntitiesCash
{
    public abstract class Conta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime? Data_Inicio { get; set; }
        public DateTime? Data_Vecimento { get; set; }
        public string Favorecido_Pagante { get; set; }
        public decimal Valor { get; set; }
        public decimal Desconto { get; set; }

        public abstract void Insert();
        public abstract void Update(Conta conta);
        public abstract void Delete(Conta conta);

        public virtual string GetString(Conta conta)
        {
            StringBuilder str = new StringBuilder();
            str.Append((conta.Descricao.Length > 0 ? conta.Descricao.Trim() : ""));
            str.Append((str.Length > 0 ? ", " : "") + (conta.Data_Inicio.HasValue ? conta.Data_Inicio.ToString().Substring(0, 10) : ""));
            str.Append((str.Length > 0 ? ", " : "") + (conta.Data_Vecimento.HasValue ? conta.Data_Vecimento.ToString().Substring(0, 10) : ""));
            str.Append((str.Length > 0 ? ", " : "") + (conta.Favorecido_Pagante.Length > 0 ? conta.Favorecido_Pagante.ToString() : ""));
            str.Append((str.Length > 0 ? ", " : "") + (conta.Valor.ToString().Length > 0 ? conta.Valor.ToString() : ""));
            str.Append((str.Length > 0 ? ", " : "") + (conta.Desconto.ToString().Length > 0 ? conta.Desconto.ToString() : ""));

            if (str.Length > 0)
                return str.ToString();
            else
                return "";
        }

    }
}
