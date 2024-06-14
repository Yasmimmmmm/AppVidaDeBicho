namespace AppVidaDeBicho.Paginas;

public partial class _PerfilDogPage : ContentPage
{
	public _PerfilDogPage()
	{
		InitializeComponent();
	}

    private async void btnVoltarPerfilDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioDogPage());
    }
}