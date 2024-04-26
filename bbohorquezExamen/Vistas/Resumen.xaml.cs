namespace bbohorquezExamen.Vistas;

public partial class Resumen : ContentPage
{
	public Resumen(string usuario, string nombre, string apellido, int edad, double pagoTotal,double cuota, DateTime fecha,string ciudad, string pais,double montoini)
	{
		InitializeComponent();
        lblUsuario.Text = usuario;
		txtNombre.Text = nombre;
		txtApellido.Text = apellido;
		txtEdad.Text = edad.ToString();
		txtFecha.Text = fecha.ToString();
		txtCiudad.Text = ciudad.ToString();
		txtPais.Text = pais.ToString();
		txtMontoIni.Text = montoini.ToString();
		txtPagoMensual.Text = cuota.ToString();
		txtPagoTotal.Text = pagoTotal.ToString();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Login());
    }
}