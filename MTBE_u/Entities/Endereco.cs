using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTBE_u.Entities
{
    public class Endereco
    {
        public int Id_Uf { get; set; }
        public string Uf { get; set; }
        public string Pais { get; set; }
        public int Id_cidade { get; set; }
        public string Cidade { get; set; }
        public string Endereco_ { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
    }
}
