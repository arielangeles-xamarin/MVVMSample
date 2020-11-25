using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMProjectSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void SignInUpButtonClicked(object sender, EventArgs e)
        {
            if (password.Text == confirmPassword.Text && !string.IsNullOrEmpty(username.Text))
            {
                await DisplayAlert("Succesfull register", "You have succesfully registered", "Ok");
                await Navigation.PushModalAsync(new HomePage());
            }
            else
            {
                if (string.IsNullOrEmpty(username.Text))
                {
                    await DisplayAlert("Invalid username", "Insert a valid username, please", "Ok");
                }
                else
                {
                    await DisplayAlert("Invalid password", "Passwords are not the same", "Ok");
                }

            }

        }
    }
}