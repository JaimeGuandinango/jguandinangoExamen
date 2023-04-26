using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jguandinangoExamen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registro : ContentPage
	{
		public Registro (string usuario)
		{
           InitializeComponent();
            txtUsuario.Text = usuario;
 
        }

        private void btnCalcularP_Clicked(object sender, EventArgs e)
        {
            double montototal = 3000;
            double datouno = Convert.ToDouble(txtMinicial.Text);
            if (datouno>= 3000)
            {
                DisplayAlert("Alerta", "Usar Cantidades menores a 3000", "Cerrar");
            }
            else {
                
                double calculo = ((montototal * 1.05) - datouno) / 3;
                double pagotot = (calculo * 3) + datouno;
                txtPagoMensual.Text = calculo.ToString("N2");
                txtPagot.Text = pagotot.ToString();

            }

        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string Nombre = txtNombrer.Text;
            string mensual = txtPagoMensual.Text;
            string total = txtPagot.Text;
            string usuario= txtUsuario.Text;
            DisplayAlert("Alerta", "Estudiante Guardado con exito", "Aceptar");
            Navigation.PushAsync(new VentanaResumen(Nombre, mensual,total, usuario));
            txtNombrer.Text = "";
            txtMinicial.Text = "";
            txtPagoMensual.Text = "";
            txtPagot.Text = "";

        }
    }
}