using System;


using LoginApp.Servicios;
using LoginApp.Clases;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewUser : ContentPage
    {
        public NewUser()
        {
            InitializeComponent();
        }
        private async void btnNuevo_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                var user = new NuevoUsuario(txtUsername.Text, txtPassword.Text, txtEmail.Text);
                string message = await ServicioUser.NewUser(user);
                if (message != null)
                {
                    await DisplayAlert("Alert", message, "OK");
                }
            }
        }
    }
}