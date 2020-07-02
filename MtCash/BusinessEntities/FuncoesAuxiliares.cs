using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MtCash.BusinessEntities
{
    public class FuncoesAuxiliares
    {
        /// <summary>
        /// Obtém uma lista do tipo T dos filtros de pesquisa para pessoa fisíca ou jurídica..
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> FiltroGetValuesEnum<T>()
        {
            List<T> filtros = new List<T>();
            foreach (T x in Enum.GetValues(typeof(Filtro)))
                filtros.Add(x);
            return filtros;
        }

        //public static Object ConverteStringForEnum(Enum value_enum, string text)
        //{
        //    var x = value_enum.GetTypeCode();
        //    return value_enum;
        //}

        public static void ImprimeLogAcessoFinanceiro(string data)
        {            
            try
            {
                string path = @"C:\Users\MRX\Desktop\CProfissional\JoalheriaPrime\Arquivos\LogAcesso\" + data.Replace("/", "") + ".txt";
                List<string> listAcessos = new List<string>();
                string texto = "";
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (listAcessos.Where(x => x == line).ToList().Count == 0)
                        {
                            listAcessos.Add(line);
                            texto += line + ", \n";
                        }
                        texto = texto.Substring(0, texto.Length - 2) + ".";
                    }
                    MessageBox.Show($"Total de acessos em {data}: {listAcessos.Count}" + "\n\r\n\r\n\rUSUÁRIOS: \n"+ texto);
                }

            }
            catch (IOException iex)
            {
                LOG.Insert(iex, "FuncoesAuxiliares.cs Method: ImprimeLogAcessoFinanceiro");
                MessageBox.Show("" + iex.Message, "OPS!!!");
            }
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
