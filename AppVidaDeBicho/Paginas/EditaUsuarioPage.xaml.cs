using AppVidaDeBicho.Model;

namespace AppVidaDeBicho.Paginas;

public partial class EditaUsuarioPage : ContentPage
{
    Usuario _usuario;

    public EditaUsuarioPage()
    {
        _usuario = new Usuario();

        this.BindingContext = _usuario;

        InitializeComponent();
    }

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_usuario.Email) && string.IsNullOrEmpty(_usuario.Senha) && string.IsNullOrEmpty(_usuario.Nome))
        {
            await DisplayAlert("Erro", "Preencha todas as informações", "Fechar");
            return;
        }
        var cadastro = await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);

        if (cadastro > 0)
        {
            await DisplayAlert("Sucesso", "Usuário cadastrado com sucesso", "Fechar");
            await Navigation.PopAsync();
        }
    }

    private async void btnVoltarR_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void btnGoogleR_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GooglePage());
    }

    private async void btnFaceR_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FacePage());
    }
    private async void btnTwetR_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TwetPage());
    }


}

