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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPass.Text;
            if (usuario == "estudiante2023" && password == "uisrael2023")
            {
                Navigation.PushAsync(new Registro(usuario));
                txtUsuario.Text = "";
                txtPass.Text = "";

            }
            else
            {
                DisplayAlert("Alerta", "Usuario o Contraseña incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtPass.Text = "";

            }

        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}