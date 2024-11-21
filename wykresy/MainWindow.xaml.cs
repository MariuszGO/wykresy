using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using OxyPlot;
using OxyPlot.Series;











namespace wykresy
{
    /// <summary>
    using System;

    using OxyPlot;
    using OxyPlot.Series;

    public class MainViewModel
    {
        public MainViewModel()
        {
            this.MyModel = new PlotModel { Title = "Example 1" };
            this.MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
        }

        public PlotModel MyModel { get; private set; }
    }





    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();

    }
    }


}
