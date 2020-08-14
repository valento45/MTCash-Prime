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
        }

        public frmRelatorioGrafico()
        {
            InitializeComponent();
            Calculo = new CalculoEntradaSaida();
        }
        private decimal GetPorcentagemDeGasto(decimal gasto, decimal ganho)
        {
            return (gasto / ganho) * 100;
        }

        private void PreencheGraficoMensal()
        {
            if (Calculo != null)
            {
                decimal ganhoTotal = Calculo.ListReceita.Sum(x => x.Valor);
                decimal gastoTotal = Calculo.ListDespesa.Sum(x => x.Valor);
                if (ganhoTotal == 0)
                    throw new InvalidOperationException("Impossível divisão por zero!");

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

        private void CriaGrafico(List<Series> series)
        {
            if (!(series != null))
                throw new InvalidOperationException("Impossível prosseguir, nenhuma serie atribuída para criação do gráfico!");

            graficObj.Series.Clear();
            for (int i = 0; i < series.Count; i++)
                graficObj.Series.Add(series[i]);
            graficObj.Update();
        }
        private void frmRelatorioGrafico_Load(object sender, EventArgs e)
        {
            try
            {
                Calculo = CalculoEntradaSaida.GetByMes(DateTime.Now);
                PreencheGraficoMensal();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "OPS!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void GeraGraficoPorPeriodo(DateTime de, DateTime ate)
        {
            try
            {
                Calculo = CalculoEntradaSaida.GetByPeriodo(de, ate);
                List<Series> series = new List<Series>();

                decimal gasto = Calculo.ListDespesa.Sum(x => x.Valor);
                decimal ganho = Calculo.ListReceita.Sum(x => x.Valor);

                Series despesa = new Series("Despesa");
                Series receita = new Series("Receita");
                despesa.Points.AddXY("Periodo de " + de.ToString("dd/MM/yyyy") + $" Até {ate.ToString("dd/MM/yyyy")}", gasto);
                receita.Points.AddXY("", ganho);

                series.Add(despesa);
                series.Add(receita);

                CriaGrafico(series);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "OPS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btAcao_Click(object sender, EventArgs e)
        {
            if (!(txtDe.Text.Trim().Length == 10 && txtAte.Text.Trim().Length == 10))
            {
                MessageBox.Show("Por favor, preencha o período corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbFiltro.SelectedIndex == 0)
                GeraGraficoPorPeriodo(Convert.ToDateTime(txtDe.Text), Convert.ToDateTime(txtAte.Text));
            else
                GeraGraficoPorPeriodo(Convert.ToDateTime(txtDe.Text), Convert.ToDateTime(txtDe.Text));
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFiltro.SelectedIndex)
            {
                case 0:
                    pnlPeriodo.Visible = true;
                    lblAte.Visible = txtAte.Visible = true;
                    break;
                case 1:
                    pnlPeriodo.Visible = true;
                    lblAte.Visible = txtAte.Visible = false;
                    break;

            }
        }
    }
}
