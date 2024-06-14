namespace AppVidaDeBicho.Paginas;

public partial class HomeCatPage : ContentPage
{
	public HomeCatPage()
	{
		InitializeComponent();
	}

    private async void btnMenuCatHC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuCatPage());
    }

    private async void btnUsuarioCatHC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioCatPage());
    }

    private async void btnSobreNosHC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobreCatPage());
    }

    private async void btnRacaoHC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RacaoCatPage());
    }

    private async void btnConsultaHC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConsultaCatPage());
    }

    private async void btnLazerHC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerCatPageUm());
    }
}