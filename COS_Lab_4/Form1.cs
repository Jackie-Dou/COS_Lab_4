using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COS_Lab_4
{
    public partial class Form1 : Form
    {
        string[] swings = {"2", "2"}, frequences = {"2", "2" }, phases = {"2", "3" };
        int N = 256;

        public Form1()
        {
            InitializeComponent();

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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            signalChart.Series[0].Points.Clear();
            signalChart.Series["1"].Points.Clear();
            signalChart.Series["2"].Points.Clear();
            signalChart.Series["3"].Points.Clear();

            double[] ordinates = new double[N];
            double[] ordinates2 = new double[N];

            string type = cbbxType.Text;
            switch (type)
            {
                case "Взаимная корреляция":
                    ordinates = GetHarmonic(Int32.Parse(swings[0]), Int32.Parse(frequences[0]), Int32.Parse(phases[0]), N);
                    ordinates2 = GetHarmonic(Int32.Parse(swings[1]), Int32.Parse(frequences[1]), Int32.Parse(phases[1]), N);
                    ShowCharts(ordinates, ordinates2, N, 2);
                    break;
                case "Автокорреляция":
                    ordinates = GetHarmonic(Int32.Parse(swings[0]), Int32.Parse(frequences[0]), Int32.Parse(phases[0]), N);
                    ShowCharts(ordinates, ordinates2, N, 1);
                    break;
            }

            
        }
    }
}
