using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTBE_u.Exceptions;
namespace MTBE_u
{
    public class Pessoa
    {
        DateTime? data_nascimento;
        public int Id_Pessoa { get; set; }
        public string Nome { get; set; }
        public string Tipo_Documento { get; set; }
        public string Documento { get; set; }
        public string Cpf_Cnpj { get; set; }
        public DateTime? Data_Nascimento
        {
            get
            {
                return data_nascimento.HasValue ? data_nascimento : ((DateTime?)null);
            }
            set
            {
                data_nascimento = value;
            }
        }
    }
}
