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
	public partial class VentanaResumen : ContentPage
	{
		public VentanaResumen (string Nombre, string mensual, string total, string usuario)
		{
			InitializeComponent ();
		    lblNombre.Text = Nombre;
			lblPagoMensual.Text = mensual;
			lblPagototal.Text = total;
			txtUsuario2.Text = usuario;

		}
	}
}