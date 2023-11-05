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

namespace HumanEVMInterface
{
    public partial class Graphs : Form
    {
        private struct GraphData
        {
            public String[] intervalsSize;
            public int[] numsInIntervals;

            public GraphData(int size)
            {
                intervalsSize = new String[size];
                numsInIntervals = new int[size];
            }
            public int getLength()
            {
                return numsInIntervals.Length;
            }
        }
        public Graphs(double[] array = null)
        {
            InitializeComponent();
            initChart(chart1);
            if (array != null)
            {
                GraphData graphData = getGraphData(array);
                for (int i = 0; i < graphData.getLength(); i++)
                {
                    Series series = chart1.Series.Add(graphData.intervalsSize[i]);
                    series.Points.Add(graphData.numsInIntervals[i]);
                }
            };
        }

        private GraphData getGraphData(double[] array)
        {
            int elementsNumber = array.Length;
            int intervalsNumber = 1 + (int)Math.Truncate(3.322 * Math.Log10(elementsNumber));
            double intervalLength = (array.Max() - array.Min()) / intervalsNumber;

            GraphData graphData = new GraphData(intervalsNumber);
            double left = array.Min();
            double right = left + intervalLength;
            for (int i = 0; i < intervalsNumber; i++)
            {
                graphData.numsInIntervals[i] = array.Count(x => x >= left && x < right);
                String intervalSize = "(" + Math.Round(left, 2) + "; " + Math.Round(right, 2) + ")";
                graphData.intervalsSize[i] = intervalSize;
                left = left + intervalLength + Double.Epsilon;
                right = right + intervalLength;
            }
            return graphData;
        }

        private void initChart(Chart chart)
        {
            ChartArea area = new ChartArea();
            area.Name = chart.Name + "Area";
            chart.ChartAreas.Add(area);
            Series series = new Series();
            series.ChartArea = area.Name;
            series.ChartType = SeriesChartType.Column;
            series.BorderWidth = 3;
            series.LegendText = "Гистограмма";
            chart.Series.Add(series);
            Legend legend = new Legend();
            chart.Legends.Add(legend);
        }
    }

}
