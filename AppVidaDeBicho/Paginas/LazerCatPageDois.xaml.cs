namespace AppVidaDeBicho.Paginas;

public partial class LazerCatPageDois : ContentPage
{
	public LazerCatPageDois()
	{
		InitializeComponent();
	}

    private async void btnMenuCLDois_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuCatPage());
    }

    private async void btnUsuarioCLDois_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioCatPage());
    }

    private async void btnIconDireitaCatDois_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerCatPageTres());
    }

    private async void btnIconEsqCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerCatPageUm());
    }
}