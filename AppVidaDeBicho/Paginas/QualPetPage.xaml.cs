namespace AppVidaDeBicho.Paginas;

public partial class QualPetPage : ContentPage
{
	public QualPetPage()
	{
		InitializeComponent();
	}

    private async void btnVoltarQ_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void btnEscolhaCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EscolhaCatPage());
    }

    private async void btnEscolhaDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EscolhaDogPage());
    }
}