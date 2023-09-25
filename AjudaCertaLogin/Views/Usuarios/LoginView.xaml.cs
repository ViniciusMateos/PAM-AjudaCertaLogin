using AjudaCertaLogin.Models;
using AjudaCertaLogin.ViewModels;

namespace AjudaCertaLogin.Views.Usuarios;

public partial class LoginView : ContentPage
{
    UsuarioViewModel viewModel;
    public LoginView()
	{
		InitializeComponent();
        viewModel = new UsuarioViewModel();
        BindingContext = viewModel;
    }
}