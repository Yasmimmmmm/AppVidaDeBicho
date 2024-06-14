namespace AppVidaDeBicho.Paginas;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(senha))
        {
            var usuario = await App.BancoDados.UsuarioDataTable.ObtemUsuario(email, senha);
            if (usuario != null)
            {
                await DisplayAlert("Erro", "Uusário ou Senha inválidos", "OK");
                return;
            }

            App.Usuario = usuario;
        }

        await DisplayAlert("Sucesso", "Login efetuado com Sucesso", "OK");
        await Navigation.PushAsync(new QualPetPage());
    }

    private async void btnRegistrarse_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditaUsuarioPage());
    }

    private async void btnGoogle_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GooglePage());
    }

    private async void btnFace_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FacePage());
    }

    private async void btnTwet_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TwetPage());
    }
}