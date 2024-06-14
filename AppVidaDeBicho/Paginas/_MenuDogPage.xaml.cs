namespace AppVidaDeBicho.Paginas;

public partial class _MenuDogPage : ContentPage
{
	public _MenuDogPage()
	{
		InitializeComponent();
	}

    private async void btnXVoltarDogMenuHD_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomeDogPage());
    }

    private async void btnHomeDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomeDogPage());
    }

    private async void btnAtivLazerDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LazerDogPageUm());
    }

    private async void btnConsultasDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConsultaDogPage());
    }

    private async void btnIrRacaoDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RacaoDogPage());
    }
}