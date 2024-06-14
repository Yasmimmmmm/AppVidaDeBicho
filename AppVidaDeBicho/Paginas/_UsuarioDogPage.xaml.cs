namespace AppVidaDeBicho.Paginas;

public partial class _UsuarioDogPage : ContentPage
{
	public _UsuarioDogPage()
	{
		InitializeComponent();
	}

    private async void btnXVoltarDogUsuarioHD_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomeDogPage());
    }

    private async void btnMudarPetDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QualPetPage());
    }

    private async void btnMudarContaDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void btnMeuPerfilDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _PerfilDogPage());
    }

    private async void btnDesconectarDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}