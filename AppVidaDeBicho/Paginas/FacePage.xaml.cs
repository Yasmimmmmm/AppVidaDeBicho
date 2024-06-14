namespace AppVidaDeBicho.Paginas;

public partial class FacePage : ContentPage
{
	public FacePage()
	{
		InitializeComponent();
	}

    private async void btnVoltarF_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void btnEntrarF_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QualPetPage());
    }
}