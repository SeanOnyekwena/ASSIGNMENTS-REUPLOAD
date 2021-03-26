using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mean__median__mode_calculator
{
    public partial class Statistics : Form
    {
        //Data Storage
        private int[] rawData;
        private int[] sortedData;
        private int size, lowerlimit, upperlimit;

        public Statistics()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handlr to read the input, generate data and sort the data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InfoGenerate_Click(object sender, EventArgs e)
        {
            // Parsing values
            size = int.Parse(textSize.Text);
            lowerlimit = int.Parse(textLower.Text);
            upperlimit = int.Parse(textUpper.Text);

            // Allocate data
            rawData = new int[size];
            sortedData = new int[size];

            // Generating data
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                rawData[i] = random.Next(lowerlimit, upperlimit + 1);
                sortedData[i] = rawData[i];
            }

            //sort
            SortedData();

            // Load into lists
            listRaw.Items.Clear();
            listSorted.Items.Clear();

            for (int i = 0; i < size; i++)
            {
                listRaw.Items.Add(rawData[i]);
                listSorted.Items.Add(sortedData[i]);
            }
        }

        private void SortedData()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (sortedData[i] > sortedData[j])
                    {
                        int tmp = sortedData[i];
                        sortedData[i] = sortedData[j];
                        sortedData[j] = tmp;

                    }
                }
            }
        }

        private void InfoCalculate_Click(object sender, EventArgs e)
        {
            int[] freq = CalculateFrequencies();
            textMean.Text = CalcMean().ToString("0.00");
            textMode.Text = CalcMode(freq).ToString("0.00");
            textMedian.Text = CalcMedian().ToString("0.00");

            // chart
            this.chart1.Series.Clear();
            var series = this.chart1.Series.Add("Random Variable");
            for(int i = 0; i<freq.Length; i++)
            {
                series.Points.AddXY(i, freq[i]);
            }
        }

        // Function to calculate the frequencies of numbers.

        private int[] CalculateFrequencies()
        {
            // new array
            int[] freq = new int[upperlimit + 1];

            for (int i = 0; i < size; i++)
            {
                freq[rawData[i]] += 1;
            }

            return freq;
        }

        // Function to calculate the mean of the data

        private double CalcMean()
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += rawData[i];
            }

            return sum / size;
        }

        private double CalcMedian()
        {
            double median = 0;
            int mid = 0;
            // check the size
            if(size % 2 == 0)
            {
                mid = size / 2;

                median = (sortedData[mid] + sortedData[mid + 1]) / 2.0;
            }
            else
            {
                mid = size / 2;
                median = sortedData[mid];
            }

            return median;
        }

        // Mode

        private int CalcMode(int [] frequencies)
        {
            // find max frequency
            int max = frequencies[0];
            int maxindex = 0;

            for (int i=0; i < frequencies.Length; i++)
            {
                if (max < frequencies[i])
                {
                    max = frequencies[i];
                    maxindex = 1;
                }
            }

            return maxindex;

        }

    }
}
