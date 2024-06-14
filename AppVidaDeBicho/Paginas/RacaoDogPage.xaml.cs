namespace AppVidaDeBicho.Paginas;

public partial class RacaoDogPage : ContentPage
{
	public RacaoDogPage()
	{
		InitializeComponent();
	}

    private async void btnMenuDogRac_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuDogPage());
    }

    private async void btnUsuarioDogRac_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioDogPage());
    }
}