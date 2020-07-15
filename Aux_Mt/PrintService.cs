using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
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

        public int Count()
        {
            if (listObjT != null)
                return listObjT.Count;
            else
                return -1;
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
                MessageBox.Show(conteudo);
            }
        }

        public void Print(T value)
        {
            string conteudo = "";
            conteudo += value.ToString();
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = " Text |*.txt";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StringWriter sw = new StringWriter())
                {
                    PrintDialog print = new PrintDialog();
                    File.WriteAllText(savefile.FileName, conteudo);
                    print.Document = new PrintDocument();
                    print.Document.DocumentName = savefile.FileName;
                    
                    if (print.ShowDialog() == DialogResult.OK)
                    {
                        print.Document.Print();
                        bool reimprimir = MessageBox.Show("Documento foi impresso corretamente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ? false : true; 
                    }
                     
                    // printDialog.Document.Print();
                }
            }
        }

        public void RemoveValue(T value)
        {
            listObjT.Remove(value);
        }
    }
}
