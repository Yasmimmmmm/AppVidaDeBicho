namespace AppVidaDeBicho.Paginas;

public partial class HomeDogPage : ContentPage
{
    public HomeDogPage()
    {
        InitializeComponent();
    }

    private async void btnLazerHD_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerDogPageUm());
    }

    private async void btnConsultaHD_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConsultaDogPage());
    }

    private async void btnRacaoHD_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RacaoDogPage());
    }

    private async void btnSobreNosHD_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobreDogPage());
    }

    private async void btnMenuDogHD_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _MenuDogPage());
    }

    private async void btnUsuarioDogHD_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new _UsuarioDogPage());
    }
}