using MVVMProjectSample.ViewModels;
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
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
            BarBackgroundColor = Color.DarkRed;
            BarTextColor = Color.White;
            BindingContext = new HomeViewModel();
        }

        private async void SignInUpButtonClicked(object sender, EventArgs e)
        {
            if (password.Text == confirmPassword.Text && !string.IsNullOrEmpty(username.Text))
            {
                await Navigation.PushModalAsync(new IndexPage());
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

        private async void OnRegisterLabelTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }


    }
}