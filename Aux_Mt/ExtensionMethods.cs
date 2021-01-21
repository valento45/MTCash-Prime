using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aux_Mt
{
    public static class ExtensionMethods
    {
        public static void UpdateAll<T>(this IEnumerable<T> lista, Func<T, bool> condicao, Action<T> action)
        {
            var listFiltrada = lista.Where(condicao);
            foreach (var item in listFiltrada)
                action(item);
        }

        public static int StringToInt(this string value, int default_value = -1)
        {
            int result;
            if (int.TryParse(value, out result))
                return result;
            else
                return default_value;
        }
    }
}
