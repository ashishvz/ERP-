using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Demo1
{
    /// <summary>
    /// Interaction logic for DashPage.xaml
    /// </summary>
    public partial class DashPage : Page
    {

        public DashPage()
        {
            InitializeComponent();
            pie_chart();
            line_chart();
            
        }

        public void line_chart()
        {

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title="Sales (In Rupess)",
                    Values=new ChartValues<long> {5500,20045,18434,62323,9645}
                }
            };

            XaxisData = new[] { "Jan", "Feb", "Mar", "Apr", "May", "June"};
            YaxisData = value => value.ToString(""+value);
            DataContext = this;
        }


        public void pie_chart()
        {
            top10_product = new SeriesCollection
            {

                new PieSeries
                {
                    Title = "Chrome",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(8) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Mozilla",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(6) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Opera",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(10) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Explorer",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(4) },
                    DataLabels = true
                },
                 new PieSeries
                {
                    Title = "Fan",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(5) },
                    DataLabels = true
                },
                  new PieSeries
                {
                    Title = "Table Fan",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(10) },
                    DataLabels = true
                },
                  new PieSeries
                {
                    Title = "Bulb",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(35) },
                    DataLabels = true
                },
                      new PieSeries
                {
                    Title = "Mixer",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(2) },
                    DataLabels = true
                },
                          new PieSeries
                {
                    Title = "Shirt",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(15) },
                    DataLabels = true
                },
                              new PieSeries
                {
                    Title = "Pant",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(15) },
                    DataLabels = true
                }
            };

            DataContext = this;
        }

        public SeriesCollection top10_product { get; set; }
        public SeriesCollection SeriesCollection  { get; set; }
        public string[] XaxisData { get; set; }
        public Func<long, string> YaxisData { get; set; }

        private void chip_year_Click(object sender, RoutedEventArgs e)
        {

            chip_year.Background = Brushes.MediumPurple;
            chip_year.Foreground = Brushes.White;

            chip_month.Background = Brushes.LightGray;
            chip_month.Foreground = Brushes.Black;

            chip_yesterday.Background = Brushes.LightGray;
            chip_yesterday.Foreground = Brushes.Black;

            chip_today.Background = Brushes.LightGray;
            chip_today.Foreground = Brushes.Black;
        }

        private void chip_month_Click(object sender, RoutedEventArgs e)
        {

            chip_month.Background = Brushes.MediumPurple;
            chip_month.Foreground = Brushes.White;

            chip_yesterday.Background = Brushes.LightGray;
            chip_yesterday.Foreground = Brushes.Black;

            chip_today.Background = Brushes.LightGray;
            chip_today.Foreground = Brushes.Black;

            chip_year.Background = Brushes.LightGray;
            chip_year.Foreground = Brushes.Black;
        }

        private void chip_yesterday_Click(object sender, RoutedEventArgs e)
        {
            chip_year.Background = Brushes.LightGray;
            chip_year.Foreground = Brushes.Black;

            chip_month.Background = Brushes.LightGray;
            chip_month.Foreground = Brushes.Black;

            chip_yesterday.Background = Brushes.MediumPurple;
            chip_yesterday.Foreground = Brushes.White;

            chip_today.Background = Brushes.LightGray;
            chip_today.Foreground = Brushes.Black;

        }

        private void chip_today_Click(object sender, RoutedEventArgs e)
        {
            chip_year.Background = Brushes.LightGray;
            chip_year.Foreground = Brushes.Black;

            chip_month.Background = Brushes.LightGray;
            chip_month.Foreground = Brushes.Black;

            chip_yesterday.Background = Brushes.LightGray;
            chip_yesterday.Foreground = Brushes.Black;

            chip_today.Background = Brushes.MediumPurple;
            chip_today.Foreground = Brushes.White;
        }


    }
}
