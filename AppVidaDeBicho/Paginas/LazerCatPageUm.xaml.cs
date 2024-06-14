namespace AppVidaDeBicho.Paginas;

public partial class LazerCatPageUm : ContentPage
{
	public LazerCatPageUm()
	{
		InitializeComponent();
	}

    private async void btnMenuCL_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuCatPage());
    }

    private async void btnUsuarioCL_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioCatPage());
    }

    private async void btnIconDireitaCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerCatPageDois());
    }
}