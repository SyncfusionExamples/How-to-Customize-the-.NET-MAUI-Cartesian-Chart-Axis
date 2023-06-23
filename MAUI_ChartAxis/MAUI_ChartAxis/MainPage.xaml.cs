namespace MAUI_ChartAxis;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void DateTimeAxis_LabelCreated(object sender, Syncfusion.Maui.Charts.ChartAxisLabelEventArgs e)
    {
		if(e.Label.ToString()=="June-27")
		{
			e.LabelStyle = new Syncfusion.Maui.Charts.ChartAxisLabelStyle()
			{
				TextColor = Colors.Red,
				FontAttributes = FontAttributes.Bold,
				Background = Colors.Black,
			};
		}
    }
}

