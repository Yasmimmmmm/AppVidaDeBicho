namespace AppVidaDeBicho.Paginas;

public partial class _PerfilCatPage : ContentPage
{
	public _PerfilCatPage()
	{
		InitializeComponent();
	}

    private async void btnVoltarPerfilCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioCatPage());
    }
}