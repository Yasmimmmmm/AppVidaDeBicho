namespace AppVidaDeBicho.Paginas;

public partial class ConsultaCatPage : ContentPage
{
	public ConsultaCatPage()
	{
		InitializeComponent();
	}

    private async void btnMenuCC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuCatPage());
    }

    private async void btnUsuarioCC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioCatPage());
    }
}