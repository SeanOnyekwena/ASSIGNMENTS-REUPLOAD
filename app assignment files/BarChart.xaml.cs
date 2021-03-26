using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateXF.Widget.Charts.Models;
using UltimateXF.Widget.Charts.Models.BarChart;
using UltimateXF.Widget.Charts.Models.Formatters;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinGraphsPieCharts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarChart : ContentPage
    {
        String[] states = new string[] {"Abia","Adamawa","Akwa Ibom","Anambra","Bauchi",
            "Bayelsa","Benue","Borno","Cross River","Delta","Ebonyi","Edo","Ekiti","Enugu",
            "Gombe","Imo","Jigawa","Kaduna","Kano","Katsina","Kebbi","Kogi","Kwara","Lagos",
            "Nasarawa","Niger","Ogun","Ondo","Osun","Oyo","Plateau","Rivers","Sokoto","Taraba",
            "Yobe","Zamfara"};
        public BarChart()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
        }

        private void BtnLoad_Clicked(object sender, EventArgs e)
        {
            LoadBarChart();
        }

        public void LoadBarChart()
        {
            try
            {
                var entries = new List<EntryChart>();
                var entries2 = new List<EntryChart>();
                var labels = new List<string>();

                Random random = new Random();
                for (int i = 0; i < 36; i++)
                {
                    entries.Add(new EntryChart(i, random.Next(20)));
                    entries2.Add(new EntryChart(i, random.Next(20)));
                    labels.Add(states[i]);
                }

                var dataSet4 = new BarDataSet(entries, "Product Summary")
                {
                    Colors = new List<Color>(){
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.FromHex("#3696e0"), Color.FromHex("#9958bc"),
                    Color.FromHex("#35ad54"), Color.FromHex("#2d3e52"),
                    Color.FromHex("#e55137"), Color.FromHex("#ea9940"),
                    Color.Black
                },
                };

                var data4 = new BarChartData(new List<IBarDataSet>() { dataSet4 });

                chart.ChartData = data4;
                chart.DescriptionChart.Text = "Product chart description";

                chart.AxisLeft.DrawGridLines = false;
                chart.AxisLeft.DrawAxisLine = true;
                chart.AxisLeft.Enabled = true;

                chart.AxisRight.DrawAxisLine = false;
                chart.AxisRight.DrawGridLines = false;
                chart.AxisRight.Enabled = false;

                chart.XAxis.XAXISPosition = XAXISPosition.BOTTOM;
                chart.XAxis.DrawGridLines = false;
                chart.XAxis.AxisValueFormatter = new TextByIndexXAxisFormatter(labels);

            }
            catch (Exception ex)
            {

            }
        }
    }
}