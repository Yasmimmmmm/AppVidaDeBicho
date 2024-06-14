namespace AppVidaDeBicho.Paginas;

public partial class LazerCatPageTres : ContentPage
{
	public LazerCatPageTres()
	{
		InitializeComponent();
	}

    private async void btnMenuCLTres_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuCatPage());
    }

    private async void btnUsuarioCLTres_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioCatPage());
    }

    private async void btnIconEsquerdoCatDois_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerCatPageDois());
    }
}