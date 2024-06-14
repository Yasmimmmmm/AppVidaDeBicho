namespace AppVidaDeBicho.Paginas;

public partial class LazerDogPageUm : ContentPage
{
	public LazerDogPageUm()
	{
		InitializeComponent();
	}

    private async void btnMenuDL_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuDogPage());
    }

    private async void btnUsuarioDL_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioDogPage());
    }

    private async void btnIconDireitaDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerDogPageDois());
    }
}