namespace AppVidaDeBicho.Paginas;

public partial class SobreDogPage : ContentPage
{
	public SobreDogPage()
	{
		InitializeComponent();
	}

    private async void btnMenuSND_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuDogPage());
    }

    private async void btnUsuarioSND_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioCatPage());
    }
}