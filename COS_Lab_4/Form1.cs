using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COS_Lab_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbbxN.Items.Add("64");
            cbbxN.Items.Add("128");
            cbbxN.Items.Add("256");
            cbbxN.Items.Add("512");
            cbbxN.Items.Add("1024");
            cbbxN.Items.Add("2048");

            cbbxType.Items.Add("Взаимная корреляция");
            cbbxType.Items.Add("Автокорреляция");

            signalChart.Series.Add("1");
            signalChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            signalChart.Series[0].Color = Color.Red;
            signalChart.Series["1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            signalChart.Series.Add("2");
            signalChart.Series["2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            signalChart.Series["2"].Color = Color.Green;
            signalChart.Series.Add("3");
            signalChart.Series["3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            signalChart.Series["3"].Color = Color.Yellow;



            correlationChart.Series.Add("1");
            correlationChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            correlationChart.Series[0].Color = Color.Red;
            correlationChart.Series["1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            correlationChart.Series.Add("2");
            correlationChart.Series["2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            correlationChart.Series["2"].Color = Color.Green;
            correlationChart.Series.Add("3");
            correlationChart.Series["3"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            correlationChart.Series["3"].Color = Color.Yellow;
        }

        private double[] GetHarmonic(int swing, int frequency, double phase, int N)
        {
            double[] results = new double[N];
            for (int n = 0; n < N; n++)
            {
                double value = swing * Math.Sin((2 * Math.PI * frequency * n) / N + phase % (2 * Math.PI));
                results[n] = value;
            }
            return results;
        }

        private void ShowCharts(double[] ordinates, double[] ordinates2, int N, int number)
        {
            for (int n = 0; n < N; n++)
            {
                signalChart.Series[0].Points.AddXY(n, ordinates[n]);
                signalChart.Series["1"].Points.AddXY(n, ordinates[n]);
                if (number == 2)
                {
                    signalChart.Series["2"].Points.AddXY(n, ordinates2[n]);
                    signalChart.Series["3"].Points.AddXY(n, ordinates2[n]);
                }
            }
            return;
        }


        private void ShowCharts(Complex[] ordinates, Complex[] ordinates2, int N, int number)
        {
            for (int n = 0; n < N; n++)
            {
                correlationChart.Series[0].Points.AddXY(n, ordinates[n].Real);
                correlationChart.Series["1"].Points.AddXY(n, ordinates[n].Real);
                if (number == 2)
                {
                    correlationChart.Series["2"].Points.AddXY(n, ordinates2[n].Real);
                    correlationChart.Series["3"].Points.AddXY(n, ordinates2[n].Real);
                }
            }
            return;
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            signalChart.Series[0].Points.Clear();
            signalChart.Series["1"].Points.Clear();
            signalChart.Series["2"].Points.Clear();
            signalChart.Series["3"].Points.Clear();

            correlationChart.Series[0].Points.Clear();
            correlationChart.Series["1"].Points.Clear();
            correlationChart.Series["2"].Points.Clear();
            correlationChart.Series["3"].Points.Clear();

            int N = 0;
            string[] swings = { }, frequences = { }, phases = { };
            string type;

            string msg = "Ошибка ввода";
            try
            {
                string swingsText = txtSwing.Text;
                swings = swingsText.Split(' ');
                string frequencesText = txtFrequency.Text;
                frequences = frequencesText.Split(' ');
                string phasesText = txtPhase.Text;
                phases = phasesText.Split(' ');
                N = Int32.Parse(cbbxN.Text);
                type = cbbxType.Text;

                if (swings.Count() != frequences.Count() || frequences.Count() != phases.Count() || phases.Count() != swings.Count())
                {
                    msg = "Не весь ввод!";
                    throw new Exception("Не весь ввод");
                }

                /*if (!IsAccessibleFrequencesLogic(frequences, N))
                    {
                        msg = "Логические ограничения!";
                        throw new Exception("Логические ограничения");
                    }*/
            }
            catch
            {
                MessageBox.Show(
                    msg,
                    "Сообщение");
                return;
            }


            double[] ordinates = new double[N];
            double[] ordinates2 = new double[N];

            Complex[] crossCorrelation = null;
            Complex[] fastCrossCorrelation = null;

            Stopwatch stopwatch1 = new Stopwatch();
            Stopwatch stopwatch2 = new Stopwatch();

            long time = 1;
            long fastTime = 1;

            
            switch (type)
            {
                case "Взаимная корреляция":
                    ordinates = GetHarmonic(Int32.Parse(swings[0]), Int32.Parse(frequences[0]), Int32.Parse(phases[0]), N);
                    ordinates2 = GetHarmonic(Int32.Parse(swings[1]), Int32.Parse(frequences[1]), Int32.Parse(phases[1]), N);
                    stopwatch1.Start();
                    crossCorrelation = Correlation.CrossCorrelation(ordinates, ordinates2);
                    stopwatch1.Stop();
                    time = stopwatch1.ElapsedTicks;

                    stopwatch2.Start();
                    fastCrossCorrelation = Correlation.FastCrossCorrelation(ordinates, ordinates2);
                    stopwatch2.Stop();
                    fastTime = stopwatch2.ElapsedTicks;

                    ShowCharts(ordinates, ordinates2, N, 2);
                    break;
                case "Автокорреляция":
                    ordinates = GetHarmonic(Int32.Parse(swings[0]), Int32.Parse(frequences[0]), Int32.Parse(phases[0]), N);
                    stopwatch1.Start();
                    crossCorrelation = Correlation.CrossCorrelation(ordinates, Correlation.GetShiftedSignal(ordinates, 100));
                    stopwatch1.Stop();
                    time = stopwatch1.ElapsedTicks;

                    stopwatch2.Start();
                    fastCrossCorrelation = Correlation.FastCrossCorrelation(ordinates, Correlation.GetShiftedSignal(ordinates, 100));
                    stopwatch2.Stop();
                    fastTime = stopwatch2.ElapsedTicks;

                    ShowCharts(ordinates, ordinates2, N, 1);
                    break;
            }

            ShowCharts(crossCorrelation, fastCrossCorrelation, N, 2);
            txtStraightCorr.Text = time.ToString();
            txtFastCorr.Text = fastTime.ToString();
            txtPercent.Text = (fastTime * 100 / time).ToString();

        }

        private bool IsAccessibleFrequencesLogic(string[] freq, int N)
        {
            bool flag = true;
            int i = 0;
            while (flag && i < freq.Count())
            {
                flag &= (Int32.Parse(freq[i]) > 1);
                flag &= (N > 2 * Int32.Parse(freq[i]));
                i++;
            }
            return flag;
        }
    }
}
