namespace SurveySuCarnet5834320;

public partial class App : Application
{
    [Obsolete]
    public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new SurveysView());
	}
}
