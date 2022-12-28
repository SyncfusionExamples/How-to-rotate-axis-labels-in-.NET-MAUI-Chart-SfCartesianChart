using Syncfusion.Maui.Charts;

namespace SampleFile;
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        SfCartesianChart chart = new SfCartesianChart();
        this.BindingContext = new ViewModel();

        chart.Title = new Label
        {
            Text = "Height Comparison",
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            FontSize = 15,
        };
       
        // Initializing primary axis
        CategoryAxis primaryAxis = new CategoryAxis()
        {
            LabelRotation = 60,
            Title = new ChartAxisTitle()
            {
                Text = "Name"
            },

        };
        chart.XAxes.Add(primaryAxis);

        //Initializing secondary Axis
        NumericalAxis secondaryAxis = new NumericalAxis()
        {
            LabelRotation = 60,
            Title = new ChartAxisTitle()
            {
                Text = "Height(in cm)",
            },
        };
        chart.YAxes.Add(secondaryAxis);

        //Initialize the two series for SfChart
        ColumnSeries series = new ColumnSeries()
        {
            ItemsSource = (new ViewModel()).Data,
            XBindingPath = "Name",
            YBindingPath = "Height"
        };
    
        //Adding Series to the Chart Series Collection
        chart.Series.Add(series);
        this.Content = chart;
    }

}

