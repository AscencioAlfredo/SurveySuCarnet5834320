using System.Runtime.CompilerServices;

namespace SurveySuCarnet5834320;

public partial class SurveyDetailsView : ContentPage
{
	private readonly string[] teams =
{
	  "Alianza Lima",
	  "America",
	  "Boca Juniors",
	  "Caracas FC",
	   "Colo-Colo",
	   "Peñarol",
	   "Real Madrid",
	   "Saprissa"
			};

	public SurveyDetailsView()
	{
		InitializeComponent();
	}

	private async void FavoriteTeamButton_Clicked(object sender, EventArgs e)
	{
		var favoriteTeam = await DisplayActionSheet(Literals.FavoriteTeamTittle, null, null, teams);
		if (!string.IsNullOrWhiteSpace(favoriteTeam)) 
		{
			FavoriteTeamLabel.Text = favoriteTeam;
		}
 
    }

    [Obsolete]
    private async void OkButton_Clicked(object sender, EventArgs e)
	{
		if (string.IsNullOrWhiteSpace(NameEntry.Text) || string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
		{
			return;
		}

		var newSurvey = new Surveys()
		{
			Name = NameEntry.Text,
			Birthdate = BirthdatePicker.Date,
			FavoriteTeam = FavoriteTeamLabel.Text

		};

         MessagingCenter.Send((ContentPage)this,
		 Messages.NewSurveyComplete, newSurvey);
		await Navigation.PopAsync();
	}
}