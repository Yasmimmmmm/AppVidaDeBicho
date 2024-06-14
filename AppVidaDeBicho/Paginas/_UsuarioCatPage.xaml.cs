namespace AppVidaDeBicho.Paginas;

public partial class _UsuarioCatPage : ContentPage
{
	public _UsuarioCatPage()
	{
		InitializeComponent();
	}

    private async void btnXVoltarCatUsuarioHC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomeCatPage());
    }

    private async void btnMudarPetCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QualPetPage());
    }

    private async void btnMudarContaCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void btnDesconectarCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void btnMeuPerfilCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _PerfilCatPage());
    }
}