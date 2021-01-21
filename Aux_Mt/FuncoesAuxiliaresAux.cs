using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aux_Mt
{
    public static class FuncoesAuxiliaresAux
    {
        public static Decimal FormatMoney(this string value)
        {
            try
            {
                if (value.Length > 0)
                {
                    value = value.Replace(",", ".");

                    decimal result;
                    if (decimal.TryParse(value, out result))
                        return Convert.ToDecimal(value, CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.Message, "OPS!!!");
            }
            return -1;
        }

        //  public static ConvertObjectForClass<T>(List<T> list)
        public static void ColecaoAbstrataModelo()
        {
            SortedSet<int> a = new SortedSet<int>() { 1, 2, 3, 4 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8 };

            //Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            ImprimeColecaoAbstrata(c);

            //

        }
        static void ImprimeColecaoAbstrata<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine("");
        }
        public static string GetMaskCPF()
        {
            return "000.000.000-00";
        }
        public static string GetMaskCnpj()
        {
            return "00.000.000/0000-00";
        }


    }

}
