namespace AppVidaDeBicho.Paginas;

public partial class LazerDogPageDois : ContentPage
{
	public LazerDogPageDois()
	{
		InitializeComponent();
	}

    private async void btnMenuDLDois_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuDogPage());
    }

    private async void btnUsuarioDLDois_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioDogPage());
    }

    private async void btnIconEsqDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerDogPageUm());
    }

    private async void btnIconDireitaDogDois_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerDogPageTres());
    }
}