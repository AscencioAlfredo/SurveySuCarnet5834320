namespace SurveySuCarnet5834320;

public partial class SurveysView : ContentPage
{
    [Obsolete]
    public SurveysView()
	{
		InitializeComponent();
		MessagingCenter.Subscribe<ContentPage, Surveys>(this, Messages.NewSurveyComplete, (sender, args) =>
		{
			SurveysPanel.Children.Add(new Label() { Text = args.ToString() });
		});
	}

	private async void AddSurveyButton_Clicked (object sender, EventArgs e)
	{
		await Navigation.PushAsync (new SurveyDetailsView());
	}
}