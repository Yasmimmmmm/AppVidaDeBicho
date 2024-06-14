namespace AppVidaDeBicho.Paginas;

public partial class EscolhaCatPage : ContentPage
{
	public EscolhaCatPage()
	{
		InitializeComponent();
	}

    private async void btnVoltarCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QualPetPage());
    }

    private async void btnHomeCat_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomeCatPage());
    }
}