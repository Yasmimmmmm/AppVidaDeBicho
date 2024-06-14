namespace AppVidaDeBicho.Paginas;

public partial class SobreCatPage : ContentPage
{
	public SobreCatPage()
	{
		InitializeComponent();
	}

    private async void btnUsuarioSNC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioCatPage());
    }

    private async void btnMenuSNC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuCatPage());
    }
}