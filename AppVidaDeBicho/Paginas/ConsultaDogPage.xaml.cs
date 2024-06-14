namespace AppVidaDeBicho.Paginas;

public partial class ConsultaDogPage : ContentPage
{
	public ConsultaDogPage()
	{
		InitializeComponent();
	}

    private async void btnMenuDC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuDogPage());
    }

    private async void btnUsuarioDC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioDogPage());
    }
}