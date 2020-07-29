using Aux_Mt;
using MTBE_u.EntitiesCash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MT_u
{
    public partial class frmRelatorioGrafico : Form
    {
        CalculoEntradaSaida Calculo;
        public frmRelatorioGrafico(CalculoEntradaSaida calculo)
        {
            InitializeComponent();
            Calculo = calculo;
            CriaGrafico();
        }
        private decimal GetPorcentagemDeGasto(decimal gasto, decimal ganho)
        {
            return (gasto / ganho) * 100;
        }

        private void CriaGrafico()
        {
            if (Calculo != null)
            {
                decimal ganhoTotal = Calculo.ListReceita.Sum(x => x.Valor);
                decimal gastoTotal = Calculo.ListDespesa.Sum(x => x.Valor);
                decimal porcentagemDeGasto = 0;
                if (gastoTotal > 0)
                    porcentagemDeGasto = GetPorcentagemDeGasto(gastoTotal, ganhoTotal);

                //graficObj.DataSource = value;
                for (int i = 0; i < Calculo.ListDespesa.Count; i++)
                {
                    graficObj.Series[0].Points.AddXY(Calculo.ListDespesa[i].Descricao, Calculo.ListDespesa[i].Valor);
                    // graficObj.Series[0].Points.AddXY("", "");
                }
                for (int i = 0; i < Calculo.ListReceita.Count; i++)
                {
                    
                    graficObj.Series[1].Points.AddXY(Calculo.ListReceita[i].Descricao, Calculo.ListReceita[i].Valor);
                    //graficObj.Series[1].Points.AddXY("", "");
                }
                //foreach (var x in Calculo.ListDespesa)
                //    graficObj.Series[0].Points.AddXY(x.Descricao, x.Valor);

                //foreach (var x in Calculo.ListReceita)
                //    graficObj.Series[1].Points.AddXY(x.Descricao, x.Valor);

                graficObj.Update();
                //foreach (var x in Calculo.AllContas)
                //{
                //    Series serie = new Series();
                //    if (x is Receita)
                //    {
                //        //serie.XValueMember = "Receita: " + x.Descricao;
                //        //serie.YValueMembers = x.Valor.ToString();
                //    }
                //    else if (x is Despesa)
                //    {
                //        //serie.XValueMember = "Despesa: " + x.Descricao;
                //        //serie.YValueMembers = x.Valor.ToString();
                //    }

                //    graficObj.Series.Add(serie);
                //    graficObj.DataSource = Calculo.AllContas;
                //}
            }
        }
        private void frmRelatorioGrafico_Load(object sender, EventArgs e)
        {

        }

    }
}
