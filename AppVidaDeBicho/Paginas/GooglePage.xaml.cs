namespace AppVidaDeBicho.Paginas;

public partial class GooglePage : ContentPage
{
	public GooglePage()
	{
		InitializeComponent();
	}

    private async void btnVoltarG_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void btnEntrarG_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QualPetPage());
    }
}