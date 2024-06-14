namespace AppVidaDeBicho.Paginas;

public partial class RacaoCatPage : ContentPage
{
	public RacaoCatPage()
	{
		InitializeComponent();
	}

    private async void btnMenuCatRac_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuCatPage());
    }

    private async void btnUsuarioRac_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioCatPage());
    }
}