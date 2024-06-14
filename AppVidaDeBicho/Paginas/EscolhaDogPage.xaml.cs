namespace AppVidaDeBicho.Paginas;

public partial class EscolhaDogPage : ContentPage
{
	public EscolhaDogPage()
	{
		InitializeComponent();
	}

    private async void btnHomeDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomeDogPage());
    }

    private async void btnVoltarDog_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QualPetPage());
    }
}