namespace bbohorquezExamen.Vistas;

public partial class Registro : ContentPage
{
    string nombre;
    string apellido;
    int edad;
    DateTime fechaSeleccionada = DateTime.Now;
    string ciudad;
    string pais;
    double montoIni;
    double pagoMensual;
    double pagoTotal;
    double cuota;
    double costo = 1500;

    public Registro(string usuario)
	{
		InitializeComponent();
        DisplayAlert("Alert", "Bienvenid@ " + usuario, "OK");
        lblUsuario.Text = "Usuario conectado: " + usuario;
    }

    private void dpFecha_DateSelected(object sender, DateChangedEventArgs e)
    {
        fechaSeleccionada = dpFecha.Date;
    }

    private void pkPais_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(pkPais.SelectedIndex != 1)
        {
            pais = pkPais.SelectedItem.ToString();
        }
    }

    private void pkCiudad_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(pkCiudad.SelectedIndex != 1)
        {
            ciudad = pkCiudad.SelectedItem.ToString();
        }
    }

    private void btnCalcularPago_Clicked(object sender, EventArgs e)
    {
        montoIni = Convert.ToDouble(txtmontoIni.Text);
        cuota = ((costo - montoIni) / 4 + (costo * 0.04));
        pagoTotal = ((cuota*4) + montoIni);
        txtpagoMensual.Text = Convert.ToString(cuota);
        if (montoIni > 0 && montoIni <1500)
        {
            txtpagoMensual.Text = Convert.ToString(cuota);

        }
        else
        {
            txtpagoMensual.Text = "Ingrese un valor Mayor a 0 y menor a 1500";
        }
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        nombre = txtNombre.Text;
        apellido = txtApellido.Text;
        edad = Convert.ToInt32(txtEdad.Text);

        string useringresado = lblUsuario.Text;
        Navigation.PushAsync(new Resumen(useringresado,nombre,apellido,edad, pagoTotal,cuota, fechaSeleccionada,ciudad,pais,montoIni));

    }
}