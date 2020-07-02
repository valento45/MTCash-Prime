using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aux_Mt
{
    public class FuncoesAuxiliaresAux
    {
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

            

    }

}
