using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtCash.BusinessEntities
{
    public class FuncoesAuxiliares
    {
        public static Filtro[] GetFiltros
        {
            get
            {
                Filtro[] filtros = { Filtro.Nome, Filtro.Documento, Filtro.Cpf, Filtro.Cnpj };
                return filtros;
            }
        }

        public static Object ConverteStringForEnum(Enum value_enum, string text)
        {            
            var x = value_enum.GetTypeCode();
            return value_enum.ToString();            
        }  

        public enum Filtro
        {
            Nome = 'n',
            Documento = 'd',
            Cpf = 'c',
            Cnpj = 'k'
        }
    }
}
