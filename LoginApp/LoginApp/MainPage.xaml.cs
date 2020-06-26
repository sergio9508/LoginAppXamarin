using System;
using System.ComponentModel;
using Xamarin.Forms;
using LoginApp.Servicios;
using LoginApp.Clases;

namespace LoginApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            labelErrors.IsVisible = false;
        }


        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                var user = new User(txtUsername.Text, txtPassword.Text);
                Session login = await ServicioUser.Login(user);
                if (login != null)
                {
                    this.BindingContext = login;
                    labelErrors.IsVisible = login.errors != null;
                    if (login.token != null)
                    {
                        await DisplayAlert("Alert", "Iniciaste sesion", "OK");
                    }
                }
            }
        }

        private async void btnNew_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewUser());
        }

    }
}
