namespace AppVidaDeBicho.Paginas;

public partial class _MenuCatPage : ContentPage
{
	public _MenuCatPage()
	{
		InitializeComponent();
	}

    private async void btnXVoltarCatMenuHC_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomeCatPage());
    }

    private async void btnIrRacaoCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RacaoCatPage());
    }

    private async void btnConsultasCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConsultaCatPage());
    }

    private async void btnHomeCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomeCatPage());
    }

    private async void btnAtivLazerCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerCatPageUm());
    }
}