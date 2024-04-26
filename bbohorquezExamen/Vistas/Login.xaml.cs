namespace bbohorquezExamen.Vistas;

public partial class Login : ContentPage
{
    string[] user = { "estudiante2024", "examen1", "bbohorquez" };
    string[] pass = { "uisrael2024", "parcial1", "2024" };
    public Login()
	{
		InitializeComponent();
	}

    public Login(string[] username, string[] password)
    {
        InitializeComponent();
        user = username;
        pass = password;
    }

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        string userIngresado = txtUsuario.Text;
        string passIngresada = txtContraseña.Text;
        bool accesoUsuario = false;
        for (int i = 0; i < user.Length; i++)
        {
            if (userIngresado == user[i] && passIngresada == pass[i])
            {
                accesoUsuario = true;
                break;
            }

        }
        if (accesoUsuario)
        {
            Navigation.PushAsync(new Registro(userIngresado));
            //Limpiar();
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/contraseña Incorrectos", "Cerrar");
        }
    }

    private void btnAcercaDe_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaDe());
    }
}