using MTBE_u;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
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
        public static void IOCreateLogAcesso(string value, string descricao = "")
        {
            string path = Directory.GetCurrentDirectory() ;
            path = path.Substring(0, path.Length - 17) + @"\Arquivos\LogAcesso\" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
            string informacao = Login.User._Usuario + ", " + DateTime.Now.ToString();
            if (File.Exists(path))
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine(informacao);
                sw.Dispose();
            }
            else
            {
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine(informacao);
                sw.Dispose();
            }

        }
        public static void ImprimeLogAcessoFinanceiro(string data)
        {
            try
            {
                string path = @"C:\Users\MRX\Desktop\CProfissional\JoalheriaPrime\Arquivos\LogAcesso\" + data.Replace("/", "") + ".txt";
                List<string> listAcessos = new List<string>();
                string texto = "";
                if (File.Exists(path))
                {
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
                            texto = texto.Substring(0, texto.Length - 3) + ".";
                        }
                        MessageBox.Show($"Total de acessos em {data}: {listAcessos.Count}" + "\n\r\n\r\n\rUSUÁRIOS: \n" + texto);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(Login.User._Usuario + ", ");
                        sw.Close();
                    }
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
