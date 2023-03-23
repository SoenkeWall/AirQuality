using Syncfusion.Maui.Charts;

namespace airQuality;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new ViewModel();

        SfCartesianChart chart = new SfCartesianChart();

        // Initializing primary axis
        CategoryAxis primaryAxis = new CategoryAxis();
        primaryAxis.Title = new ChartAxisTitle
        {
            Text = "Name",
        };
        chart.XAxes.Add(primaryAxis);

        //Initializing secondary Axis
        NumericalAxis secondaryAxis = new NumericalAxis();
        secondaryAxis.Title = new ChartAxisTitle
        {
            Text = "Height(in cm)",
        };
        chart.YAxes.Add(secondaryAxis);

        //Initialize the two series for SfChart
        ColumnSeries series = new ColumnSeries();
        series.Label = "Height";
        series.ShowDataLabels = true;
        series.ItemsSource = (new ViewModel()).Data;
        series.XBindingPath = "Name";
        series.YBindingPath = "Height";

        //Adding Series to the Chart Series Collection
        chart.Series.Add(series);
    }

	async private void OnSettingsClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new DetailPage());
    }
}

