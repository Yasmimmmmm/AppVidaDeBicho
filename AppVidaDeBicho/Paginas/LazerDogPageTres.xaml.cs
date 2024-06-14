namespace AppVidaDeBicho.Paginas;

public partial class LazerDogPageTres : ContentPage
{
	public LazerDogPageTres()
	{
		InitializeComponent();
	}

    private async void btnMenuDLTres_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuDogPage());
    }

    private async void btnUsuarioDLTres_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioDogPage());
    }

    private async void btnIconEsquerdoDogDois_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerDogPageDois());
    }
}