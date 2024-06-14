namespace AppVidaDeBicho.Paginas;

public partial class TwetPage : ContentPage
{
	public TwetPage()
	{
		InitializeComponent();
	}

    private async void btnVoltarT_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void btnEntrarT_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QualPetPage());
    }
}