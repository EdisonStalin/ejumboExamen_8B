using Microsoft.Win32;

namespace ejumbo8B.Views;

public partial class LoginPage : ContentPage
{
    private Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "estudiante2024", "uisrael2024" },
            { "examen1", "parcial1" },
            { "NombreEstudiante", "2024" }
        };

    public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        if (users.TryGetValue(usernameEntry.Text, out var password) && password == passwordEntry.Text)
        {
            await Navigation.PushAsync(new RegistroPage(usernameEntry.Text));
        }
        else
        {
            await DisplayAlert("Error", "Datos incorrectos", "OK");
        }
    }


    private async void OnAboutClicked(object sender, EventArgs e)
    {

        DisplayAlert("Acerca de", "Este promaga fue desarrollado por Edison Jumbo", "OK");

    }
}