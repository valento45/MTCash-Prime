using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aux_Mt
{
    public class PrintService<T>
    {
        List<T> listObjT = new List<T>();
        public void AddValue(T value)
        {
            if (listObjT != null)
                listObjT.Add(value);
        }


        public T First()
        {
            if (listObjT != null)
                return listObjT[0];
            else
                throw new InvalidOperationException("Não foi possível retornar o primeiro valor!");
        }

        public void Print()
        {
            string conteudo = "";
            if (listObjT != null)
            {
                foreach (var obj in listObjT)
                {
                    conteudo += obj.ToString() + ", ";
                }
                conteudo = conteudo.Length > 0 ? conteudo.Substring(0, conteudo.Length - 2) + "." : conteudo;
                MessageBox.Show("Conteudo: " + conteudo);
            }
        }

        public void RemoveValue(T value)
        {
            listObjT.Remove(value);
        }
    }
}
